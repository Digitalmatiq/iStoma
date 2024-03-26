﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iStomaLab.iFunctionalitati {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://licente.istoma.ro", ConfigurationName="iFunctionalitati.FunctionalitatiSoap")]
    public interface FunctionalitatiSoap {
        
        // CODEGEN: Generating message contract since element name pCodClient from namespace http://licente.istoma.ro is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://licente.istoma.ro/CereFunctionalitate", ReplyAction="*")]
        iStomaLab.iFunctionalitati.CereFunctionalitateResponse CereFunctionalitate(iStomaLab.iFunctionalitati.CereFunctionalitateRequest request);
        
        // CODEGEN: Generating message contract since element name pCodClient from namespace http://licente.istoma.ro is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://licente.istoma.ro/SemnaleazaProblema", ReplyAction="*")]
        iStomaLab.iFunctionalitati.SemnaleazaProblemaResponse SemnaleazaProblema(iStomaLab.iFunctionalitati.SemnaleazaProblemaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CereFunctionalitateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CereFunctionalitate", Namespace="http://licente.istoma.ro", Order=0)]
        public iStomaLab.iFunctionalitati.CereFunctionalitateRequestBody Body;
        
        public CereFunctionalitateRequest() {
        }
        
        public CereFunctionalitateRequest(iStomaLab.iFunctionalitati.CereFunctionalitateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://licente.istoma.ro")]
    public partial class CereFunctionalitateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string pCodClient;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string pParola;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string pLicenta;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int pIdEcran;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string pLocalizare;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string pDescriere;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public int pTip;
        
        public CereFunctionalitateRequestBody() {
        }
        
        public CereFunctionalitateRequestBody(string pCodClient, string pParola, string pLicenta, int pIdEcran, string pLocalizare, string pDescriere, int pTip) {
            this.pCodClient = pCodClient;
            this.pParola = pParola;
            this.pLicenta = pLicenta;
            this.pIdEcran = pIdEcran;
            this.pLocalizare = pLocalizare;
            this.pDescriere = pDescriere;
            this.pTip = pTip;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CereFunctionalitateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CereFunctionalitateResponse", Namespace="http://licente.istoma.ro", Order=0)]
        public iStomaLab.iFunctionalitati.CereFunctionalitateResponseBody Body;
        
        public CereFunctionalitateResponse() {
        }
        
        public CereFunctionalitateResponse(iStomaLab.iFunctionalitati.CereFunctionalitateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://licente.istoma.ro")]
    public partial class CereFunctionalitateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int CereFunctionalitateResult;
        
        public CereFunctionalitateResponseBody() {
        }
        
        public CereFunctionalitateResponseBody(int CereFunctionalitateResult) {
            this.CereFunctionalitateResult = CereFunctionalitateResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SemnaleazaProblemaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SemnaleazaProblema", Namespace="http://licente.istoma.ro", Order=0)]
        public iStomaLab.iFunctionalitati.SemnaleazaProblemaRequestBody Body;
        
        public SemnaleazaProblemaRequest() {
        }
        
        public SemnaleazaProblemaRequest(iStomaLab.iFunctionalitati.SemnaleazaProblemaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://licente.istoma.ro")]
    public partial class SemnaleazaProblemaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string pCodClient;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string pParola;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string pLicenta;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string pProblema;
        
        public SemnaleazaProblemaRequestBody() {
        }
        
        public SemnaleazaProblemaRequestBody(string pCodClient, string pParola, string pLicenta, string pProblema) {
            this.pCodClient = pCodClient;
            this.pParola = pParola;
            this.pLicenta = pLicenta;
            this.pProblema = pProblema;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SemnaleazaProblemaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SemnaleazaProblemaResponse", Namespace="http://licente.istoma.ro", Order=0)]
        public iStomaLab.iFunctionalitati.SemnaleazaProblemaResponseBody Body;
        
        public SemnaleazaProblemaResponse() {
        }
        
        public SemnaleazaProblemaResponse(iStomaLab.iFunctionalitati.SemnaleazaProblemaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class SemnaleazaProblemaResponseBody {
        
        public SemnaleazaProblemaResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FunctionalitatiSoapChannel : iStomaLab.iFunctionalitati.FunctionalitatiSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FunctionalitatiSoapClient : System.ServiceModel.ClientBase<iStomaLab.iFunctionalitati.FunctionalitatiSoap>, iStomaLab.iFunctionalitati.FunctionalitatiSoap {
        
        public FunctionalitatiSoapClient() {
        }
        
        public FunctionalitatiSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FunctionalitatiSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FunctionalitatiSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FunctionalitatiSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        iStomaLab.iFunctionalitati.CereFunctionalitateResponse iStomaLab.iFunctionalitati.FunctionalitatiSoap.CereFunctionalitate(iStomaLab.iFunctionalitati.CereFunctionalitateRequest request) {
            return base.Channel.CereFunctionalitate(request);
        }
        
        public int CereFunctionalitate(string pCodClient, string pParola, string pLicenta, int pIdEcran, string pLocalizare, string pDescriere, int pTip) {
            iStomaLab.iFunctionalitati.CereFunctionalitateRequest inValue = new iStomaLab.iFunctionalitati.CereFunctionalitateRequest();
            inValue.Body = new iStomaLab.iFunctionalitati.CereFunctionalitateRequestBody();
            inValue.Body.pCodClient = pCodClient;
            inValue.Body.pParola = pParola;
            inValue.Body.pLicenta = pLicenta;
            inValue.Body.pIdEcran = pIdEcran;
            inValue.Body.pLocalizare = pLocalizare;
            inValue.Body.pDescriere = pDescriere;
            inValue.Body.pTip = pTip;
            iStomaLab.iFunctionalitati.CereFunctionalitateResponse retVal = ((iStomaLab.iFunctionalitati.FunctionalitatiSoap)(this)).CereFunctionalitate(inValue);
            return retVal.Body.CereFunctionalitateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        iStomaLab.iFunctionalitati.SemnaleazaProblemaResponse iStomaLab.iFunctionalitati.FunctionalitatiSoap.SemnaleazaProblema(iStomaLab.iFunctionalitati.SemnaleazaProblemaRequest request) {
            return base.Channel.SemnaleazaProblema(request);
        }
        
        public void SemnaleazaProblema(string pCodClient, string pParola, string pLicenta, string pProblema) {
            iStomaLab.iFunctionalitati.SemnaleazaProblemaRequest inValue = new iStomaLab.iFunctionalitati.SemnaleazaProblemaRequest();
            inValue.Body = new iStomaLab.iFunctionalitati.SemnaleazaProblemaRequestBody();
            inValue.Body.pCodClient = pCodClient;
            inValue.Body.pParola = pParola;
            inValue.Body.pLicenta = pLicenta;
            inValue.Body.pProblema = pProblema;
            iStomaLab.iFunctionalitati.SemnaleazaProblemaResponse retVal = ((iStomaLab.iFunctionalitati.FunctionalitatiSoap)(this)).SemnaleazaProblema(inValue);
        }
    }
}