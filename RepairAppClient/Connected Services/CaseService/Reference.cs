﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RepairAppClient.CaseService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerDto", Namespace="http://schemas.datacontract.org/2004/07/CaseService.Dto")]
    [System.SerializableAttribute()]
    public partial class CustomerDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ZipField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
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
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Zip {
            get {
                return this.ZipField;
            }
            set {
                if ((object.ReferenceEquals(this.ZipField, value) != true)) {
                    this.ZipField = value;
                    this.RaisePropertyChanged("Zip");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CaseService.ICaseService")]
    public interface ICaseService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICaseService/GetCustomer", ReplyAction="http://tempuri.org/ICaseService/GetCustomerResponse")]
        RepairAppClient.CaseService.CustomerDto GetCustomer(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICaseService/GetCustomer", ReplyAction="http://tempuri.org/ICaseService/GetCustomerResponse")]
        System.Threading.Tasks.Task<RepairAppClient.CaseService.CustomerDto> GetCustomerAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICaseService/GetCustomers", ReplyAction="http://tempuri.org/ICaseService/GetCustomersResponse")]
        System.Collections.Generic.List<RepairAppClient.CaseService.CustomerDto> GetCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICaseService/GetCustomers", ReplyAction="http://tempuri.org/ICaseService/GetCustomersResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<RepairAppClient.CaseService.CustomerDto>> GetCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICaseService/DeleteCustomer", ReplyAction="http://tempuri.org/ICaseService/DeleteCustomerResponse")]
        void DeleteCustomer(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICaseService/DeleteCustomer", ReplyAction="http://tempuri.org/ICaseService/DeleteCustomerResponse")]
        System.Threading.Tasks.Task DeleteCustomerAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICaseService/CreateCustomer", ReplyAction="http://tempuri.org/ICaseService/CreateCustomerResponse")]
        void CreateCustomer(RepairAppClient.CaseService.CustomerDto customerDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICaseService/CreateCustomer", ReplyAction="http://tempuri.org/ICaseService/CreateCustomerResponse")]
        System.Threading.Tasks.Task CreateCustomerAsync(RepairAppClient.CaseService.CustomerDto customerDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICaseService/EditCustomer", ReplyAction="http://tempuri.org/ICaseService/EditCustomerResponse")]
        void EditCustomer(RepairAppClient.CaseService.CustomerDto customerDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICaseService/EditCustomer", ReplyAction="http://tempuri.org/ICaseService/EditCustomerResponse")]
        System.Threading.Tasks.Task EditCustomerAsync(RepairAppClient.CaseService.CustomerDto customerDto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICaseServiceChannel : RepairAppClient.CaseService.ICaseService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CaseServiceClient : System.ServiceModel.ClientBase<RepairAppClient.CaseService.ICaseService>, RepairAppClient.CaseService.ICaseService {
        
        public CaseServiceClient() {
        }
        
        public CaseServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CaseServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CaseServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CaseServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public RepairAppClient.CaseService.CustomerDto GetCustomer(int value) {
            return base.Channel.GetCustomer(value);
        }
        
        public System.Threading.Tasks.Task<RepairAppClient.CaseService.CustomerDto> GetCustomerAsync(int value) {
            return base.Channel.GetCustomerAsync(value);
        }
        
        public System.Collections.Generic.List<RepairAppClient.CaseService.CustomerDto> GetCustomers() {
            return base.Channel.GetCustomers();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<RepairAppClient.CaseService.CustomerDto>> GetCustomersAsync() {
            return base.Channel.GetCustomersAsync();
        }
        
        public void DeleteCustomer(int id) {
            base.Channel.DeleteCustomer(id);
        }
        
        public System.Threading.Tasks.Task DeleteCustomerAsync(int id) {
            return base.Channel.DeleteCustomerAsync(id);
        }
        
        public void CreateCustomer(RepairAppClient.CaseService.CustomerDto customerDto) {
            base.Channel.CreateCustomer(customerDto);
        }
        
        public System.Threading.Tasks.Task CreateCustomerAsync(RepairAppClient.CaseService.CustomerDto customerDto) {
            return base.Channel.CreateCustomerAsync(customerDto);
        }
        
        public void EditCustomer(RepairAppClient.CaseService.CustomerDto customerDto) {
            base.Channel.EditCustomer(customerDto);
        }
        
        public System.Threading.Tasks.Task EditCustomerAsync(RepairAppClient.CaseService.CustomerDto customerDto) {
            return base.Channel.EditCustomerAsync(customerDto);
        }
    }
}