﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationFuncionario.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Funcionario", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Funcionario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        private double SalarioField;
        
        private System.DateTime DataCadastroField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ServicoFuncionarioSoap")]
    public interface ServicoFuncionarioSoap {
        
        // CODEGEN: Generating message contract since element name CarregaFuncionarioResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CarregaFuncionario", ReplyAction="*")]
        WebApplicationFuncionario.ServiceReference1.CarregaFuncionarioResponse CarregaFuncionario(WebApplicationFuncionario.ServiceReference1.CarregaFuncionarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CarregaFuncionario", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplicationFuncionario.ServiceReference1.CarregaFuncionarioResponse> CarregaFuncionarioAsync(WebApplicationFuncionario.ServiceReference1.CarregaFuncionarioRequest request);
        
        // CODEGEN: Generating message contract since element name SelecionarFuncionarioResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelecionarFuncionario", ReplyAction="*")]
        WebApplicationFuncionario.ServiceReference1.SelecionarFuncionarioResponse SelecionarFuncionario(WebApplicationFuncionario.ServiceReference1.SelecionarFuncionarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelecionarFuncionario", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplicationFuncionario.ServiceReference1.SelecionarFuncionarioResponse> SelecionarFuncionarioAsync(WebApplicationFuncionario.ServiceReference1.SelecionarFuncionarioRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CarregaFuncionarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CarregaFuncionario", Namespace="http://tempuri.org/", Order=0)]
        public WebApplicationFuncionario.ServiceReference1.CarregaFuncionarioRequestBody Body;
        
        public CarregaFuncionarioRequest() {
        }
        
        public CarregaFuncionarioRequest(WebApplicationFuncionario.ServiceReference1.CarregaFuncionarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class CarregaFuncionarioRequestBody {
        
        public CarregaFuncionarioRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CarregaFuncionarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CarregaFuncionarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplicationFuncionario.ServiceReference1.CarregaFuncionarioResponseBody Body;
        
        public CarregaFuncionarioResponse() {
        }
        
        public CarregaFuncionarioResponse(WebApplicationFuncionario.ServiceReference1.CarregaFuncionarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CarregaFuncionarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebApplicationFuncionario.ServiceReference1.Funcionario[] CarregaFuncionarioResult;
        
        public CarregaFuncionarioResponseBody() {
        }
        
        public CarregaFuncionarioResponseBody(WebApplicationFuncionario.ServiceReference1.Funcionario[] CarregaFuncionarioResult) {
            this.CarregaFuncionarioResult = CarregaFuncionarioResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SelecionarFuncionarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SelecionarFuncionario", Namespace="http://tempuri.org/", Order=0)]
        public WebApplicationFuncionario.ServiceReference1.SelecionarFuncionarioRequestBody Body;
        
        public SelecionarFuncionarioRequest() {
        }
        
        public SelecionarFuncionarioRequest(WebApplicationFuncionario.ServiceReference1.SelecionarFuncionarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SelecionarFuncionarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public SelecionarFuncionarioRequestBody() {
        }
        
        public SelecionarFuncionarioRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SelecionarFuncionarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SelecionarFuncionarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplicationFuncionario.ServiceReference1.SelecionarFuncionarioResponseBody Body;
        
        public SelecionarFuncionarioResponse() {
        }
        
        public SelecionarFuncionarioResponse(WebApplicationFuncionario.ServiceReference1.SelecionarFuncionarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SelecionarFuncionarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebApplicationFuncionario.ServiceReference1.Funcionario SelecionarFuncionarioResult;
        
        public SelecionarFuncionarioResponseBody() {
        }
        
        public SelecionarFuncionarioResponseBody(WebApplicationFuncionario.ServiceReference1.Funcionario SelecionarFuncionarioResult) {
            this.SelecionarFuncionarioResult = SelecionarFuncionarioResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicoFuncionarioSoapChannel : WebApplicationFuncionario.ServiceReference1.ServicoFuncionarioSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicoFuncionarioSoapClient : System.ServiceModel.ClientBase<WebApplicationFuncionario.ServiceReference1.ServicoFuncionarioSoap>, WebApplicationFuncionario.ServiceReference1.ServicoFuncionarioSoap {
        
        public ServicoFuncionarioSoapClient() {
        }
        
        public ServicoFuncionarioSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicoFuncionarioSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoFuncionarioSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoFuncionarioSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplicationFuncionario.ServiceReference1.CarregaFuncionarioResponse WebApplicationFuncionario.ServiceReference1.ServicoFuncionarioSoap.CarregaFuncionario(WebApplicationFuncionario.ServiceReference1.CarregaFuncionarioRequest request) {
            return base.Channel.CarregaFuncionario(request);
        }
        
        public WebApplicationFuncionario.ServiceReference1.Funcionario[] CarregaFuncionario() {
            WebApplicationFuncionario.ServiceReference1.CarregaFuncionarioRequest inValue = new WebApplicationFuncionario.ServiceReference1.CarregaFuncionarioRequest();
            inValue.Body = new WebApplicationFuncionario.ServiceReference1.CarregaFuncionarioRequestBody();
            WebApplicationFuncionario.ServiceReference1.CarregaFuncionarioResponse retVal = ((WebApplicationFuncionario.ServiceReference1.ServicoFuncionarioSoap)(this)).CarregaFuncionario(inValue);
            return retVal.Body.CarregaFuncionarioResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplicationFuncionario.ServiceReference1.CarregaFuncionarioResponse> WebApplicationFuncionario.ServiceReference1.ServicoFuncionarioSoap.CarregaFuncionarioAsync(WebApplicationFuncionario.ServiceReference1.CarregaFuncionarioRequest request) {
            return base.Channel.CarregaFuncionarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplicationFuncionario.ServiceReference1.CarregaFuncionarioResponse> CarregaFuncionarioAsync() {
            WebApplicationFuncionario.ServiceReference1.CarregaFuncionarioRequest inValue = new WebApplicationFuncionario.ServiceReference1.CarregaFuncionarioRequest();
            inValue.Body = new WebApplicationFuncionario.ServiceReference1.CarregaFuncionarioRequestBody();
            return ((WebApplicationFuncionario.ServiceReference1.ServicoFuncionarioSoap)(this)).CarregaFuncionarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplicationFuncionario.ServiceReference1.SelecionarFuncionarioResponse WebApplicationFuncionario.ServiceReference1.ServicoFuncionarioSoap.SelecionarFuncionario(WebApplicationFuncionario.ServiceReference1.SelecionarFuncionarioRequest request) {
            return base.Channel.SelecionarFuncionario(request);
        }
        
        public WebApplicationFuncionario.ServiceReference1.Funcionario SelecionarFuncionario(int id) {
            WebApplicationFuncionario.ServiceReference1.SelecionarFuncionarioRequest inValue = new WebApplicationFuncionario.ServiceReference1.SelecionarFuncionarioRequest();
            inValue.Body = new WebApplicationFuncionario.ServiceReference1.SelecionarFuncionarioRequestBody();
            inValue.Body.id = id;
            WebApplicationFuncionario.ServiceReference1.SelecionarFuncionarioResponse retVal = ((WebApplicationFuncionario.ServiceReference1.ServicoFuncionarioSoap)(this)).SelecionarFuncionario(inValue);
            return retVal.Body.SelecionarFuncionarioResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplicationFuncionario.ServiceReference1.SelecionarFuncionarioResponse> WebApplicationFuncionario.ServiceReference1.ServicoFuncionarioSoap.SelecionarFuncionarioAsync(WebApplicationFuncionario.ServiceReference1.SelecionarFuncionarioRequest request) {
            return base.Channel.SelecionarFuncionarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplicationFuncionario.ServiceReference1.SelecionarFuncionarioResponse> SelecionarFuncionarioAsync(int id) {
            WebApplicationFuncionario.ServiceReference1.SelecionarFuncionarioRequest inValue = new WebApplicationFuncionario.ServiceReference1.SelecionarFuncionarioRequest();
            inValue.Body = new WebApplicationFuncionario.ServiceReference1.SelecionarFuncionarioRequestBody();
            inValue.Body.id = id;
            return ((WebApplicationFuncionario.ServiceReference1.ServicoFuncionarioSoap)(this)).SelecionarFuncionarioAsync(inValue);
        }
    }
}
