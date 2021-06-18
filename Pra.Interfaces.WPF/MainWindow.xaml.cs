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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Pra.Interfaces.CORE.Interfaces;
using Pra.Interfaces.CORE.Classes;

namespace Pra.Interfaces.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Television tvLivingRoom;
        Radio radioKitchen;
        SmartLamp lampHallway;

        public List<ElectricalAppliance> electricalAppliance { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tvLivingRoom = new Television("leefkamer");
            radioKitchen = new Radio("keuken");
            lampHallway = new SmartLamp("gang");
            electricalAppliance = new List<ElectricalAppliance>
            {
                tvLivingRoom,
                radioKitchen,
                lampHallway
            };
        }

        private void BtnTVLivingRoomPower_Click(object sender, RoutedEventArgs e)
        {
            if (tvLivingRoom.IsOn)
            {
                lblTVLivingRoom.Content = tvLivingRoom.PowerOff();
                lblTVLivingRoom.Background = Brushes.Red;
            }
            else
            {
                lblTVLivingRoom.Content = tvLivingRoom.PowerOn();
                lblTVLivingRoom.Background = Brushes.LightGreen;
            }
        }

        private void BtnSmartLampHallwayPower_Click(object sender, RoutedEventArgs e)
        {
            if (lampHallway.IsOn)
            {
                lblSmartLampHallway.Content = lampHallway.PowerOff();
                lblSmartLampHallway.Background = Brushes.Red;
            }
            else
            {
                lblSmartLampHallway.Content = lampHallway.PowerOn();
                lblSmartLampHallway.Background = Brushes.LightGreen;
            }
        }

        private void BtnRadioKitchenPower_Click(object sender, RoutedEventArgs e)
        {
            if (radioKitchen.IsOn)
            {
                lblRadioKitchen.Content = radioKitchen.PowerOff();
                lblRadioKitchen.Background = Brushes.Red;
            }
            else
            {
                lblRadioKitchen.Content = radioKitchen.PowerOn();
                lblRadioKitchen.Background = Brushes.LightGreen;
            }
        }

        private void BtnTVLivingRoomVolumeDown_Click(object sender, RoutedEventArgs e)
        {
            if (tvLivingRoom.IsOn)
            {
            tvLivingRoom.VolumeDown();
            lblTVLivingRoomVolume.Content = tvLivingRoom.CurrentVolume;
            }
        }

        private void BtnTVLivingRoomVolumeUp_Click(object sender, RoutedEventArgs e)
        {
            if (tvLivingRoom.IsOn)
            {
                tvLivingRoom.VolumeUp();
                lblTVLivingRoomVolume.Content = tvLivingRoom.CurrentVolume;
            }
        }

        private void BtnRadioKitchenVolumeDown_Click(object sender, RoutedEventArgs e)
        {
            if (radioKitchen.IsOn)
            {
                radioKitchen.VolumeDown();
                lblRadioKitchenVolume.Content = radioKitchen.CurrentVolume;
            }
        }

        private void BtnRadioKitchenVolumeUp_Click(object sender, RoutedEventArgs e)
        {
            if (radioKitchen.IsOn)
            {
                radioKitchen.VolumeUp();
                lblRadioKitchenVolume.Content = radioKitchen.CurrentVolume;
            }
        }

        private void BtnCheckConnections_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnStartAll_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnStopAll_Click(object sender, RoutedEventArgs e)
        {

        }
        private void BtnAllVolumeUpn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAllVolumeDown_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCheckInterfaceImplementation_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
