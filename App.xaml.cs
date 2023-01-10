using NOTE_ID.API;
using NOTE_ID.Data_Acces_Layer;
using NOTE_ID.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace NOTE_ID
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static List<Book> books=new List<Book>();
        public static List<QuickNote> quickNotes = new List<QuickNote>();
        public static List<ReadingList> readingLists = new List<ReadingList>();
        public static List<Model.SignUp> signUp = new List<Model.SignUp>();
        public static List<ToDoList> toDoList = new List<ToDoList>();

        public static NoteIdJSON JsonClient = new NoteIdJSON();

        public App()
        {
            toDoList.Add(new ToDoList());
            books = JsonClient.LoadList<Book>("Book.json");
            
            quickNotes = JsonClient.LoadList<QuickNote>("QuickNote.json");
            //quickNotes.Add(new QuickNote(null, null));
            readingLists = JsonClient.LoadList<ReadingList>("ReadingList.json");
            signUp = JsonClient.LoadList<Model.SignUp>("SignUp.json");
            toDoList = JsonClient.LoadList<ToDoList>("ToDoList.json");
        }
        public void SaveJson()
        {
            JsonClient.SaveList(books, "Book.json");
            JsonClient.SaveList(quickNotes, "QuickNote.json");
            JsonClient.SaveList(readingLists, "ReadingList.json");
            JsonClient.SaveList(signUp, "SignUp.json");
            JsonClient.SaveList(toDoList, "ToDoList.json");
        }

 
        ~App()
        {
            
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            SaveJson();
        }
    }
}
