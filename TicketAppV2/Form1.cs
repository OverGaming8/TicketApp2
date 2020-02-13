using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace TicketAppV2
{
    public partial class Form1 : Form
    {
        DateTime time = DateTime.Now;
        string date;
        string fullDate;
        readonly string path = Directory.GetCurrentDirectory();
        string[] database = null;
        string operation = null;
        string input = null;
        int parsed = 0;
        int[] database1 = null;
        bool found = false;
        string[] file1 = null;
        string[] file2 = null;
        string[] log = null;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            operation = a.ToString();
            string button = a.Text;
            switch (button)
            {
                case "Regenerate":
                    SearchBar.Text = "";
                    error.Text = "";
                    InfoBar.Text = "";
                    InputBar.Text = "";
                    StatusBar.Text += date + "- How many tickets you want to generate?\r\n";
                    operation = "Regenerate";
                    InfoBar.Text = "Enter a number between 1 and 5000.";
                    break;
                case "LogClear":
                    error.Text = "";
                    StatusBar.Text = "";
                    InfoBar.Text = "Log cleared successfully.";
                    break;
                case "Use":
                    SearchBar.Text = "";
                    error.Text = "";
                    InfoBar.Text = "Waiting for input";
                    InputBar.Text = "";
                    StatusBar.Text += date + "- Type the ticket number to use it.\r\n";
                    operation = "Use";
                    InfoBar.Text = "Enter the ticket number.";
                    break;
                case "Clear":
                    SearchBar.Text = "";
                    error.Text = "";
                    InfoBar.Text = "Waiting for input";
                    InputBar.Text = "";
                    StatusBar.Text += date + "- Type the ticket number to clear it.\r\n";
                    operation = "Clear";
                    InfoBar.Text = "Enter the ticket number.";
                    break;
                case "Sell":
                    SearchBar.Text = "";
                    error.Text = "";
                    InfoBar.Text = "Waiting for input";
                    InputBar.Text = "";
                    StatusBar.Text += date + "- Type the ticket number to sell it.\r\n";
                    operation = "Sell";
                    InfoBar.Text = "Enter the ticket number.";
                    break;
                case "Status":
                    SearchBar.Text = "";
                    error.Text = "";
                    InfoBar.Text = "";
                    InputBar.Text = "";
                    StatusBar.Text += date + "- The tickets status:\r\n";
                    operation = "";
                    InfoBar.Text = "Ticket Information.";
                    StatusButton(database1);
                    break;
                case "Save":
                    SaveFiles(database, database1, path);
                    break;
                case "Load":
                    database = LoadFiles1(path);
                    database1 = LoadFiles2(path);
                    break;
                case "Wipe":
                    SearchBar.Text = "";
                    database = null;
                    database1 = null;
                    InputBar.Text = "";
                    AllTickets.Text = "";
                    StatusBar.Text += date + "- All tickets wiped\r\n";
                    InfoBar.Text = "Tickets wiped.";
                    break;
                case "Search Number":
                    SearchBar.Text = "";
                    error.Text = "";
                    InfoBar.Text = "Type the number.";
                    InputBar.Text = "";
                    StatusBar.Text += date + "- Type the ticket number to search it.\r\n";
                    operation = "Search Number";
                    InfoBar.Text = "Enter the ticket number.";
                    break;
                case "Quit":
                    Application.Exit();
                    break;
            }
        }
        private void InputEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Return))
            {
                TextBox a = (TextBox)sender;
                int counter = 1;
                switch (operation)
                {
                    case "Regenerate":
                        InfoBar.Text = "Enter a number between 1 and 5000.";
                        input = InputBar.Text;
                        if (int.TryParse(input, out parsed))
                        {
                            if (parsed > 0 && parsed <= 5000)
                            {
                                error.Text = "";
                                int j = 0;
                                database = new string[parsed];
                                database1 = new int[parsed];
                                Random random = new Random();
                                for (int i = 0; i <= parsed - 1; i++)
                                {
                                    database1[i] = random.Next(1000000, 7500000);
                                    for (j = 0; j < i; j++)
                                    {
                                        if (database1[i] == database1[j])
                                        {
                                            database1[i] += 19;
                                        }
                                    }
                                    for (int k = parsed - 1; k > i; k--)
                                    {
                                        if (database1[i] == database1[j])
                                        {
                                            database1[i] += 19;
                                        }
                                    }
                                    database[i] = database1[i].ToString();
                                }
                                AllTickets.Text = "";
                                foreach (var item in database)
                                {
                                    AllTickets.ForeColor = Color.Black;
                                    AllTickets.Text += counter + " - ";
                                    AllTickets.Text += item + "\r\n";
                                    counter++;
                                }
                                counter = 1;
                                StatusBar.Text += date + "- " + parsed + " numbers generated successfully!\r\n";
                                InfoBar.Text = parsed + " numbers generated successfully!";
                                InputBar.Text = "";
                                operation = "";
                            }
                            if (parsed > 5000 || parsed <= 0)
                            {
                                InfoBar.Text = "";
                                StatusBar.Text += date + "- The amount of tickets is too large. The maximum ticket ammount is 5000.\r\n";
                                error.Text = "Incorrect input!";
                                InputBar.Text = "";
                            }
                        }
                        if (!int.TryParse(input, out parsed))
                        {
                            InfoBar.Text = "";
                            StatusBar.Text += date + "- Incorrect format or too large number. The maximum ticket ammount is 5000.\r\n";
                            error.Text = "Incorrect input!";
                            InputBar.Text = "";
                        }
                        break;
                    case "Use":
                        InfoBar.Text = "Enter the ticket number.";
                        input = InputBar.Text;
                        if (int.TryParse(input, out parsed))
                        {
                            if (parsed > 1000000 && parsed < 9999999)
                            {
                                counter = 1;
                                foreach (var item in database)
                                {
                                    try
                                    {
                                        if (parsed.ToString() == database[counter - 1])
                                        {
                                            error.Text = "";
                                            InfoBar.Text = "the " + (counter) + " - " + parsed + " ticket successfully used!";
                                            StatusBar.Text += date + "- Ticket is exist in database: " + (counter) + " - " + parsed + "\r\n";

                                            database[counter - 1] = database[counter - 1] + " was Used";
                                            found = true;
                                            database1[counter - 1] = 1;
                                            break;
                                        }
                                        if (parsed.ToString() + " was Sold" == database[counter - 1])
                                        {
                                            found = true;
                                            InfoBar.Text = "the " + (counter) + " - " + parsed + " ticket successfully used!";
                                            StatusBar.Text += date + "- Ticket is exist in database: " + (counter) + " - " + parsed + "\r\n";
                                            database1[counter - 1] = 1;
                                            database[counter - 1] = parsed + " was Used";
                                            error.Text = "";
                                            break;
                                        }
                                        if (parsed.ToString() + " was Used" == database[counter - 1])
                                        {
                                            found = true;
                                            error.Text = "This ticket was already used!";
                                            break;
                                        }
                                        else
                                        {
                                            found = false;
                                        }
                                        counter++;
                                    }
                                    catch (Exception)
                                    {
                                        continue;
                                    }
                                }
                                if (found == false)
                                {
                                    InfoBar.Text = "";
                                    error.Text = "the ticket was not found!";
                                    StatusBar.Text += date + "- the ticket was not found!\r\n";
                                }
                                counter = 1;
                                AllTickets.Text = "";
                                foreach (var item in database)
                                {
                                    AllTickets.Text += counter + " - ";
                                    AllTickets.Text += item + "\r\n";
                                    counter++;
                                }
                                counter = 1;
                                InputBar.Text = "";
                            }
                            else
                            {
                                StatusBar.Text += date + "- Ticket not found in database.\r\n";
                                error.Text = "ticket not found!";
                                InputBar.Text = "";
                                InfoBar.Text = "";
                            }
                        }
                        if (!int.TryParse(input, out parsed))
                        {
                            error.Text = "You must enter a 7 digit code!";
                            InputBar.Text = "";
                            StatusBar.Text += date + "- Incorrect 7 digit code!\r\n";
                            InfoBar.Text = "";
                        }
                        break;
                    case "Clear":
                        InfoBar.Text = "Enter the ticket number.";
                        input = InputBar.Text;
                        if (int.TryParse(input, out parsed))
                        {
                            if (parsed > 1000000 && parsed < 9999999)
                            {
                                counter = 1;
                                foreach (var item in database)
                                {
                                    try
                                    {
                                        int parser = int.Parse(item);
                                        if (parsed == parser)
                                        {
                                            error.Text = "";
                                            InfoBar.Text = "the " + (counter) + " - " + parsed + " ticket successfully cleared!";
                                            StatusBar.Text += date + "- Ticket is exist in database: " + (counter) + " - " + parsed + "\r\n";

                                            database[counter - 1] = "Empty";
                                            InfoBar.Text = "Number successfully cleared.";
                                            found = true;
                                            database1[counter - 1] = 0;
                                            break;
                                        }
                                        else
                                        {
                                            found = false;
                                        }
                                        counter++;
                                    }
                                    catch (Exception)
                                    {
                                        if (parsed.ToString() + " was Sold" == database[counter - 1])
                                        {
                                            found = true;
                                            StatusBar.Text = date + "- You cannot clear a ticket which was already sold!";
                                            error.Text = "This ticket was already sold!";
                                            break;
                                        }
                                        if (parsed.ToString() + " was Used" == database[counter - 1])
                                        {
                                            found = true;
                                            StatusBar.Text = date + "- You cannot clear a ticket which was already used!";
                                            error.Text = "This ticket was already used!";
                                            break;
                                        }
                                        found = false;
                                        counter++;
                                        continue;
                                    }
                                }
                                counter = 1;
                                AllTickets.Text = "";
                                foreach (var item in database)
                                {
                                    AllTickets.Text += counter + " - ";
                                    AllTickets.Text += item + "\r\n";
                                    counter++;
                                }
                                counter = 1;
                                InputBar.Text = "";
                            }
                            if (found == false)
                            {
                                error.Text = "the ticket was not found!";
                                StatusBar.Text += date + "- the ticket was not found!\r\n";
                            }
                        }
                        if (!int.TryParse(input, out parsed))
                        {
                            error.Text = "You must enter a 7 digit code!";
                            InputBar.Text = "";
                            StatusBar.Text += date + "- Incorrect 7 digit code!\r\n";
                            InfoBar.Text = "";
                        }
                        break;
                    case "Sell":
                        InfoBar.Text = "Enter the ticket number.";
                        input = InputBar.Text;
                        if (int.TryParse(input, out parsed))
                        {
                            if (parsed > 1000000 && parsed < 9999999)
                            {
                                counter = 1;
                                foreach (var item in database)
                                {
                                    try
                                    {
                                        int parser = int.Parse(item);
                                        if (parsed == parser)
                                        {
                                            error.Text = "";
                                            InfoBar.Text = "the " + (counter) + " - " + parsed + " ticket successfully sold for ";
                                            StatusBar.Text += date + "- Ticket is exist in database: " + (counter) + " - " + parsed + "\r\n";

                                            database[counter - 1] = database[counter - 1] + " was Sold";
                                            InfoBar.Text = "Number successfully sold.";
                                            database1[counter - 1] = 2;
                                            found = true;
                                            break;
                                        }
                                        else
                                        {
                                            found = false;
                                        }
                                        counter++;
                                    }
                                    catch (Exception)
                                    {
                                        if (parsed.ToString() + " was Sold" == database[counter - 1])
                                        {
                                            found = true;
                                            error.Text = "This ticket was already sold!";
                                            break;
                                        }
                                        if (parsed.ToString() + " was Used" == database[counter - 1])
                                        {
                                            found = true;
                                            error.Text = "This ticket was already used!";
                                            break;
                                        }
                                        found = false;
                                        counter++;
                                        continue;
                                    }
                                }
                                if (found == false)
                                {
                                    error.Text = "the ticket was not found!";
                                    StatusBar.Text += date + "- the ticket was not found!\r\n";
                                }
                                counter = 1;
                                AllTickets.Text = "";
                                foreach (var item in database)
                                {
                                    AllTickets.Text += counter + " - ";
                                    AllTickets.Text += item + "\r\n";
                                    counter++;
                                }
                                counter = 1;
                                InputBar.Text = "";
                            }
                            else
                            {
                                StatusBar.Text += date + "- Ticket not found in database.\r\n";
                                error.Text = "ticket not found!";
                                InputBar.Text = "";
                                InfoBar.Text = "";
                            }
                        }
                        if (!int.TryParse(input, out parsed))
                        {
                            error.Text = "You must enter a 7 digit code!";
                            InputBar.Text = "";
                            StatusBar.Text += date + "- Incorrect 7 digit code!\r\n";
                            InfoBar.Text = "";
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        private void StatusButton(int[] database1)
        {
            int free = 0;
            int used = 0;
            int sold = 0;
            int empty = 0;
            try
            {
                for (int i = 0; i < database1.Length; i++)
                {
                    if (database1[i] == 0)
                    {
                        empty++;
                        continue;
                    }
                    if (database1[i] == 1)
                    {
                        used++;
                        continue;
                    }
                    if (database1[i] == 2)
                    {
                        sold++;
                        continue;
                    }
                    else
                    {
                        free++;
                    }
                }
                if (empty != 0)
                {
                    StatusBar.Text += date + "- Empty Tickets: " + empty.ToString() + "\r\n";
                }
                if (used != 0)
                {
                    StatusBar.Text += date + "- Used Tickets: " + used.ToString() + "\r\n";
                }
                if (sold != 0)
                {
                    StatusBar.Text += date + "- Sold Tickets: " + sold.ToString() + "\r\n";
                }
                if (free != 0)
                {
                    StatusBar.Text += date + "- Free Tickets: " + free.ToString() + "\r\n";
                }
                else
                {
                    StatusBar.Text += date + "- There is no tickets!\r\n";
                }
            }
            catch
            {
                StatusBar.Text += date + "- There is no tickets! generate numbers first!\r\n";
                error.Text = "There is no tickets!\r\n";
            }
        }
        private void SaveFiles(string[] database, int[] database1, string path)
        {
            try
            {
                error.Text = "";
                file1 = new string[database.Length];
                file2 = new string[database1.Length];
                for (int i = 0; i < database.Length; i++)
                {
                    file1[i] = database[i];
                    file2[i] = database1[i].ToString();
                }
                File.WriteAllLines(@path + "\\DataBase.txt", file1);
                File.WriteAllLines(@path + "\\DataBaseInt.txt", file2);
                StatusBar.Text += date + "- Files saved successfully.\r\n";
            }
            catch (Exception)
            {
                error.Text = "File saving error!";
            }
        }
        private string[] LoadFiles1(string path)
        {
            int counter = 1;
            try
            {
                string[] input = File.ReadAllLines(@path + "\\DataBase.txt");
                AllTickets.Text = "";
                foreach (var item in input)
                {
                    Thread.Sleep(1);
                    AllTickets.Text += counter + " - ";
                    AllTickets.Text += item + "\r\n";
                    counter++;
                }
                StatusBar.Text += date + "- Files loaded successfully.\r\n";
                return input;
            }
            catch (Exception)
            {
                error.Text = "Could not load tickets, the files are empty!";
                return null;
            }
        }
        private int[] LoadFiles2(string path)
        {
            try
            {
                string[] input = System.IO.File.ReadAllLines(@path + "\\DataBaseInt.txt");
                int[] input1 = new int[input.Length];
                for (int i = 0; i < input.Length; i++)
                {
                    input1[i] = int.Parse(input[i]);
                }
                return input1;
            }
            catch (Exception)
            {
                error.Text = "Could not load tickets, the files are empty!";
                return null;
            }
        }
        private void SearchByNumber(string[] database, string input)
        {
            bool found = false;
            int counter = 1;
            SearchBar.Text = "";
            if (int.TryParse(input, out int parsed))
            {
                foreach (var item in database)
                {
                    if (item == parsed.ToString())
                    {
                        error.Text = "";
                        InfoBar.Text = "I found the number! ";
                        StatusBar.Text += date + "- Ticket is exist in database: " + (counter) + " - " + parsed + "\r\n";
                        found = true;
                        break;
                    }
                    if (item == parsed.ToString() + " was Used")
                    {
                        InfoBar.Text = "I found a used number! ";
                        StatusBar.Text += date + "- The given number exist in database: Used - " + counter + " - " + parsed.ToString() + "\r\n";
                        found = true;
                        break;
                    }
                    if (item == parsed.ToString() + " was Sold")
                    {
                        InfoBar.Text = "I found a sold number! ";
                        StatusBar.Text += date + "- The given number exist in database: Sold - " + counter + " - " + parsed.ToString() + "\r\n";
                        found = true;
                        break;
                    }
                    found = false;
                    counter++;
                }
            }
            if (!int.TryParse(input, out parsed))
            {
                if (found == false)
                {
                    InfoBar.Text = "No matches! ";
                    error.Text = "This ticket was not found!";
                }
            }
            if (found == false)
            {
                InfoBar.Text = "No matches! ";
                error.Text = "This ticket was not found!";
            }
        }
        private void KeyDownSearchBar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Return))
            {
                switch (operation)
                {
                    case "Search Number":
                        input = SearchBar.Text;
                        SearchByNumber(database, input);
                        break;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now;
            fullDate = time.ToString();
            date = time.Hour.ToString() + ":" + time.Minute.ToString() + ":" + time.Second.ToString();
            string dateString = date;
            systemTime.Text = "Time: " + dateString;
            StatusBar.SelectionStart = StatusBar.Text.Length;
            StatusBar.ScrollToCaret();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var lines = StatusBar.Lines.Count();
            log = new string[lines];
            if (log != null && lines != 0)
            {
                try
                {
                    for (int i = 0; i < lines; i++)
                    {
                        log[i] = time.Month + "/" + time.Day + "/" + StatusBar.Lines[i];
                        if (i + 1 == lines)
                        {
                            log[i] = "";
                        }
                    }
                    File.WriteAllLines(@path + "\\Log.txt", log);
                }
                catch (Exception)
                {
                    error.Text = "Could not save Log.txt!";
                }
            }
        }
    }
}
