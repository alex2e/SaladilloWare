using SaladilloWare.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SaladilloWare
{
    public partial class App : Application
    {
        public static OrderRepository orderRepository;
        public static ProductRepository productRespository;
        public static UserRepository userRepository;

        public App(String dbPatch)
        {
            InitializeComponent();
            orderRepository = new OrderRepository(dbPatch);
            productRespository = new ProductRepository(dbPatch);
            userRepository = new UserRepository(dbPatch);

            MainPage = new SaladilloWare.Login();
        }

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
