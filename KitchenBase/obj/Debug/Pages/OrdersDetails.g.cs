﻿#pragma checksum "..\..\..\Pages\OrdersDetails.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "810F3326EFA9DF9D575578F8BD42297D1758BC0851BDC3351113ACC30BD38E28"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using KitchenBase.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace KitchenBase.Pages {
    
    
    /// <summary>
    /// OrdersDetails
    /// </summary>
    public partial class OrdersDetails : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Pages\OrdersDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblAuthorization;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Pages\OrdersDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblOrderNumber;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\OrdersDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbOrderNumber;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\OrdersDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblOrderTime;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\OrdersDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbOrderTime;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Pages\OrdersDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblNumberTable;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\OrdersDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNumberTable;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Pages\OrdersDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgOrderDetails;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/KitchenBase;component/pages/ordersdetails.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\OrdersDetails.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\Pages\OrdersDetails.xaml"
            ((KitchenBase.Pages.OrdersDetails)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\Pages\OrdersDetails.xaml"
            ((KitchenBase.Pages.OrdersDetails)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblAuthorization = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblOrderNumber = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.tbOrderNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.lblOrderTime = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.tbOrderTime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.lblNumberTable = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.tbNumberTable = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.dgOrderDetails = ((System.Windows.Controls.DataGrid)(target));
            
            #line 48 "..\..\..\Pages\OrdersDetails.xaml"
            this.dgOrderDetails.AutoGeneratingColumn += new System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>(this.DgTypeProduct_AutoGeneratingColumn);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

