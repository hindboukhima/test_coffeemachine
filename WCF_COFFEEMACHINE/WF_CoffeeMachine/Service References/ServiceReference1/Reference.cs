﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WF_CoffeeMachine.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WCF_BD")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/WCF_BD")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_customerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte mugField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int qtSucreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string type_drinkField;
        
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
        public int id_customer {
            get {
                return this.id_customerField;
            }
            set {
                if ((this.id_customerField.Equals(value) != true)) {
                    this.id_customerField = value;
                    this.RaisePropertyChanged("id_customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte mug {
            get {
                return this.mugField;
            }
            set {
                if ((this.mugField.Equals(value) != true)) {
                    this.mugField = value;
                    this.RaisePropertyChanged("mug");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int qtSucre {
            get {
                return this.qtSucreField;
            }
            set {
                if ((this.qtSucreField.Equals(value) != true)) {
                    this.qtSucreField = value;
                    this.RaisePropertyChanged("qtSucre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string type_drink {
            get {
                return this.type_drinkField;
            }
            set {
                if ((object.ReferenceEquals(this.type_drinkField, value) != true)) {
                    this.type_drinkField = value;
                    this.RaisePropertyChanged("type_drink");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        WF_CoffeeMachine.ServiceReference1.CompositeType GetDataUsingDataContract(WF_CoffeeMachine.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/searchCustomer", ReplyAction="http://tempuri.org/IService1/searchCustomerResponse")]
        WF_CoffeeMachine.ServiceReference1.Customer searchCustomer(int id_customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/insertCustomer", ReplyAction="http://tempuri.org/IService1/insertCustomerResponse")]
        int insertCustomer(WF_CoffeeMachine.ServiceReference1.Customer cst);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/updateCustomer", ReplyAction="http://tempuri.org/IService1/updateCustomerResponse")]
        int updateCustomer(WF_CoffeeMachine.ServiceReference1.Customer cst);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WF_CoffeeMachine.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WF_CoffeeMachine.ServiceReference1.IService1>, WF_CoffeeMachine.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public WF_CoffeeMachine.ServiceReference1.CompositeType GetDataUsingDataContract(WF_CoffeeMachine.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public WF_CoffeeMachine.ServiceReference1.Customer searchCustomer(int id_customer) {
            return base.Channel.searchCustomer(id_customer);
        }
        
        public int insertCustomer(WF_CoffeeMachine.ServiceReference1.Customer cst) {
            return base.Channel.insertCustomer(cst);
        }
        
        public int updateCustomer(WF_CoffeeMachine.ServiceReference1.Customer cst) {
            return base.Channel.updateCustomer(cst);
        }
    }
}