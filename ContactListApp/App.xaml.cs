﻿using ContactListApp.Views;
namespace ContactListApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
    }
}