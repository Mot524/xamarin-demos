#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using SampleBrowser.Core;
using Syncfusion.XForms.Buttons;
using Xamarin.Forms;

namespace SampleBrowser.Chips
{
   
    /// <summary>
    /// Demonstrates the basic UI customization of SfChip control.
    /// </summary>
    public partial class GettingStarted : SampleView
    {
        #region GettingStarted constructor

        ChipViewModel viewModel;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SampleBrowser.Chips.GettingStarted"/> class.
        /// </summary>
        public GettingStarted()
        {
            InitializeComponent();

            viewModel = new ChipViewModel();
            this.BindingContext = viewModel;
        }

        /// <summary>
        /// Tabs the view selection changed.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        void TabViewSelectionChanged(object sender, Syncfusion.XForms.TabView.SelectionChangedEventArgs e)
        {
            var tabView = (sender as Syncfusion.XForms.TabView.SfTabView);
            for (int i = 0; i < tabView.Items.Count;i++)
            {
                var tabItem = (sender as Syncfusion.XForms.TabView.SfTabView).Items[i];
                StackLayout headerLabel = (tabItem.HeaderContent as StackLayout);
                Label label = (headerLabel.Children[0] as Label);
                if(i==e.Index)
                {
                    label.TextColor = Color.FromHex("#4285F4");
                }
                else
                {
                    label.TextColor = Color.Black;
                }
            }
        }

        /// <summary>
        /// Handles the selection changed.
        /// </summary>
        /// <param name="sender">Sender as TabView.</param>
        /// <param name="e">E as SelectionChangedEventArgs.</param>

        void Handle_SelectionChanged(object sender, Syncfusion.XForms.Buttons.SelectionChangedEventArgs e)
        {
            if ((sender as SfSegmentedControl) == TextColorSegment)
            {
                viewModel.TextColor = viewModel.PrimaryTextColors[e.Index].FontIconFontColor;
                this.TextColorSegment.SelectionTextColor = viewModel.PrimaryTextColors[e.Index].FontIconFontColor;
            }
            else if ((sender as SfSegmentedControl) == BackgroundColorSegment)
            {
                viewModel.BackgroundColor = viewModel.PrimaryColors[e.Index].FontIconFontColor;
                this.BackgroundColorSegment.SelectionTextColor = viewModel.PrimaryColors[e.Index].FontIconFontColor;
            }
            else if ((sender as SfSegmentedControl) == BorderColorSegment)
            {
                viewModel.BorderColorProperty = viewModel.PrimaryColors[e.Index].FontIconFontColor;
                this.BorderColorSegment.SelectionTextColor = viewModel.PrimaryColors[e.Index].FontIconFontColor;
            }
        }

        #endregion
    }
}