using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;

namespace test2
{
    public partial class Window1 : AppKit.NSWindow
    {
        #region Constructors

        // Called when created from unmanaged code
        public Window1(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public Window1(NSCoder coder) : base(coder)
        {
            Initialize();
        }

        // Shared initialization code
        void Initialize()
        {
        }

        #endregion
    }
}
