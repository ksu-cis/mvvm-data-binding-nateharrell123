﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CashRegister;

namespace MVVMDataBinding
{
    /// <summary>
    /// Interaction logic for CoinControl.xaml
    /// </summary>
    public partial class CoinControl : UserControl
    {
        // definition of the property that's going to be shared amongst all instances of CoinControl.
        public static readonly DependencyProperty DenominationProperty
            = DependencyProperty.Register(
                "Denomination", 
                typeof (Coins),
                typeof(CoinControl),
                new PropertyMetadata(Coins.Penny)
                );

        public Coins Denomination
        {
            get { return (Coins)GetValue(DenominationProperty); }
            set { SetValue(DenominationProperty, value); }
        }

        public static readonly DependencyProperty QuantityProperty =
            DependencyProperty.Register(
                "Quantity",
                typeof(int),
                typeof(CoinControl),
                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
                );

        public int Quantity
        {
            get { return (int)GetValue(QuantityProperty); }
            set => SetValue(QuantityProperty, value);
        }
        public CoinControl()
        {
            InitializeComponent();
        }
    }
}
