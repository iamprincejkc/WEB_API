using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FetchData
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetViewTestData();
        }

        public async void GetViewTestData()
        {
            try
            {
                HttpClient webClient = new HttpClient();
                webClient.BaseAddress = new Uri("https://api.apify.com/");
                //HttpResponseMessage response = await webClient.GetAsync("v2/datasets/sFSef5gfYg3soj8mb/items?format=json&clean=1");
                HttpResponseMessage response = await webClient.GetAsync("v2/key-value-stores/lFItbkoNDXKeSWBBA/records/LATEST?disableRedirect=true");
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var testdata = JsonConvert.DeserializeObject<TestClass>(jsonString);
                    ObservableCollection<TestClass> test = new ObservableCollection<TestClass>();

                    TestClass a = new TestClass()
                    {
                        infected = testdata.infected,
                        tested = testdata.tested,
                        recovered = testdata.recovered,
                        deceased = testdata.deceased,
                        activeCases = testdata.activeCases,
                        unique = testdata.unique,
                        country = testdata.country
                    };
                    test.Add(a);
                    listtestview.ItemsSource = test;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}   
