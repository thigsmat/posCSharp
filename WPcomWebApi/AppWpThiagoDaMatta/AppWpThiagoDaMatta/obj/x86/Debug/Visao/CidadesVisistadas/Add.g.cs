﻿#pragma checksum "D:\POS_APLICATIVOS_Csharp\WPhone\TrabalhoWP\AppWpThiagoDaMatta\AppWpThiagoDaMatta\Visao\CidadesVisistadas\Add.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BE232D96EC4FBCAC7FD2CEA17C85F5ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppWpThiagoDaMatta.Visao.CidadesVisistadas
{
    partial class Add : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.LayoutRoot = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.ContentPanel = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.NomeTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4:
                {
                    this.AdicionarButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 24 "..\..\..\..\Visao\CidadesVisistadas\Add.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.AdicionarButton).Click += this.AdicionarButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.CancelarButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 27 "..\..\..\..\Visao\CidadesVisistadas\Add.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.CancelarButton).Click += this.CancelarButton_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
