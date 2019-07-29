//This file is automatically generated. DO NOT EDIT!
using System;
using RobotRaconteurWeb;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
#pragma warning disable 0108

namespace experimental.createwebcam2
{
public class experimental__createwebcam2Factory : ServiceFactory
{
    public override string DefString()
{
    const string s="#Service to provide sample interface to webcams\nservice experimental.createwebcam2\n\nstdver 0.9\n\nstruct WebcamImage\nfield int32 width\nfield int32 height\nfield int32 step\nfield uint8[] data\nend\n\nstruct WebcamImage_size\nfield int32 width\nfield int32 height\nfield int32 step\nend\n\nobject Webcam\nproperty string Name [readonly]\nfunction WebcamImage CaptureFrame()\n\nfunction void StartStreaming()\nfunction void StopStreaming()\npipe WebcamImage FrameStream [readonly]\n\nfunction WebcamImage_size CaptureFrameToBuffer()\nmemory uint8[] buffer [readonly]\nmemory uint8[*] multidimbuffer [readonly]\n\nend\n\nobject WebcamHost\nproperty string{int32} WebcamNames [readonly]\nobjref Webcam{int32} Webcams\nend\n";
    return s;
    }
    public override string GetServiceName() {return "experimental.createwebcam2";}
    public WebcamImage_stub WebcamImage_stubentry;
    public WebcamImage_size_stub WebcamImage_size_stubentry;
    public experimental__createwebcam2Factory(RobotRaconteurNode node = null, ClientContext context = null) : base(node,context)
{
    WebcamImage_stubentry=new WebcamImage_stub(this,this.node,this.context);
    WebcamImage_size_stubentry=new WebcamImage_size_stub(this,this.node,this.context);
    }
    public override IStructureStub FindStructureStub(string objecttype)
    {
    if (objecttype=="WebcamImage")
    return WebcamImage_stubentry;
    if (objecttype=="WebcamImage_size")
    return WebcamImage_size_stubentry;
    throw new DataTypeException("Cannot find appropriate structure stub");
    }
    public override IPodStub FindPodStub(string objecttype)
    {
    throw new DataTypeException("Cannot find appropriate pod stub");
    }
    public override INamedArrayStub FindNamedArrayStub(string objecttype)
    {
    throw new DataTypeException("Cannot find appropriate pod stub");
    }
    public override ServiceStub CreateStub(string objecttype, string path, ClientContext context) {
    string objshort;
    if (CompareNamespace(objecttype, out objshort)) {
    switch (objshort) {
    case "Webcam":
    return new Webcam_stub(path, context);
    case "WebcamHost":
    return new WebcamHost_stub(path, context);
    default:
    break;
    }
    } else {
    return base.CreateStub(objecttype,path,context);
    }
    throw new ServiceException("Could not create stub");
    }
    public override ServiceSkel CreateSkel(string path,object obj,ServerContext context) {
    string objtype=ServiceDefinitionUtil.FindObjectRRType(obj);
    string objshort;
    if (CompareNamespace(objtype, out objshort)) {
    switch(objshort) {
    case "Webcam":
    return new Webcam_skel(path,(Webcam)obj,context);
    case "WebcamHost":
    return new WebcamHost_skel(path,(WebcamHost)obj,context);
    default:
    break;
    }
    } else {
    return base.CreateSkel(path,obj,context);
    }
    throw new ServiceException("Could not create skel");
    }
    public override RobotRaconteurException DownCastException(RobotRaconteurException rr_exp)
    {
    if (rr_exp==null) return rr_exp;
    string rr_type=rr_exp.Error;
    if (!rr_type.Contains(".")) return rr_exp;
    string rr_stype;
    if (CompareNamespace(rr_type, out rr_stype)) {
    } else {
    return base.DownCastException(rr_exp); 
    }
    return rr_exp;
    }
}

public class WebcamImage_stub : IStructureStub {
    public WebcamImage_stub(experimental__createwebcam2Factory d, RobotRaconteurNode node, ClientContext context) {def=d; rr_node=node; rr_context=context;}
    private experimental__createwebcam2Factory def;
    private RobotRaconteurNode rr_node;
    private ClientContext rr_context;
    public MessageElementStructure PackStructure(object s1) {
    List<MessageElement> m=new List<MessageElement>();
    if (s1 ==null) return null;
    WebcamImage s = (WebcamImage)s1;
    MessageElementUtil.AddMessageElement(m,MessageElementUtil.PackScalar<int>("width",s.width));
    MessageElementUtil.AddMessageElement(m,MessageElementUtil.PackScalar<int>("height",s.height));
    MessageElementUtil.AddMessageElement(m,MessageElementUtil.PackScalar<int>("step",s.step));
    MessageElementUtil.AddMessageElement(m,MessageElementUtil.PackArray<byte>("data",s.data));
    return new MessageElementStructure("experimental.createwebcam2.WebcamImage",m);
    }
    public T UnpackStructure<T>(MessageElementStructure m) {
    if (m == null ) return default(T);
    WebcamImage s=new WebcamImage();
    s.width =(MessageElementUtil.UnpackScalar<int>(MessageElement.FindElement(m.Elements,"width")));
    s.height =(MessageElementUtil.UnpackScalar<int>(MessageElement.FindElement(m.Elements,"height")));
    s.step =(MessageElementUtil.UnpackScalar<int>(MessageElement.FindElement(m.Elements,"step")));
    s.data =MessageElementUtil.UnpackArray<byte>(MessageElement.FindElement(m.Elements,"data"));
    T st; try {st=(T)((object)s);} catch (InvalidCastException) {throw new DataTypeMismatchException("Wrong structuretype");}
    return st;
    }
}

public class WebcamImage_size_stub : IStructureStub {
    public WebcamImage_size_stub(experimental__createwebcam2Factory d, RobotRaconteurNode node, ClientContext context) {def=d; rr_node=node; rr_context=context;}
    private experimental__createwebcam2Factory def;
    private RobotRaconteurNode rr_node;
    private ClientContext rr_context;
    public MessageElementStructure PackStructure(object s1) {
    List<MessageElement> m=new List<MessageElement>();
    if (s1 ==null) return null;
    WebcamImage_size s = (WebcamImage_size)s1;
    MessageElementUtil.AddMessageElement(m,MessageElementUtil.PackScalar<int>("width",s.width));
    MessageElementUtil.AddMessageElement(m,MessageElementUtil.PackScalar<int>("height",s.height));
    MessageElementUtil.AddMessageElement(m,MessageElementUtil.PackScalar<int>("step",s.step));
    return new MessageElementStructure("experimental.createwebcam2.WebcamImage_size",m);
    }
    public T UnpackStructure<T>(MessageElementStructure m) {
    if (m == null ) return default(T);
    WebcamImage_size s=new WebcamImage_size();
    s.width =(MessageElementUtil.UnpackScalar<int>(MessageElement.FindElement(m.Elements,"width")));
    s.height =(MessageElementUtil.UnpackScalar<int>(MessageElement.FindElement(m.Elements,"height")));
    s.step =(MessageElementUtil.UnpackScalar<int>(MessageElement.FindElement(m.Elements,"step")));
    T st; try {st=(T)((object)s);} catch (InvalidCastException) {throw new DataTypeMismatchException("Wrong structuretype");}
    return st;
    }
}

public class Webcam_stub : ServiceStub , Webcam {
    private Pipe<WebcamImage> rr_FrameStream;
    private ArrayMemory<byte> rr_buffer;
    private MultiDimArrayMemory<byte> rr_multidimbuffer;
    public Webcam_stub(string path, ClientContext c) : base(path, c) {
    rr_FrameStream=new PipeClient<WebcamImage>("FrameStream", this);
    rr_buffer=new ArrayMemoryClient<byte>("buffer",this, MemberDefinition_Direction.readonly_);
    rr_multidimbuffer=new MultiDimArrayMemoryClient<byte>("multidimbuffer",this,MemberDefinition_Direction.readonly_);
    }
    public async Task<string> get_Name(CancellationToken cancel=default(CancellationToken)) {
        MessageEntry m = new MessageEntry(MessageEntryType.PropertyGetReq, "Name");
        MessageEntry mr=await ProcessRequest(m, cancel);
        MessageElement me=mr.FindElement("value");
        return MessageElementUtil.UnpackString(me);
        }
    public async Task set_Name(string value, CancellationToken cancel=default(CancellationToken)) {
        MessageEntry m=new MessageEntry(MessageEntryType.PropertySetReq,"Name");
        MessageElementUtil.AddMessageElement(m,MessageElementUtil.PackString("value",value));
        MessageEntry mr=await ProcessRequest(m, cancel);
        }
    public async Task<WebcamImage> CaptureFrame(CancellationToken cancel = default(CancellationToken)) {
        MessageEntry rr_m=new MessageEntry(MessageEntryType.FunctionCallReq,"CaptureFrame");
        MessageEntry rr_me=await ProcessRequest(rr_m, cancel);
    return MessageElementUtil.UnpackStructure<WebcamImage>(rr_node, rr_context, rr_me.FindElement("return"));
    }
    public async Task StartStreaming(CancellationToken cancel = default(CancellationToken)) {
        MessageEntry rr_m=new MessageEntry(MessageEntryType.FunctionCallReq,"StartStreaming");
        MessageEntry rr_me=await ProcessRequest(rr_m, cancel);
    }
    public async Task StopStreaming(CancellationToken cancel = default(CancellationToken)) {
        MessageEntry rr_m=new MessageEntry(MessageEntryType.FunctionCallReq,"StopStreaming");
        MessageEntry rr_me=await ProcessRequest(rr_m, cancel);
    }
    public async Task<WebcamImage_size> CaptureFrameToBuffer(CancellationToken cancel = default(CancellationToken)) {
        MessageEntry rr_m=new MessageEntry(MessageEntryType.FunctionCallReq,"CaptureFrameToBuffer");
        MessageEntry rr_me=await ProcessRequest(rr_m, cancel);
    return MessageElementUtil.UnpackStructure<WebcamImage_size>(rr_node, rr_context, rr_me.FindElement("return"));
    }
    protected override void DispatchEvent(MessageEntry rr_m) {
    switch (rr_m.MemberName) {
    default:
    break;
    }
    }
    public Pipe<WebcamImage> FrameStream {
    get { return rr_FrameStream;  }
    set { throw new InvalidOperationException();}
    }
    public ArrayMemory<byte> buffer { 
    get { return rr_buffer; }
    }
    public MultiDimArrayMemory<byte> multidimbuffer {
    get { return rr_multidimbuffer; }
    }
    protected override void DispatchPipeMessage(MessageEntry m)
    {
    switch (m.MemberName) {
    case "FrameStream":
    this.rr_FrameStream.PipePacketReceived(m);
    break;
    default:
    throw new Exception();
    }
    }
    protected override async Task<MessageEntry> CallbackCall(MessageEntry rr_m) {
    string rr_ename=rr_m.MemberName;
    MessageEntry rr_mr=new MessageEntry(MessageEntryType.CallbackCallRet, rr_ename);
    rr_mr.ServicePath=rr_m.ServicePath;
    rr_mr.RequestID=rr_m.RequestID;
    switch (rr_ename) {
    default:
    throw new MemberNotFoundException("Member not found");
    }
    return rr_mr;
    }
    protected override void DispatchWireMessage(MessageEntry m)
    {
    switch (m.MemberName) {
    default:
    throw new Exception();
    }
    }
}
public class WebcamHost_stub : ServiceStub , WebcamHost {
    public WebcamHost_stub(string path, ClientContext c) : base(path, c) {
    }
    public async Task<Dictionary<int,string>> get_WebcamNames(CancellationToken cancel=default(CancellationToken)) {
        MessageEntry m = new MessageEntry(MessageEntryType.PropertyGetReq, "WebcamNames");
        MessageEntry mr=await ProcessRequest(m, cancel);
        MessageElement me=mr.FindElement("value");
        return MessageElementUtil.UnpackMap<int,string>(rr_node, rr_context, me);
        }
    public async Task set_WebcamNames(Dictionary<int,string> value, CancellationToken cancel=default(CancellationToken)) {
        MessageEntry m=new MessageEntry(MessageEntryType.PropertySetReq,"WebcamNames");
        MessageElementUtil.AddMessageElement(m,MessageElementUtil.PackMapType<int,string>(rr_node, rr_context, "value",value));
        MessageEntry mr=await ProcessRequest(m, cancel);
        }
    protected override void DispatchEvent(MessageEntry rr_m) {
    switch (rr_m.MemberName) {
    default:
    break;
    }
    }
    public async Task<Webcam> get_Webcams(int ind, CancellationToken cancel=default(CancellationToken)) {
    return (Webcam)await FindObjRefTyped("Webcams",ind.ToString(),"experimental.createwebcam2.Webcam",cancel);
    }
    protected override void DispatchPipeMessage(MessageEntry m)
    {
    switch (m.MemberName) {
    default:
    throw new Exception();
    }
    }
    protected override async Task<MessageEntry> CallbackCall(MessageEntry rr_m) {
    string rr_ename=rr_m.MemberName;
    MessageEntry rr_mr=new MessageEntry(MessageEntryType.CallbackCallRet, rr_ename);
    rr_mr.ServicePath=rr_m.ServicePath;
    rr_mr.RequestID=rr_m.RequestID;
    switch (rr_ename) {
    default:
    throw new MemberNotFoundException("Member not found");
    }
    return rr_mr;
    }
    protected override void DispatchWireMessage(MessageEntry m)
    {
    switch (m.MemberName) {
    default:
    throw new Exception();
    }
    }
}
public class Webcam_skel : ServiceSkel {
    protected Webcam obj;
    public Webcam_skel(string p,Webcam o,ServerContext c) : base(p,o,c) { obj=(Webcam)o; }
    public override void ReleaseCastObject() { 
    }
    public override async Task<MessageEntry> CallGetProperty(MessageEntry m) {
    string ename=m.MemberName;
    MessageEntry mr=new MessageEntry(MessageEntryType.PropertyGetRes, ename);
    switch (ename) {
    case "Name":
    {
    string ret=await obj.get_Name();
    mr.AddElement(MessageElementUtil.PackString("value",ret));
    break;
    }
    default:
    throw new MemberNotFoundException("Member not found");
    }
    return mr;
    }
    public override async Task<MessageEntry> CallSetProperty(MessageEntry m) {
    string ename=m.MemberName;
    MessageElement me=m.FindElement("value");
    MessageEntry mr=new MessageEntry(MessageEntryType.PropertySetRes, ename);
    switch (ename) {
    case "Name":
    {
    await obj.set_Name(MessageElementUtil.UnpackString(me));
    break;
    }
    default:
    throw new MemberNotFoundException("Member not found");
    }
    return mr;
    }
    public override async Task<MessageEntry> CallFunction(MessageEntry rr_m) {
    string rr_ename=rr_m.MemberName;
    MessageEntry rr_mr=new MessageEntry(MessageEntryType.FunctionCallRes, rr_ename);
    switch (rr_ename) {
    case "CaptureFrame":
    {
    WebcamImage rr_ret=await this.obj.CaptureFrame(default(CancellationToken));
    rr_mr.AddElement(MessageElementUtil.PackStructure(rr_node, rr_context, "return",rr_ret));
    break;
    }
    case "StartStreaming":
    {
    await this.obj.StartStreaming(default(CancellationToken));
    rr_mr.AddElement("return",(int)0);
    break;
    }
    case "StopStreaming":
    {
    await this.obj.StopStreaming(default(CancellationToken));
    rr_mr.AddElement("return",(int)0);
    break;
    }
    case "CaptureFrameToBuffer":
    {
    WebcamImage_size rr_ret=await this.obj.CaptureFrameToBuffer(default(CancellationToken));
    rr_mr.AddElement(MessageElementUtil.PackStructure(rr_node, rr_context, "return",rr_ret));
    break;
    }
    default:
    throw new MemberNotFoundException("Member not found");
    }
    return rr_mr;
    }
    public override async Task<object> GetSubObj(string name, string ind) {
    switch (name) {
    default:
    break;
    }
    throw new MemberNotFoundException("");
    }
    public override void RegisterEvents(object rrobj1) {
    obj=(Webcam)rrobj1;
    }
    public override void UnregisterEvents(object rrobj1) {
    obj=(Webcam)rrobj1;
    }
    public override object GetCallbackFunction(uint rr_endpoint, string rr_membername) {
    switch (rr_membername) {
    default:
    break;
    }
    throw new MemberNotFoundException("Member not found");
    }
    private PipeServer<WebcamImage> rr_FrameStream;
    private bool rr_InitPipeServersRun=false;
    public override void InitPipeServers(object o) {
    if (this.rr_InitPipeServersRun) return;
    this.rr_InitPipeServersRun=true;
    Webcam castobj=(Webcam)o;
    this.rr_FrameStream=new PipeServer<WebcamImage>("FrameStream",this);
    castobj.FrameStream=this.rr_FrameStream;
    }
    public override void InitCallbackServers(object rrobj1) {
    obj=(Webcam)rrobj1;
    }
    public override async Task<MessageEntry> CallPipeFunction(MessageEntry m,Endpoint e) {
    string ename=m.MemberName;
    switch (ename) {
    case "FrameStream":
    return await this.rr_FrameStream.PipeCommand(m,e);
    default:
    throw new MemberNotFoundException("Member not found");
    }
    }
    public override async Task<MessageEntry> CallWireFunction(MessageEntry m,Endpoint e) {
    string ename=m.MemberName;
    switch (ename) {
    default:
    throw new MemberNotFoundException("Member not found");
    }
    }
    public override void DispatchPipeMessage(MessageEntry m, Endpoint e)
    {
    switch (m.MemberName) {
    case "FrameStream":
    this.rr_FrameStream.PipePacketReceived(m,e);
    break;
    default:
    throw new MemberNotFoundException("Member not found");
    }
    }
    public override void DispatchWireMessage(MessageEntry m, Endpoint e)
    {
    switch (m.MemberName) {
    default:
    throw new MemberNotFoundException("Member not found");
    }
    }
    public override async Task<MessageEntry> CallMemoryFunction(MessageEntry m,Endpoint e) {
    string ename=m.MemberName;
    switch (ename) {
    case "buffer":
     return await (new ArrayMemoryServiceSkel<byte>("buffer",this,MemberDefinition_Direction.readonly_)).CallMemoryFunction(m,e,obj.buffer);
    break;
    case "multidimbuffer":
     return await (new MultiDimArrayMemoryServiceSkel<byte>("multidimbuffer",this,MemberDefinition_Direction.readonly_)).CallMemoryFunction(m,e,obj.multidimbuffer);
    break;
    default:
    throw new MemberNotFoundException("Member not found");
    }
    }
}
public class WebcamHost_skel : ServiceSkel {
    protected WebcamHost obj;
    public WebcamHost_skel(string p,WebcamHost o,ServerContext c) : base(p,o,c) { obj=(WebcamHost)o; }
    public override void ReleaseCastObject() { 
    }
    public override async Task<MessageEntry> CallGetProperty(MessageEntry m) {
    string ename=m.MemberName;
    MessageEntry mr=new MessageEntry(MessageEntryType.PropertyGetRes, ename);
    switch (ename) {
    case "WebcamNames":
    {
    Dictionary<int,string> ret=await obj.get_WebcamNames();
    mr.AddElement(MessageElementUtil.PackMapType<int,string>(rr_node, rr_context, "value",ret));
    break;
    }
    default:
    throw new MemberNotFoundException("Member not found");
    }
    return mr;
    }
    public override async Task<MessageEntry> CallSetProperty(MessageEntry m) {
    string ename=m.MemberName;
    MessageElement me=m.FindElement("value");
    MessageEntry mr=new MessageEntry(MessageEntryType.PropertySetRes, ename);
    switch (ename) {
    case "WebcamNames":
    {
    await obj.set_WebcamNames(MessageElementUtil.UnpackMap<int,string>(rr_node, rr_context, me));
    break;
    }
    default:
    throw new MemberNotFoundException("Member not found");
    }
    return mr;
    }
    public override async Task<MessageEntry> CallFunction(MessageEntry rr_m) {
    string rr_ename=rr_m.MemberName;
    MessageEntry rr_mr=new MessageEntry(MessageEntryType.FunctionCallRes, rr_ename);
    switch (rr_ename) {
    default:
    throw new MemberNotFoundException("Member not found");
    }
    return rr_mr;
    }
    public override async Task<object> GetSubObj(string name, string ind) {
    switch (name) {
    case "Webcams": {
    return await obj.get_Webcams(Int32.Parse(ind));
    }
    default:
    break;
    }
    throw new MemberNotFoundException("");
    }
    public override void RegisterEvents(object rrobj1) {
    obj=(WebcamHost)rrobj1;
    }
    public override void UnregisterEvents(object rrobj1) {
    obj=(WebcamHost)rrobj1;
    }
    public override object GetCallbackFunction(uint rr_endpoint, string rr_membername) {
    switch (rr_membername) {
    default:
    break;
    }
    throw new MemberNotFoundException("Member not found");
    }
    private bool rr_InitPipeServersRun=false;
    public override void InitPipeServers(object o) {
    if (this.rr_InitPipeServersRun) return;
    this.rr_InitPipeServersRun=true;
    WebcamHost castobj=(WebcamHost)o;
    }
    public override void InitCallbackServers(object rrobj1) {
    obj=(WebcamHost)rrobj1;
    }
    public override async Task<MessageEntry> CallPipeFunction(MessageEntry m,Endpoint e) {
    string ename=m.MemberName;
    switch (ename) {
    default:
    throw new MemberNotFoundException("Member not found");
    }
    }
    public override async Task<MessageEntry> CallWireFunction(MessageEntry m,Endpoint e) {
    string ename=m.MemberName;
    switch (ename) {
    default:
    throw new MemberNotFoundException("Member not found");
    }
    }
    public override void DispatchPipeMessage(MessageEntry m, Endpoint e)
    {
    switch (m.MemberName) {
    default:
    throw new MemberNotFoundException("Member not found");
    }
    }
    public override void DispatchWireMessage(MessageEntry m, Endpoint e)
    {
    switch (m.MemberName) {
    default:
    throw new MemberNotFoundException("Member not found");
    }
    }
    public override async Task<MessageEntry> CallMemoryFunction(MessageEntry m,Endpoint e) {
    string ename=m.MemberName;
    switch (ename) {
    default:
    throw new MemberNotFoundException("Member not found");
    }
    }
}
public class Webcam_default_impl : Webcam{
    protected PipeBroadcaster<WebcamImage> rrvar_FrameStream;
    public virtual Task<string> get_Name(CancellationToken cancel=default(CancellationToken)) {
    throw new NotImplementedException();
    }
    public virtual Task set_Name(string value, CancellationToken cancel=default(CancellationToken)) {
    throw new NotImplementedException();
    }
    public virtual Task<WebcamImage> CaptureFrame(CancellationToken rr_cancel=default(CancellationToken)) {
    throw new NotImplementedException();
    }
    public virtual Task StartStreaming(CancellationToken rr_cancel=default(CancellationToken)) {
    throw new NotImplementedException();
    }
    public virtual Task StopStreaming(CancellationToken rr_cancel=default(CancellationToken)) {
    throw new NotImplementedException();
    }
    public virtual Task<WebcamImage_size> CaptureFrameToBuffer(CancellationToken rr_cancel=default(CancellationToken)) {
    throw new NotImplementedException();
    }
    public virtual Pipe<WebcamImage> FrameStream {
    get { return rrvar_FrameStream.Pipe;  }
    set {
    if (rrvar_FrameStream!=null) throw new InvalidOperationException("Pipe already set");
    rrvar_FrameStream= new PipeBroadcaster<WebcamImage>(value);
    }
    }
    public virtual ArrayMemory<byte> buffer { 
    get { throw new NotImplementedException(); }
    }
    public virtual MultiDimArrayMemory<byte> multidimbuffer {
    get { throw new NotImplementedException(); }
    }
}
public class WebcamHost_default_impl : WebcamHost{
    public virtual Task<Dictionary<int,string>> get_WebcamNames(CancellationToken cancel=default(CancellationToken)) {
    throw new NotImplementedException();
    }
    public virtual Task set_WebcamNames(Dictionary<int,string> value, CancellationToken cancel=default(CancellationToken)) {
    throw new NotImplementedException();
    }
    public virtual Task<Webcam> get_Webcams(int ind, CancellationToken cancel=default(CancellationToken)) {
    throw new NotImplementedException();
    }
}
public static class RRExtensions
{
}
}
