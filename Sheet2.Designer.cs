﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 414
namespace StockAnalyzerWB {
    
    
    /// 
    [Microsoft.VisualStudio.Tools.Applications.Runtime.StartupObjectAttribute(2)]
    [global::System.Security.Permissions.PermissionSetAttribute(global::System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    public sealed partial class Sheet2 : Microsoft.Office.Tools.Excel.WorksheetBase {
        
        internal Microsoft.Office.Tools.Excel.NamedRange Sheet2_Ask;
        
        internal Microsoft.Office.Tools.Excel.NamedRange Sheet2_Bid;
        
        internal Microsoft.Office.Tools.Excel.NamedRange Sheet2_Break_Even;
        
        internal Microsoft.Office.Tools.Excel.NamedRange Sheet2_Last;
        
        internal Microsoft.Office.Tools.Excel.NamedRange Sheet2_LastPrice;
        
        internal Microsoft.Office.Tools.Excel.NamedRange Sheet2_Open_Interest;
        
        internal Microsoft.Office.Tools.Excel.NamedRange Sheet2_Price;
        
        internal Microsoft.Office.Tools.Excel.NamedRange Sheet2_Strike_Price;
        
        internal Microsoft.Office.Tools.Excel.NamedRange Sheet2_Symbol;
        
        internal Microsoft.Office.Tools.Excel.NamedRange Sheet2_Vol;
        
        internal Microsoft.Office.Tools.Excel.NamedRange Sheet2_xAsk;
        
        internal Microsoft.Office.Tools.Excel.NamedRange Sheet2_xBid;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        private global::System.Object missing = global::System.Type.Missing;
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Sheet2(global::Microsoft.Office.Tools.Excel.Factory factory, global::System.IServiceProvider serviceProvider) : 
                base(factory, serviceProvider, "Sheet2", "Sheet2") {
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void Initialize() {
            base.Initialize();
            Globals.Sheet2 = this;
            global::System.Windows.Forms.Application.EnableVisualStyles();
            this.InitializeCachedData();
            this.InitializeControls();
            this.InitializeComponents();
            this.InitializeData();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void FinishInitialization() {
            this.InternalStartup();
            this.OnStartup();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void InitializeDataBindings() {
            this.BeginInitialization();
            this.BindToData();
            this.EndInitialization();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeCachedData() {
            if ((this.DataHost == null)) {
                return;
            }
            if (this.DataHost.IsCacheInitialized) {
                this.DataHost.FillCachedData(this);
            }
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeData() {
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void BindToData() {
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private void StartCaching(string MemberName) {
            this.DataHost.StartCaching(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private void StopCaching(string MemberName) {
            this.DataHost.StopCaching(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private bool IsCached(string MemberName) {
            return this.DataHost.IsCached(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void BeginInitialization() {
            this.BeginInit();
            this.Sheet2_Ask.BeginInit();
            this.Sheet2_Bid.BeginInit();
            this.Sheet2_Break_Even.BeginInit();
            this.Sheet2_Last.BeginInit();
            this.Sheet2_LastPrice.BeginInit();
            this.Sheet2_Open_Interest.BeginInit();
            this.Sheet2_Price.BeginInit();
            this.Sheet2_Strike_Price.BeginInit();
            this.Sheet2_Symbol.BeginInit();
            this.Sheet2_Vol.BeginInit();
            this.Sheet2_xAsk.BeginInit();
            this.Sheet2_xBid.BeginInit();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void EndInitialization() {
            this.Sheet2_xBid.EndInit();
            this.Sheet2_xAsk.EndInit();
            this.Sheet2_Vol.EndInit();
            this.Sheet2_Symbol.EndInit();
            this.Sheet2_Strike_Price.EndInit();
            this.Sheet2_Price.EndInit();
            this.Sheet2_Open_Interest.EndInit();
            this.Sheet2_LastPrice.EndInit();
            this.Sheet2_Last.EndInit();
            this.Sheet2_Break_Even.EndInit();
            this.Sheet2_Bid.EndInit();
            this.Sheet2_Ask.EndInit();
            this.EndInit();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeControls() {
            this.Sheet2_Ask = Globals.Factory.CreateNamedRange(null, null, "Sheet2!Ask", "Sheet2_Ask", this);
            this.Sheet2_Bid = Globals.Factory.CreateNamedRange(null, null, "Sheet2!Bid", "Sheet2_Bid", this);
            this.Sheet2_Break_Even = Globals.Factory.CreateNamedRange(null, null, "Sheet2!Break_Even", "Sheet2_Break_Even", this);
            this.Sheet2_Last = Globals.Factory.CreateNamedRange(null, null, "Sheet2!Last", "Sheet2_Last", this);
            this.Sheet2_LastPrice = Globals.Factory.CreateNamedRange(null, null, "Sheet2!LastPrice", "Sheet2_LastPrice", this);
            this.Sheet2_Open_Interest = Globals.Factory.CreateNamedRange(null, null, "Sheet2!Open_Interest", "Sheet2_Open_Interest", this);
            this.Sheet2_Price = Globals.Factory.CreateNamedRange(null, null, "Sheet2!Price", "Sheet2_Price", this);
            this.Sheet2_Strike_Price = Globals.Factory.CreateNamedRange(null, null, "Sheet2!Strike_Price", "Sheet2_Strike_Price", this);
            this.Sheet2_Symbol = Globals.Factory.CreateNamedRange(null, null, "Sheet2!Symbol", "Sheet2_Symbol", this);
            this.Sheet2_Vol = Globals.Factory.CreateNamedRange(null, null, "Sheet2!Vol", "Sheet2_Vol", this);
            this.Sheet2_xAsk = Globals.Factory.CreateNamedRange(null, null, "Sheet2!xAsk", "Sheet2_xAsk", this);
            this.Sheet2_xBid = Globals.Factory.CreateNamedRange(null, null, "Sheet2!xBid", "Sheet2_xBid", this);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeComponents() {
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private bool NeedsFill(string MemberName) {
            return this.DataHost.NeedsFill(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void OnShutdown() {
            this.Sheet2_xBid.Dispose();
            this.Sheet2_xAsk.Dispose();
            this.Sheet2_Vol.Dispose();
            this.Sheet2_Symbol.Dispose();
            this.Sheet2_Strike_Price.Dispose();
            this.Sheet2_Price.Dispose();
            this.Sheet2_Open_Interest.Dispose();
            this.Sheet2_LastPrice.Dispose();
            this.Sheet2_Last.Dispose();
            this.Sheet2_Break_Even.Dispose();
            this.Sheet2_Bid.Dispose();
            this.Sheet2_Ask.Dispose();
            base.OnShutdown();
        }
    }
    
    internal sealed partial class Globals {
        
        private static Sheet2 _Sheet2;
        
        internal static Sheet2 Sheet2 {
            get {
                return _Sheet2;
            }
            set {
                if ((_Sheet2 == null)) {
                    _Sheet2 = value;
                }
                else {
                    throw new System.NotSupportedException();
                }
            }
        }
    }
}
