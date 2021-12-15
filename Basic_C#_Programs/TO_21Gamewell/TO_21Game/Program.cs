﻿/*
Este programa muestra el juego de 21
Autor: David Cortes
Fecha de creacion: 2 de diciembre de 2021
Feha de ultima modificacion: 6 de diciembre de 2021
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace TO_21Game
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";

            Console.WriteLine("Welcome to the {0}. Lets start by telling me your name", casinoName);
            string playerName = Console.ReadLine();
            if (playerName.ToLower()=="admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach(var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();

                }
                Console.Read();
                return;
            }
            bool validAnsweer = false;
            int bank = 0;
            while (!validAnsweer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnsweer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnsweer) Console.WriteLine("Please enter digits only, on decimals.");
            }

            Console.WriteLine("Hello, {0}. Would you like to join a game of game 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (BufferedStream file = new StreamWriter(@"C:\\User\\"))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudExeption ex)
                    {
                        Console.WriteLine("Security ! Kick this person out.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred. Please contact your System Administrator.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }

        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=game21;" +
                                        "Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
                                        "TrustServerCertificate=False;ApplicationIntent=ReadWrite;" +
                                        "MultiSubnetFailover=False";

            string queryString = @"INSERT INTO Exception (ExceptionType, ExeptionMessage, TimeStamp) VALUES (@ExceptionType, @ExeptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExeptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExeptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            } 
        }  

        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=game21;" +
                                        "Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
                                        "TrustServerCertificate=False;ApplicationIntent=ReadWrite;" +
                                        "MultiSubnetFailover=False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection =new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);

                }
                connection.Close()
            }
            return Exceptions;
        }
        /// <summary>
        // metodo barajear shuffle
        /// </summary>
        /// <param name="deck"></param>
        /// <returns></returns>
        /// 
        // se crea el metodo shuffle barajear tipo deck que ingresa un valor tipo deck llamado deck

        

        //public static Deck Shuffle (Deck deck, int times)
        //{
        //    for (int i=0; i < times;i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
