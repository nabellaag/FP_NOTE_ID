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

        public static List<Book> books;
        public static List<QuickNote> quickNotes = new List<QuickNote>();
        public static List<ReadingList> readingLists = new List<ReadingList>();
        public static List<Model.SignUp> signUp = new List<Model.SignUp>();
        public static List<ToDoList> toDoLists = new List<ToDoList>();

        public static NoteIdJSON JsonClient = new NoteIdJSON();
        public App()
        {
            //books.Add(new Book());
            //quickNotes.Add(new QuickNote());
            //readingLists.Add(new ReadingList());
            //signUp.Add(new SignUp());
            //toDoLists.Add(new ToDoList());


            books = JsonClient.LoadList<Book>("Book.json");
            //quickNotes = JsonClient.LoadList<QuickNote>("Book.json");
            //readingLists = JsonClient.LoadList<ReadingList>("LoadList.json");
=======        
        public static NoteIdJSON JsonClient = new();
        public App()
        {

            //signUp = JsonClient.LoadList<Model.SignUp>("SignUp.json");
        }

        

        ~App()
        {
         
        }
    }
}
