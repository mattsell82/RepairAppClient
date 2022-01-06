﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RepairAppClient.ProduktService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Produkter1", Namespace="http://schemas.datacontract.org/2004/07/IProductService")]
    [System.SerializableAttribute()]
    public partial class Produkter1 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModellField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MärkeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> SerienummerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ÅrsmodellField;
        
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
        public string Modell {
            get {
                return this.ModellField;
            }
            set {
                if ((object.ReferenceEquals(this.ModellField, value) != true)) {
                    this.ModellField = value;
                    this.RaisePropertyChanged("Modell");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Märke {
            get {
                return this.MärkeField;
            }
            set {
                if ((object.ReferenceEquals(this.MärkeField, value) != true)) {
                    this.MärkeField = value;
                    this.RaisePropertyChanged("Märke");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Serienummer {
            get {
                return this.SerienummerField;
            }
            set {
                if ((this.SerienummerField.Equals(value) != true)) {
                    this.SerienummerField = value;
                    this.RaisePropertyChanged("Serienummer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Årsmodell {
            get {
                return this.ÅrsmodellField;
            }
            set {
                if ((this.ÅrsmodellField.Equals(value) != true)) {
                    this.ÅrsmodellField = value;
                    this.RaisePropertyChanged("Årsmodell");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProduktService.IProduktService")]
    public interface IProduktService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduktService/VisaAllaProdukter", ReplyAction="http://tempuri.org/IProduktService/VisaAllaProdukterResponse")]
        RepairAppClient.ProduktService.Produkter1[] VisaAllaProdukter();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduktService/VisaAllaProdukter", ReplyAction="http://tempuri.org/IProduktService/VisaAllaProdukterResponse")]
        System.Threading.Tasks.Task<RepairAppClient.ProduktService.Produkter1[]> VisaAllaProdukterAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProduktServiceChannel : RepairAppClient.ProduktService.IProduktService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProduktServiceClient : System.ServiceModel.ClientBase<RepairAppClient.ProduktService.IProduktService>, RepairAppClient.ProduktService.IProduktService {
        
        public ProduktServiceClient() {
        }
        
        public ProduktServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProduktServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProduktServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProduktServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public RepairAppClient.ProduktService.Produkter1[] VisaAllaProdukter() {
            return base.Channel.VisaAllaProdukter();
        }
        
        public System.Threading.Tasks.Task<RepairAppClient.ProduktService.Produkter1[]> VisaAllaProdukterAsync() {
            return base.Channel.VisaAllaProdukterAsync();
        }
    }
}