#region Copyright Syncfusion Inc. 2001-2017.
// ------------------------------------------------------------------------------------
// <copyright file = "PullToRefresh.xaml.cs" company="Syncfusion.com">
// Copyright Syncfusion Inc. 2001 - 2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws.
// </copyright>
// ------------------------------------------------------------------------------------
#endregion
namespace SampleBrowser.SfDataGrid
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using SampleBrowser.Core;
    using Syncfusion.SfDataGrid.XForms;
    using Xamarin.Forms;
 
    [Xamarin.Forms.Internals.Preserve(AllMembers = true)]

    /// <summary>
    /// A sampleView that contains the PullToRefresh sample.
    /// </summary>
    public partial class PullToRefresh : SampleView
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the PullToRefresh class.
        /// </summary>
        public PullToRefresh()
        {
            this.InitializeComponent();
        }
        #endregion
    }
}
