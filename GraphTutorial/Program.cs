using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using GraphTutorial.Graph;
using System.Globalization;

namespace GraphTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".NET Core Graph Tutorial\n");

            var appConfig = LoadAppSettings();

            if (appConfig == null)
            {
                Console.WriteLine("Missing or invalid appsettings.json...exiting program");
                return;
            }

            var appId = appConfig["appId"];
            var scopesString = appConfig["scopes"];
            var scopes = scopesString.Split(';');

            //Initialize Graph Client
            GraphHelper.Initialize(appId, scopes, (code, cancellation) =>
             {
                 Console.WriteLine(code.Message);
                 return Task.FromResult(0);
             });

            var accessToken = GraphHelper.GetAccessTokenAsync(scopes).Result;

            //Get signed in user
            var user = GraphHelper.GetMeAsync().Result;
            Console.WriteLine($"Welcome {user.DisplayName}!\n");

            //Check for timezone and date/time formats in mailbox settings
            //Use defaults if absent
            var userTimeZone = !string.IsNullOrEmpty(user.MailboxSettings?.TimeZone) ? user.MailboxSettings?.TimeZone : TimeZoneInfo.Local.StandardName;
            var userDateFormat = !string.IsNullOrEmpty(user.MailboxSettings?.DateFormat) ? user.MailboxSettings?.DateFormat : CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            var userTimeFormat = !string.IsNullOrEmpty(user.MailboxSettings?.TimeFormat) ? user.MailboxSettings?.TimeFormat : CultureInfo.CurrentCulture.DateTimeFormat.ShortTimePattern;



            int choice = -1;

            while (choice != 0)
            {
                Console.WriteLine("Please choose one of the following options:");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Display access token");
                Console.WriteLine("2. View this week's calendar");
                Console.WriteLine("3. Add an event");

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    //Set to invalid value to resolve the problem
                    choice = -1;
                }

                switch (choice)
                {
                    case 0:
                        //Exit the program
                        Console.WriteLine("Goodbye");
                        break;
                    case 1:
                        //Display access token
                        Console.WriteLine($"Access token: {accessToken}\n");

                        break;
                    case 2:
                        //List the calendar
                        ListCalendarEvents(userTimeZone, $"{userDateFormat} {userTimeFormat}");

                        break;
                    case 3:
                        //Create a new event

                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
                

            }

            Console.WriteLine("Hello World!");


        }

        static IConfigurationRoot LoadAppSettings()
        {
            var appConfig = new ConfigurationBuilder()
                .AddUserSecrets<Program>()
                .Build();

            //Check the appConfig for required settings
            if (string.IsNullOrEmpty(appConfig["appId"]) ||
                string.IsNullOrEmpty(appConfig["scopes"]))
            {
                return null;
            }

            return appConfig;
        }

        //Display the results
        static string FormatDateTimeTimeZone(Microsoft.Graph.DateTimeTimeZone value, string dateTimeFormat)
        {
            //Parse the date/time string from Graph into a DateTime
            var dateTime = DateTime.Parse(value.DateTime);

            return dateTime.ToString(dateTimeFormat);
        }

        static void ListCalendarEvents(string userTimeZone, string dateTimeFormat)
        {
            var events = GraphHelper.GetCurrentWeekCalendarViewAsync(DateTime.Today, userTimeZone).Result;

            Console.WriteLine($"Events:");

            foreach (var calendarEvent in events)
            {
                Console.WriteLine($"Subject: {calendarEvent.Subject}");
                Console.WriteLine($"     Organizer: {calendarEvent.Organizer}");
                Console.WriteLine($"     Start: {FormatDateTimeTimeZone(calendarEvent.Start, dateTimeFormat)}");
                Console.WriteLine($"     End: {FormatDateTimeTimeZone(calendarEvent.End, dateTimeFormat)}");
            }
        }

        //Logit to process whether a user is saying yes or no
        static bool GetUserYesNo(string prompt)
        {
            //This looks like a re-usable prompt
            Console.Write($"{prompt} (y/n)");

            ConsoleKeyInfo confirm;
            do
            {
                confirm = Console.ReadKey(true);

            }
            //Continue to read the console key until it is either Y or N
            while (confirm.Key != ConsoleKey.Y && confirm.Key != ConsoleKey.N);

            Console.WriteLine();

            //Return whether the console key is Y
            return (confirm.Key == ConsoleKey.Y);
        }

        //Gets user input for one particular field
        static string GetUserInput(string fieldName, bool isRequired, Func<string, bool> validate)
        {
            //Make the returnValue variable
            string returnValue = null;

            do
            {
                //Prompt the user for input for that particular field
                Console.Write($"Enter a {fieldName}: ");

                if (!isRequired)
                {
                    //Only tease enter to skip if the field is not required
                    Console.Write($"(ENTER to skip) ");
                }
                
                //Actually collect the input from the user
                var input = Console.ReadLine();

                //If the string is not null or empty
                if (!string.IsNullOrEmpty(input))
                {
                    //Not sure what this is checking
                    if (validate.Invoke(input))
                    {
                        //Send the input as the return
                        returnValue = input;
                    }
                }
            }

            while (string.IsNullOrEmpty(returnValue) && isRequired);

            return returnValue;
        }
    }
}
