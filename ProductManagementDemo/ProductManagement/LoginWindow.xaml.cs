﻿using BusinessObjects;
using ProductManagement;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProductManagement
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly IAccountService iAccountService;
        public LoginWindow()
        {
            InitializeComponent();
            iAccountService = new AccountService();
        }

        //private void btnLogin_Click(object sender, RoutedEventArgs e)
        //{
        //    AccountMember account = iAccountService.GetAccountById(txtUser.Text);

        //    if (account != null && account.MemberPassword.Equals(txtPass.Password) && account.MemberRole == 1)
        //    {
        //        this.Hide();
        //        MainWindow mainWindow = new MainWindow();
        //        mainWindow.Show();
        //    }else
        //        MessageBox.Show("you are not  permission");


        //}
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AccountMember account = iAccountService.GetAccountById(txtUser.Text);

                if (account != null && account.MemberPassword.Equals(txtPass.Password) && account.MemberRole == 1)
                {
                    this.Hide();
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                }
                else
                {
                    MessageBox.Show("You are not permission");
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("You are not permission");

                // Log the exception details for debugging purposes
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}