using System;
using System.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using FontAwesome.Sharp;

namespace compta
{
    /// <summary>
    /// Senior Level Icon Manager - FontAwesome Edition
    /// Centralizes icon management using FontAwesome.Sharp (Vector Icons).
    /// </summary>
    public static class IconManager
    {
        // Default colors for FontAwesome icons
        private static Color DefaultIconColor = Color.FromArgb(70, 70, 70); // Modern Gray

        /// <summary>
        /// Sets a FontAwesome icon to a DevExpress SimpleButton.
        /// </summary>
        public static void SetIcon(SimpleButton btn, IconChar icon, int size = 24)
        {
            if (btn == null) return;
            // Trying the specific overload structure observed in build errors
            btn.ImageOptions.Image = icon.ToBitmap(DefaultIconColor, size);
        }

        /// <summary>
        /// Sets a FontAwesome icon to a DevExpress BarItem (Ribbon/Menu items).
        /// </summary>
        public static void SetIcon(BarItem item, IconChar icon, bool large = false)
        {
            if (item == null) return;
            int size = large ? 32 : 16;
            Bitmap bmp = icon.ToBitmap(DefaultIconColor, size);
            item.ImageOptions.Image = bmp;
            if (large)
            {
            item.ImageOptions.LargeImage = bmp;
            }
        }

        /// <summary>
        /// Semantic Icon mapping using FontAwesome.Sharp IconChars.
        /// </summary>
        public static class Icons
        {
            public static IconChar Save = IconChar.Save;
            public static IconChar SaveAll = IconChar.FileInvoice;
            public static IconChar Open = IconChar.FolderOpen;
            public static IconChar Close = IconChar.TimesCircle;
            public static IconChar Delete = IconChar.Trash;
            public static IconChar Edit = IconChar.FileEdit;
            public static IconChar Add = IconChar.Plus;
            public static IconChar Print = IconChar.Print;
            public static IconChar Preview = IconChar.SearchPlus;
            public static IconChar ExportXlsx = IconChar.FileExcel;
            public static IconChar Refresh = IconChar.Sync;
            public static IconChar Database = IconChar.Database;
            public static IconChar Report = IconChar.ChartBar;
            public static IconChar Users = IconChar.Users;
            public static IconChar Calculator = IconChar.Calculator;
            public static IconChar Business = IconChar.Briefcase;
            public static IconChar Journals = IconChar.Book;
            public static IconChar Centralisation = IconChar.AlignCenter;
            public static IconChar Accounts = IconChar.Tasks;
            public static IconChar Pieces = IconChar.FileAlt;
            public static IconChar Map = IconChar.MapMarkerAlt;
            public static IconChar Today = IconChar.CalendarDay;
            public static IconChar Team = IconChar.UserFriends;
            public static IconChar Reading = IconChar.BookOpen;
            public static IconChar Accounting = IconChar.FileInvoiceDollar;
            public static IconChar WorkWeek = IconChar.CalendarAlt;
            public static IconChar ShowAll = IconChar.Landmark;
            public static IconChar Table = IconChar.Table;
            public static IconChar Pies = IconChar.ChartPie;
            
            // New Icons for remaining menu items
            public static IconChar Files = IconChar.File;
            public static IconChar Tools = IconChar.Tools;
            public static IconChar Investments = IconChar.ChartLine;
            public static IconChar Board = IconChar.ClipboardList;
            public static IconChar Import = IconChar.FileImport;
            public static IconChar Exchange = IconChar.ExchangeAlt;
            public static IconChar Percentage = IconChar.Percentage;
            public static IconChar Check = IconChar.CheckDouble;
            public static IconChar Balance = IconChar.BalanceScale;
            public static IconChar DoorOpen = IconChar.DoorOpen;
            public static IconChar History = IconChar.History;
            public static IconChar Shopping = IconChar.ShoppingCart;
            public static IconChar UserTag = IconChar.UserTag;
            public static IconChar Contract = IconChar.FileContract;
            public static IconChar Others = IconChar.EllipsisH;
            public static IconChar Palette = IconChar.Palette;
        }
    }
}
