﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientWCF_Funcionario.ServiceReferenceFuncionario {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Funcionario", Namespace="http://schemas.datacontract.org/2004/07/WcfAtiv_I")]
    [System.SerializableAttribute()]
    public partial class Funcionario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataCadastroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double SalarioField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataCadastro {
            get {
                return this.DataCadastroField;
            }
            set {
                if ((this.DataCadastroField.Equals(value) != true)) {
                    this.DataCadastroField = value;
                    this.RaisePropertyChanged("DataCadastro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Salario {
            get {
                return this.SalarioField;
            }
            set {
                if ((this.SalarioField.Equals(value) != true)) {
                    this.SalarioField = value;
                    this.RaisePropertyChanged("Salario");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceFuncionario.IFuncionario")]
    public interface IFuncionario {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFuncionario/ListarFuncionario", ReplyAction="http://tempuri.org/IFuncionario/ListarFuncionarioResponse")]
        ClientWCF_Funcionario.ServiceReferenceFuncionario.Funcionario[] ListarFuncionario();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFuncionario/ListarFuncionario", ReplyAction="http://tempuri.org/IFuncionario/ListarFuncionarioResponse")]
        System.Threading.Tasks.Task<ClientWCF_Funcionario.ServiceReferenceFuncionario.Funcionario[]> ListarFuncionarioAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFuncionario/SelecioarFuncionario", ReplyAction="http://tempuri.org/IFuncionario/SelecioarFuncionarioResponse")]
        ClientWCF_Funcionario.ServiceReferenceFuncionario.Funcionario SelecioarFuncionario(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFuncionario/SelecioarFuncionario", ReplyAction="http://tempuri.org/IFuncionario/SelecioarFuncionarioResponse")]
        System.Threading.Tasks.Task<ClientWCF_Funcionario.ServiceReferenceFuncionario.Funcionario> SelecioarFuncionarioAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFuncionarioChannel : ClientWCF_Funcionario.ServiceReferenceFuncionario.IFuncionario, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FuncionarioClient : System.ServiceModel.ClientBase<ClientWCF_Funcionario.ServiceReferenceFuncionario.IFuncionario>, ClientWCF_Funcionario.ServiceReferenceFuncionario.IFuncionario {
        
        public FuncionarioClient() {
        }
        
        public FuncionarioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FuncionarioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FuncionarioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FuncionarioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClientWCF_Funcionario.ServiceReferenceFuncionario.Funcionario[] ListarFuncionario() {
            return base.Channel.ListarFuncionario();
        }
        
        public System.Threading.Tasks.Task<ClientWCF_Funcionario.ServiceReferenceFuncionario.Funcionario[]> ListarFuncionarioAsync() {
            return base.Channel.ListarFuncionarioAsync();
        }
        
        public ClientWCF_Funcionario.ServiceReferenceFuncionario.Funcionario SelecioarFuncionario(int id) {
            return base.Channel.SelecioarFuncionario(id);
        }
        
        public System.Threading.Tasks.Task<ClientWCF_Funcionario.ServiceReferenceFuncionario.Funcionario> SelecioarFuncionarioAsync(int id) {
            return base.Channel.SelecioarFuncionarioAsync(id);
        }
    }
}
