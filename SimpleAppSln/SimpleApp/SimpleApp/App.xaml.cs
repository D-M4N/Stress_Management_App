﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using SQLitePCL;
using System.IO;
using SimpleApp.Registration;

namespace SimpleApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            
        }

        static AppDataBase database;
        public static AppDataBase Database
        {
            get
            {
                if (database == null)
                {
                    database = new AppDataBase(
                      Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TShirtDatabaseSQLite.db3"));
                }
                return database;
            }
        }
        public int ResumeAtPersonName { get; set; }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
