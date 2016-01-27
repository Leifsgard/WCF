﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.SubstractService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SubstractService.SubstractServiceSoap")]
    public interface SubstractServiceSoap {
        
        // CODEGEN: Generating message contract since element name firstNumber from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SubstractTwo", ReplyAction="*")]
        Client.SubstractService.SubstractTwoResponse SubstractTwo(Client.SubstractService.SubstractTwoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SubstractTwo", ReplyAction="*")]
        System.Threading.Tasks.Task<Client.SubstractService.SubstractTwoResponse> SubstractTwoAsync(Client.SubstractService.SubstractTwoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SubstractTwoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SubstractTwo", Namespace="http://tempuri.org/", Order=0)]
        public Client.SubstractService.SubstractTwoRequestBody Body;
        
        public SubstractTwoRequest() {
        }
        
        public SubstractTwoRequest(Client.SubstractService.SubstractTwoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SubstractTwoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string firstNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string secondNumber;
        
        public SubstractTwoRequestBody() {
        }
        
        public SubstractTwoRequestBody(string firstNumber, string secondNumber) {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SubstractTwoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SubstractTwoResponse", Namespace="http://tempuri.org/", Order=0)]
        public Client.SubstractService.SubstractTwoResponseBody Body;
        
        public SubstractTwoResponse() {
        }
        
        public SubstractTwoResponse(Client.SubstractService.SubstractTwoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SubstractTwoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int SubstractTwoResult;
        
        public SubstractTwoResponseBody() {
        }
        
        public SubstractTwoResponseBody(int SubstractTwoResult) {
            this.SubstractTwoResult = SubstractTwoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SubstractServiceSoapChannel : Client.SubstractService.SubstractServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SubstractServiceSoapClient : System.ServiceModel.ClientBase<Client.SubstractService.SubstractServiceSoap>, Client.SubstractService.SubstractServiceSoap {
        
        public SubstractServiceSoapClient() {
        }
        
        public SubstractServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SubstractServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SubstractServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SubstractServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.SubstractService.SubstractTwoResponse Client.SubstractService.SubstractServiceSoap.SubstractTwo(Client.SubstractService.SubstractTwoRequest request) {
            return base.Channel.SubstractTwo(request);
        }
        
        public int SubstractTwo(string firstNumber, string secondNumber) {
            Client.SubstractService.SubstractTwoRequest inValue = new Client.SubstractService.SubstractTwoRequest();
            inValue.Body = new Client.SubstractService.SubstractTwoRequestBody();
            inValue.Body.firstNumber = firstNumber;
            inValue.Body.secondNumber = secondNumber;
            Client.SubstractService.SubstractTwoResponse retVal = ((Client.SubstractService.SubstractServiceSoap)(this)).SubstractTwo(inValue);
            return retVal.Body.SubstractTwoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Client.SubstractService.SubstractTwoResponse> Client.SubstractService.SubstractServiceSoap.SubstractTwoAsync(Client.SubstractService.SubstractTwoRequest request) {
            return base.Channel.SubstractTwoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Client.SubstractService.SubstractTwoResponse> SubstractTwoAsync(string firstNumber, string secondNumber) {
            Client.SubstractService.SubstractTwoRequest inValue = new Client.SubstractService.SubstractTwoRequest();
            inValue.Body = new Client.SubstractService.SubstractTwoRequestBody();
            inValue.Body.firstNumber = firstNumber;
            inValue.Body.secondNumber = secondNumber;
            return ((Client.SubstractService.SubstractServiceSoap)(this)).SubstractTwoAsync(inValue);
        }
    }
}
