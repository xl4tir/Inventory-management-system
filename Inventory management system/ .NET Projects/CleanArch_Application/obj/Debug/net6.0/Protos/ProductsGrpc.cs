// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/products.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CleanArch_Application.Protos {
  public static partial class Products
  {
    static readonly string __ServiceName = "Products";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CleanArch_Application.Protos.GetAllProductsRequest> __Marshaller_GetAllProductsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CleanArch_Application.Protos.GetAllProductsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CleanArch_Application.Protos.ProductsResponse> __Marshaller_ProductsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CleanArch_Application.Protos.ProductsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CleanArch_Application.Protos.GetProductByIdRequest> __Marshaller_GetProductByIdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CleanArch_Application.Protos.GetProductByIdRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CleanArch_Application.Protos.ProductResponse> __Marshaller_ProductResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CleanArch_Application.Protos.ProductResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CleanArch_Application.Protos.GetAllProductsRequest, global::CleanArch_Application.Protos.ProductsResponse> __Method_GetAll = new grpc::Method<global::CleanArch_Application.Protos.GetAllProductsRequest, global::CleanArch_Application.Protos.ProductsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAll",
        __Marshaller_GetAllProductsRequest,
        __Marshaller_ProductsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CleanArch_Application.Protos.GetProductByIdRequest, global::CleanArch_Application.Protos.ProductResponse> __Method_GetById = new grpc::Method<global::CleanArch_Application.Protos.GetProductByIdRequest, global::CleanArch_Application.Protos.ProductResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetById",
        __Marshaller_GetProductByIdRequest,
        __Marshaller_ProductResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CleanArch_Application.Protos.ProductsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Products</summary>
    [grpc::BindServiceMethod(typeof(Products), "BindService")]
    public abstract partial class ProductsBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CleanArch_Application.Protos.ProductsResponse> GetAll(global::CleanArch_Application.Protos.GetAllProductsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CleanArch_Application.Protos.ProductResponse> GetById(global::CleanArch_Application.Protos.GetProductByIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Products</summary>
    public partial class ProductsClient : grpc::ClientBase<ProductsClient>
    {
      /// <summary>Creates a new client for Products</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ProductsClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Products that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ProductsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ProductsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ProductsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CleanArch_Application.Protos.ProductsResponse GetAll(global::CleanArch_Application.Protos.GetAllProductsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAll(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CleanArch_Application.Protos.ProductsResponse GetAll(global::CleanArch_Application.Protos.GetAllProductsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAll, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CleanArch_Application.Protos.ProductsResponse> GetAllAsync(global::CleanArch_Application.Protos.GetAllProductsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CleanArch_Application.Protos.ProductsResponse> GetAllAsync(global::CleanArch_Application.Protos.GetAllProductsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAll, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CleanArch_Application.Protos.ProductResponse GetById(global::CleanArch_Application.Protos.GetProductByIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CleanArch_Application.Protos.ProductResponse GetById(global::CleanArch_Application.Protos.GetProductByIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetById, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CleanArch_Application.Protos.ProductResponse> GetByIdAsync(global::CleanArch_Application.Protos.GetProductByIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CleanArch_Application.Protos.ProductResponse> GetByIdAsync(global::CleanArch_Application.Protos.GetProductByIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetById, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ProductsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ProductsClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ProductsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAll, serviceImpl.GetAll)
          .AddMethod(__Method_GetById, serviceImpl.GetById).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ProductsBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAll, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CleanArch_Application.Protos.GetAllProductsRequest, global::CleanArch_Application.Protos.ProductsResponse>(serviceImpl.GetAll));
      serviceBinder.AddMethod(__Method_GetById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CleanArch_Application.Protos.GetProductByIdRequest, global::CleanArch_Application.Protos.ProductResponse>(serviceImpl.GetById));
    }

  }
}
#endregion