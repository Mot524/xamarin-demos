#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBrowser.SfPdfViewer
{
    public interface ISave
    {
        string Save(MemoryStream fileStream);
    }
    public interface IDeviceInfo
    {
        ScreenSize GetScreenSize();
    }

    public enum ScreenSize
    {
        Small = 0,
        Normal = 1,
        Large = 2,
        XLarge = 3
    }
}
