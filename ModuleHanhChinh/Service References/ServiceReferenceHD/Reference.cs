﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModuleHanhChinh.ServiceReferenceHD {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceHD.TransferTTBHXHSoap")]
    public interface TransferTTBHXHSoap {
        
        // CODEGEN: Generating message contract since element name MaThe from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetThongTinBHXH", ReplyAction="*")]
        ModuleHanhChinh.ServiceReferenceHD.GetThongTinBHXHResponse GetThongTinBHXH(ModuleHanhChinh.ServiceReferenceHD.GetThongTinBHXHRequest request);
        
        // CODEGEN: Generating message contract since element name soTiepNhan from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExportHDHocVien", ReplyAction="*")]
        ModuleHanhChinh.ServiceReferenceHD.ExportHDHocVienResponse ExportHDHocVien(ModuleHanhChinh.ServiceReferenceHD.ExportHDHocVienRequest request);
        
        // CODEGEN: Generating message contract since element name soTiepNhan from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExportHDHocVienChuyenDoi", ReplyAction="*")]
        ModuleHanhChinh.ServiceReferenceHD.ExportHDHocVienChuyenDoiResponse ExportHDHocVienChuyenDoi(ModuleHanhChinh.ServiceReferenceHD.ExportHDHocVienChuyenDoiRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetThongTinBHXHRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetThongTinBHXH", Namespace="http://tempuri.org/", Order=0)]
        public ModuleHanhChinh.ServiceReferenceHD.GetThongTinBHXHRequestBody Body;
        
        public GetThongTinBHXHRequest() {
        }
        
        public GetThongTinBHXHRequest(ModuleHanhChinh.ServiceReferenceHD.GetThongTinBHXHRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetThongTinBHXHRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string MaThe;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string hoten;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ngaysinh;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string gioitinh;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string ngaybd;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string ngaykt;
        
        public GetThongTinBHXHRequestBody() {
        }
        
        public GetThongTinBHXHRequestBody(string MaThe, string hoten, string ngaysinh, string gioitinh, string ngaybd, string ngaykt) {
            this.MaThe = MaThe;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.ngaybd = ngaybd;
            this.ngaykt = ngaykt;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetThongTinBHXHResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetThongTinBHXHResponse", Namespace="http://tempuri.org/", Order=0)]
        public ModuleHanhChinh.ServiceReferenceHD.GetThongTinBHXHResponseBody Body;
        
        public GetThongTinBHXHResponse() {
        }
        
        public GetThongTinBHXHResponse(ModuleHanhChinh.ServiceReferenceHD.GetThongTinBHXHResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetThongTinBHXHResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetThongTinBHXHResult;
        
        public GetThongTinBHXHResponseBody() {
        }
        
        public GetThongTinBHXHResponseBody(string GetThongTinBHXHResult) {
            this.GetThongTinBHXHResult = GetThongTinBHXHResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExportHDHocVienRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExportHDHocVien", Namespace="http://tempuri.org/", Order=0)]
        public ModuleHanhChinh.ServiceReferenceHD.ExportHDHocVienRequestBody Body;
        
        public ExportHDHocVienRequest() {
        }
        
        public ExportHDHocVienRequest(ModuleHanhChinh.ServiceReferenceHD.ExportHDHocVienRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ExportHDHocVienRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string soTiepNhan;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string userName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string password;
        
        public ExportHDHocVienRequestBody() {
        }
        
        public ExportHDHocVienRequestBody(string soTiepNhan, string userName, string password) {
            this.soTiepNhan = soTiepNhan;
            this.userName = userName;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExportHDHocVienResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExportHDHocVienResponse", Namespace="http://tempuri.org/", Order=0)]
        public ModuleHanhChinh.ServiceReferenceHD.ExportHDHocVienResponseBody Body;
        
        public ExportHDHocVienResponse() {
        }
        
        public ExportHDHocVienResponse(ModuleHanhChinh.ServiceReferenceHD.ExportHDHocVienResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ExportHDHocVienResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ExportHDHocVienResult;
        
        public ExportHDHocVienResponseBody() {
        }
        
        public ExportHDHocVienResponseBody(string ExportHDHocVienResult) {
            this.ExportHDHocVienResult = ExportHDHocVienResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExportHDHocVienChuyenDoiRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExportHDHocVienChuyenDoi", Namespace="http://tempuri.org/", Order=0)]
        public ModuleHanhChinh.ServiceReferenceHD.ExportHDHocVienChuyenDoiRequestBody Body;
        
        public ExportHDHocVienChuyenDoiRequest() {
        }
        
        public ExportHDHocVienChuyenDoiRequest(ModuleHanhChinh.ServiceReferenceHD.ExportHDHocVienChuyenDoiRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ExportHDHocVienChuyenDoiRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string soTiepNhan;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string userName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string password;
        
        public ExportHDHocVienChuyenDoiRequestBody() {
        }
        
        public ExportHDHocVienChuyenDoiRequestBody(string soTiepNhan, string userName, string password) {
            this.soTiepNhan = soTiepNhan;
            this.userName = userName;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExportHDHocVienChuyenDoiResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExportHDHocVienChuyenDoiResponse", Namespace="http://tempuri.org/", Order=0)]
        public ModuleHanhChinh.ServiceReferenceHD.ExportHDHocVienChuyenDoiResponseBody Body;
        
        public ExportHDHocVienChuyenDoiResponse() {
        }
        
        public ExportHDHocVienChuyenDoiResponse(ModuleHanhChinh.ServiceReferenceHD.ExportHDHocVienChuyenDoiResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ExportHDHocVienChuyenDoiResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ExportHDHocVienChuyenDoiResult;
        
        public ExportHDHocVienChuyenDoiResponseBody() {
        }
        
        public ExportHDHocVienChuyenDoiResponseBody(string ExportHDHocVienChuyenDoiResult) {
            this.ExportHDHocVienChuyenDoiResult = ExportHDHocVienChuyenDoiResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TransferTTBHXHSoapChannel : ModuleHanhChinh.ServiceReferenceHD.TransferTTBHXHSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TransferTTBHXHSoapClient : System.ServiceModel.ClientBase<ModuleHanhChinh.ServiceReferenceHD.TransferTTBHXHSoap>, ModuleHanhChinh.ServiceReferenceHD.TransferTTBHXHSoap {
        
        public TransferTTBHXHSoapClient() {
        }
        
        public TransferTTBHXHSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TransferTTBHXHSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TransferTTBHXHSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TransferTTBHXHSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ModuleHanhChinh.ServiceReferenceHD.GetThongTinBHXHResponse ModuleHanhChinh.ServiceReferenceHD.TransferTTBHXHSoap.GetThongTinBHXH(ModuleHanhChinh.ServiceReferenceHD.GetThongTinBHXHRequest request) {
            return base.Channel.GetThongTinBHXH(request);
        }
        
        public string GetThongTinBHXH(string MaThe, string hoten, string ngaysinh, string gioitinh, string ngaybd, string ngaykt) {
            ModuleHanhChinh.ServiceReferenceHD.GetThongTinBHXHRequest inValue = new ModuleHanhChinh.ServiceReferenceHD.GetThongTinBHXHRequest();
            inValue.Body = new ModuleHanhChinh.ServiceReferenceHD.GetThongTinBHXHRequestBody();
            inValue.Body.MaThe = MaThe;
            inValue.Body.hoten = hoten;
            inValue.Body.ngaysinh = ngaysinh;
            inValue.Body.gioitinh = gioitinh;
            inValue.Body.ngaybd = ngaybd;
            inValue.Body.ngaykt = ngaykt;
            ModuleHanhChinh.ServiceReferenceHD.GetThongTinBHXHResponse retVal = ((ModuleHanhChinh.ServiceReferenceHD.TransferTTBHXHSoap)(this)).GetThongTinBHXH(inValue);
            return retVal.Body.GetThongTinBHXHResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ModuleHanhChinh.ServiceReferenceHD.ExportHDHocVienResponse ModuleHanhChinh.ServiceReferenceHD.TransferTTBHXHSoap.ExportHDHocVien(ModuleHanhChinh.ServiceReferenceHD.ExportHDHocVienRequest request) {
            return base.Channel.ExportHDHocVien(request);
        }
        
        public string ExportHDHocVien(string soTiepNhan, string userName, string password) {
            ModuleHanhChinh.ServiceReferenceHD.ExportHDHocVienRequest inValue = new ModuleHanhChinh.ServiceReferenceHD.ExportHDHocVienRequest();
            inValue.Body = new ModuleHanhChinh.ServiceReferenceHD.ExportHDHocVienRequestBody();
            inValue.Body.soTiepNhan = soTiepNhan;
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            ModuleHanhChinh.ServiceReferenceHD.ExportHDHocVienResponse retVal = ((ModuleHanhChinh.ServiceReferenceHD.TransferTTBHXHSoap)(this)).ExportHDHocVien(inValue);
            return retVal.Body.ExportHDHocVienResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ModuleHanhChinh.ServiceReferenceHD.ExportHDHocVienChuyenDoiResponse ModuleHanhChinh.ServiceReferenceHD.TransferTTBHXHSoap.ExportHDHocVienChuyenDoi(ModuleHanhChinh.ServiceReferenceHD.ExportHDHocVienChuyenDoiRequest request) {
            return base.Channel.ExportHDHocVienChuyenDoi(request);
        }
        
        public string ExportHDHocVienChuyenDoi(string soTiepNhan, string userName, string password) {
            ModuleHanhChinh.ServiceReferenceHD.ExportHDHocVienChuyenDoiRequest inValue = new ModuleHanhChinh.ServiceReferenceHD.ExportHDHocVienChuyenDoiRequest();
            inValue.Body = new ModuleHanhChinh.ServiceReferenceHD.ExportHDHocVienChuyenDoiRequestBody();
            inValue.Body.soTiepNhan = soTiepNhan;
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            ModuleHanhChinh.ServiceReferenceHD.ExportHDHocVienChuyenDoiResponse retVal = ((ModuleHanhChinh.ServiceReferenceHD.TransferTTBHXHSoap)(this)).ExportHDHocVienChuyenDoi(inValue);
            return retVal.Body.ExportHDHocVienChuyenDoiResult;
        }
    }
}
