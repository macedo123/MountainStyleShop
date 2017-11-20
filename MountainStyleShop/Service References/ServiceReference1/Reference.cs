﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MountainStyleShop.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:Card", ConfigurationName="ServiceReference1.CardPortType")]
    public interface CardPortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:Card#ValidarCartao", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="msg")]
        string ValidarCartao(MountainStyleShop.ServiceReference1.tDadosCartao dadosCartao);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:Card#ValidarCartao", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="msg")]
        System.Threading.Tasks.Task<string> ValidarCartaoAsync(MountainStyleShop.ServiceReference1.tDadosCartao dadosCartao);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn:Card")]
    public partial class tDadosCartao : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string numeroCartaoField;
        
        private int codigoField;
        
        private string nomeClienteField;
        
        private string validadeField;
        
        private double valorField;
        
        private int parcelasField;
        
        private string nomeEmpresaField;
        
        private int cNPJEmpresaField;
        
        /// <remarks/>
        public string NumeroCartao {
            get {
                return this.numeroCartaoField;
            }
            set {
                this.numeroCartaoField = value;
                this.RaisePropertyChanged("NumeroCartao");
            }
        }
        
        /// <remarks/>
        public int Codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
                this.RaisePropertyChanged("Codigo");
            }
        }
        
        /// <remarks/>
        public string NomeCliente {
            get {
                return this.nomeClienteField;
            }
            set {
                this.nomeClienteField = value;
                this.RaisePropertyChanged("NomeCliente");
            }
        }
        
        /// <remarks/>
        public string Validade {
            get {
                return this.validadeField;
            }
            set {
                this.validadeField = value;
                this.RaisePropertyChanged("Validade");
            }
        }
        
        /// <remarks/>
        public double Valor {
            get {
                return this.valorField;
            }
            set {
                this.valorField = value;
                this.RaisePropertyChanged("Valor");
            }
        }
        
        /// <remarks/>
        public int Parcelas {
            get {
                return this.parcelasField;
            }
            set {
                this.parcelasField = value;
                this.RaisePropertyChanged("Parcelas");
            }
        }
        
        /// <remarks/>
        public string NomeEmpresa {
            get {
                return this.nomeEmpresaField;
            }
            set {
                this.nomeEmpresaField = value;
                this.RaisePropertyChanged("NomeEmpresa");
            }
        }
        
        /// <remarks/>
        public int CNPJEmpresa {
            get {
                return this.cNPJEmpresaField;
            }
            set {
                this.cNPJEmpresaField = value;
                this.RaisePropertyChanged("CNPJEmpresa");
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
    public interface CardPortTypeChannel : MountainStyleShop.ServiceReference1.CardPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CardPortTypeClient : System.ServiceModel.ClientBase<MountainStyleShop.ServiceReference1.CardPortType>, MountainStyleShop.ServiceReference1.CardPortType {
        
        public CardPortTypeClient() {
        }
        
        public CardPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CardPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CardPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CardPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ValidarCartao(MountainStyleShop.ServiceReference1.tDadosCartao dadosCartao) {
            return base.Channel.ValidarCartao(dadosCartao);
        }
        
        public System.Threading.Tasks.Task<string> ValidarCartaoAsync(MountainStyleShop.ServiceReference1.tDadosCartao dadosCartao) {
            return base.Channel.ValidarCartaoAsync(dadosCartao);
        }
    }
}