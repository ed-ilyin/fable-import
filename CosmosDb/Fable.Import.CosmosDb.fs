// ts2fable 0.5.2
module rec Fable.Import.CosmosDb
open System
open Fable.Core
open Fable.Import.JS

let [<Import("UriFactory","documentdb")>] uriFactory: UriFactory.IExports = jsNative

type [<AllowNullLiteral>] IExports =
    abstract QueryIterator: QueryIteratorStatic
    abstract HashPartitionResolver: HashPartitionResolverStatic
    abstract Range: RangeStatic
    abstract RangePartitionResolver: RangePartitionResolverStatic
    abstract DocumentClient: DocumentClientStatic

/// The feed options and query methods.
type [<AllowNullLiteral>] FeedOptions =
    inherit RequestOptions
    /// Max number of items to be returned in the enumeration operation.
    abstract maxItemCount: float option with get, set
    /// Opaque token for continuing the enumeration.
    abstract continuation: string option with get, set
    /// Token for use with Session consistency.
    abstract sessionToken: string option with get, set
    /// Allow scan on the queries which couldn't be served as indexing was opted out on the requested paths.
    abstract enableScanInQuery: bool option with get, set

/// Options that can be specified for a request issued to the DocumentDB servers.
type [<AllowNullLiteral>] RequestOptions =
    /// Indicates what is the pre trigger to be invoked before the operation.
    abstract preTriggerInclude: string option with get, set
    /// Indicates what is the post trigger to be invoked after the operation.
    abstract postTriggerInclude: string option with get, set
    /// Conditions Associated with the request.
    abstract accessCondition: obj option with get, set
    /// Specifies indexing directives (index, do not index ..etc).
    abstract indexingDirective: string option with get, set
    /// Consistency level required by the client.
    abstract consistencyLevel: string option with get, set
    /// Token for use with Session consistency.
    abstract sessionToken: string option with get, set
    /// Expiry time (in seconds) for resource token associated with permission (applicable only for requests on permissions).
    abstract resourceTokenExpirySeconds: float option with get, set
    /// Offer type when creating document collections.
    abstract offerType: string option with get, set
    /// The user-specified throughput when creating document collections.
    ///
    /// Expressed in units of 100 request units per second. This can be between 400 and 250,000 (or higher by requesting a limit increase).
    ///
    /// If the x-ms-offer-throughput is over 10,000, then the collection must include a partitionKey definition.
    /// If the x-ms-offer-throughput is equal to or under 10,000, then the collection must not include a partitionKey definition.
    ///
    /// One of x-ms-offer-throughput or x-ms-offer-type must be specified. Both headers cannot be specified together.
    abstract offerThroughput: float option with get, set
    /// The partition key value for the requested document or attachment operation.
    ///
    /// Required for operations against documents and attachments when the collection definition includes a partition key definition.
    abstract partitionKey: U2<string, ResizeArray<string>> option with get, set
    /// Allow execution across multiple partitions
    ///
    /// If the collection is partitioned, this must be set to True unless the query filters against a single partition key
    /// or if the collection has only a single partition.
    abstract enableCrossPartitionQuery: bool option with get, set
    /// If true, parallelize cross-partition queries
    abstract maxDegreeOfParallelism: bool option with get, set
    /// If true, populate quota in response
    abstract populateQuotaInfo: bool option with get, set

type [<AllowNullLiteral>] DocumentOptions =
    inherit RequestOptions
    /// Disables the automatic id generation. If id is missing in the body and this option is true, an error will be returned.
    abstract disableAutomaticIdGeneration: bool option with get, set

/// The Sql query parameter.
type [<AllowNullLiteral>] SqlParameter =
    /// The name of the parameter.
    abstract name: string with get, set
    /// The value of the parameter.
    abstract value: obj option with get, set

/// The Sql query specification.
type [<AllowNullLiteral>] SqlQuerySpec =
    /// The body of the query.
    abstract query: string with get, set
    /// The array of SqlParameters.
    abstract parameters: ResizeArray<SqlParameter> with get, set

/// Represents the error object returned from a failed query.
type [<AllowNullLiteral>] QueryError =
    /// The response code corresponding to the error.
    abstract code: float with get, set
    /// A string representing the error information.
    abstract body: string with get, set

type RequestCallback<'TResult> =
    (QueryError -> 'TResult -> obj option -> unit)

/// Reprents an object with a unique identifier.
type [<AllowNullLiteral>] UniqueId =
    /// The user-defined unique identifier for a document or other DocumentDB object (database, collection, procedure...)
    abstract id: string with get, set

/// Represents the common meta data for all DocumentDB objects.
type [<AllowNullLiteral>] AbstractMeta =
    inherit UniqueId
    /// The self link.
    abstract _self: string with get, set
    /// The time the object was created.
    abstract _ts: float with get, set
    abstract _rid: string option with get, set
    abstract _etag: string option with get, set
    abstract _attachments: string option with get, set

/// Represents a custom document for storing in DocumentDB
type [<AllowNullLiteral>] NewDocument =
    inherit UniqueId
    /// The time to live in seconds of the document.
    abstract ttl: float option with get, set
    /// Custom properties
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

/// Represents a document retrieved from storage.
type [<AllowNullLiteral>] RetrievedDocument =
    inherit NewDocument
    inherit AbstractMeta

/// Represents the meta data for a database.
type [<AllowNullLiteral>] DatabaseMeta =
    inherit AbstractMeta

/// Represents the meta data for a collection.
type [<AllowNullLiteral>] CollectionMeta =
    inherit Collection
    inherit AbstractMeta

/// Represents the meta data for a stored procedure.
type [<AllowNullLiteral>] ProcedureMeta =
    inherit AbstractMeta
    abstract body: string with get, set

/// Represents the meta data for a user-defined function.
type [<AllowNullLiteral>] UserDefinedFunctionMeta =
    inherit AbstractMeta

/// Represents the meta data for a trigger.
type [<AllowNullLiteral>] TriggerMeta =
    inherit AbstractMeta
    abstract body: string with get, set
    abstract triggerType: string with get, set
    abstract triggerOperation: string with get, set

type UserFunction =
    U2<(ResizeArray<obj option> -> unit), string>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UserFunction =
    let ofCase1 v: UserFunction = v |> U2.Case1
    let isCase1 (v: UserFunction) = match v with U2.Case1 _ -> true | _ -> false
    let asCase1 (v: UserFunction) = match v with U2.Case1 o -> Some o | _ -> None
    let ofString v: UserFunction = v |> U2.Case2
    let isString (v: UserFunction) = match v with U2.Case2 _ -> true | _ -> false
    let asString (v: UserFunction) = match v with U2.Case2 o -> Some o | _ -> None

type [<AllowNullLiteral>] UserScriptable =
    inherit UniqueId
    /// The user function. Must set one of body or serverscript
    abstract body: UserFunction option with get, set
    /// The user function. Must set one of body or serverscript
    abstract serverScript: UserFunction option with get, set

/// An object that is used for authenticating requests and must contain one of the options.
type [<AllowNullLiteral>] AuthOptions =
    /// The authorization master key to use to create the client.
    abstract masterKey: string option with get, set
    /// An object that contains resources tokens. Keys for the object are resource Ids and values are the resource tokens.
    abstract resourceTokens: obj option with get, set
    /// An array of {@link Permission} objects.
    abstract permissionFeed: ResizeArray<Permission> option with get, set

/// Represents a DocumentDB stored procecedure.
type [<AllowNullLiteral>] Procedure =
    inherit UserScriptable

/// Represents a DocumentDB user-defined function.
type [<AllowNullLiteral>] UserDefinedFunction =
    inherit UserScriptable
    /// Type of function
    abstract userDefinedFunctionType: UserDefinedFunctionType option with get, set

/// Represents a DocumentDB trigger.
type [<AllowNullLiteral>] Trigger =
    inherit UserScriptable
    /// The type of the trigger. Should be either 'pre' or 'post'.
    abstract triggerType: TriggerType option with get, set
    /// The trigger operation. Should be one of 'all', 'create', 'update', 'delete', or 'replace'.
    abstract triggerOperation: TriggerOperation with get, set

/// Represents DocumentDB collection.
type [<AllowNullLiteral>] Collection =
    inherit UniqueId
    /// The indexing policy associated with the collection.
    abstract indexingPolicy: IndexingPolicy option with get, set
    /// The default time to live in seconds for documents in a collection.
    abstract defaultTtl: float option with get, set
    /// This value is used to configure the partition key to be used for partitioning data into multiple partitions.
    ///
    /// If the x-ms-offer-throughput is over 10,000, then the collection must include a partitionKey definition.
    ///
    /// If the x-ms-offer-throughput is equal to or under 10,000, then the collection must not include a partitionKey definition.
    abstract partitionKey: CollectionPartitionKey option with get, set

/// Represents a DocumentDB attachment
type [<AllowNullLiteral>] Attachment =
    /// The MIME contentType of the attachment.
    abstract contentType: string with get, set
    /// Media link associated with the attachment content.
    abstract media: string with get, set
    /// Other properties
    [<Emit "$0[$1]{{=$2}}">] abstract Item: name: string -> obj option with get, set

type [<AllowNullLiteral>] AttachmentMeta =
    inherit Attachment
    inherit AbstractMeta

type [<AllowNullLiteral>] Permission =
    inherit UniqueId
    /// The mode of the permission
    abstract permissionMode: PermissionMode with get, set
    /// The link of the resource that the permission will be applied to.
    abstract resource: string with get, set

type [<AllowNullLiteral>] PermissionMeta =
    inherit Permission
    inherit AbstractMeta

/// The Indexing Policy represents the indexing policy configuration for a collection.
type [<AllowNullLiteral>] IndexingPolicy =
    /// Specifies whether automatic indexing is enabled for a collection.
    abstract automatic: bool with get, set
    /// The indexing mode (consistent or lazy) {@link IndexingMode}.
    abstract indexingMode: IndexingMode with get, set
    /// Represents the paths to be included for indexing.
    abstract IncludedPaths: ResizeArray<IncludedPath> with get, set
    /// Represents the paths to be excluded from indexing.
    abstract ExcludedPaths: ResizeArray<ExcludedPath> with get, set

type [<AllowNullLiteral>] ExcludedPath =
    abstract Path: string with get, set

type [<AllowNullLiteral>] IncludedPath =
    /// Path to be indexed
    abstract Path: string with get, set
    abstract Indexes: ResizeArray<Index> with get, set

/// Specifies the supported Index types.
type [<AllowNullLiteral>] Index =
    abstract Kind: IndexKind with get, set
    abstract DataType: string with get, set
    abstract Precision: float with get, set

/// ConnectionPolicy
type [<AllowNullLiteral>] ConnectionPolicy =
    /// Attachment content (aka media) download mode.
    abstract MediaReadMode: MediaReadMode with get, set
    /// Time to wait for response from network peer for attachment content (aka media) operations. Represented in milliseconds.
    abstract MediaRequestTimeout: float with get, set
    /// Request timeout (time to wait for response from network peer). Represented in milliseconds.
    abstract RequestTimeout: float with get, set
    /// Flag to enable/disable automatic redirecting of requests based on read/write operations.
    abstract EnableEndpointDiscovery: bool with get, set
    /// List of azure regions to be used as preferred locations for read requests.
    abstract PreferredLocations: ResizeArray<obj option> with get, set
    /// RetryOptions instance which defines several configurable properties used during retry.
    abstract RetryOptions: RetryOptions with get, set
    /// Flag to disable SSL verification for the requests.
    ///
    /// SSL verification is enabled by default. Don't set this when targeting production endpoints.
    ///
    /// This is intended to be used only when targeting emulator endpoint to avoid failing your requests with SSL related error.
    abstract DisableSSLVerification: bool with get, set

/// RetryOptions
type [<AllowNullLiteral>] RetryOptions =
    /// Max number of retries to be performed for a request. Default value 9.
    abstract MaxRetryAttemptCount: float option with get, set
    /// Fixed retry interval in milliseconds to wait between each retry ignoring the retryAfter returned as part of the response.
    abstract FixedRetryIntervalInMilliseconds: float option with get, set
    /// Max wait time in seconds to wait for a request while the retries are happening. Default value 30 seconds.
    abstract MaxWaitTimeInSeconds: float option with get, set

type [<AllowNullLiteral>] MediaOptions =
    inherit RequestOptions
    /// HTTP Slug header value.
    abstract slug: string option with get, set
    /// HTTP ContentType header value.
    abstract contentType: string option with get, set

type [<AllowNullLiteral>] DatabaseAccountRequestOptions =
    inherit RequestOptions
    /// The endpoint url whose database account needs to be retrieved. If not present, current client's url will be used.
    abstract urlConnection: string option with get, set

type [<AllowNullLiteral>] DatabaseAccount =
    abstract DatabasesLink: string with get, set
    abstract MediaLink: string with get, set
    abstract MaxMediaStorageUsageInMB: float with get, set
    abstract CurrentMediaStorageUsageInMB: float with get, set
    abstract ConsistencyPolicy: ConsistencyPolicy with get, set
    abstract WritableLocations: ResizeArray<string> with get, set
    abstract ReadableLocations: ResizeArray<string> with get, set

type [<AllowNullLiteral>] ConsistencyPolicy =
    abstract defaultConsistencyLevel: ConsistencyLevel with get, set
    abstract maxStalenessPrefix: float with get, set
    abstract maxStalenessIntervalInSeconds: float with get, set

type [<AllowNullLiteral>] RangeOptions =
    /// The low value in the range.
    abstract low: obj option with get, set
    /// The high value in the range.
    abstract high: obj option with get, set

type [<AllowNullLiteral>] PartitionKeyMap =
    abstract link: string with get, set
    abstract range: Range with get, set

type [<AllowNullLiteral>] CollectionPartitionKey =
    /// An array of paths using which data within the collection can be partitioned.
    ///
    /// Paths must not contain a wildcard or a trailing slash. For example, the JSON property “AccountNumber” is specified as “/AccountNumber”.
    ///
    /// The array must contain only a single value.
    abstract paths: ResizeArray<string> with get, set
    /// The algorithm used for partitioning. Only Hash is supported.
    abstract kind: PartitionKind with get, set

type DocumentQuery =
    U2<SqlQuerySpec, string>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module DocumentQuery =
    let ofSqlQuerySpec v: DocumentQuery = v |> U2.Case1
    let isSqlQuerySpec (v: DocumentQuery) = match v with U2.Case1 _ -> true | _ -> false
    let asSqlQuerySpec (v: DocumentQuery) = match v with U2.Case1 o -> Some o | _ -> None
    let ofString v: DocumentQuery = v |> U2.Case2
    let isString (v: DocumentQuery) = match v with U2.Case2 _ -> true | _ -> false
    let asString (v: DocumentQuery) = match v with U2.Case2 o -> Some o | _ -> None

/// DEPRECATED
///
/// Support for IPartitionResolver is now obsolete.
/// It's recommended that you use Partitioned Collections for higher storage and throughput.
type [<AllowNullLiteral>] PartitionResolver =
    /// <summary>Extracts the partition key from the specified document using the partitionKeyExtractor</summary>
    /// <param name="document">- The document from which to extract the partition key.</param>
    abstract getPartitionKey: document: obj option -> string
    /// <summary>Given a partition key, returns the correct collection link for creating a document.</summary>
    /// <param name="partitionKey">- The partition key used to determine the target collection for create</param>
    abstract resolveForCreate: partitionKey: string -> string
    /// <summary>Given a partition key, returns a list of collection links to read from.</summary>
    /// <param name="partitionKey">- The partition key used to determine the target collection for query</param>
    abstract resolveForRead: partitionKey: obj option -> ResizeArray<string>

/// DEPRECATED
///
/// Support for IPartitionResolver is now obsolete.
/// It's recommended that you use Partitioned Collections for higher storage and throughput.
type [<AllowNullLiteral>] ConsistentHashRingOptions =
    /// Function to compute the hash for a given link or partition key
    abstract computeHash: key: U2<string, float> * seed: float -> float
    /// Number of points in the ring to assign to each collection link
    abstract numberOfVirtualNodesPerCollection: float option with get, set

/// Represents a QueryIterator Object, an implmenetation of feed or query response that enables traversal and iterating over the response in the Azure DocumentDB database service.
type [<AllowNullLiteral>] QueryIterator<'TResultRow> =
    /// <summary>Retrieve the current element on the QueryIterator.</summary>
    /// <param name="callback">Function to execute for the current element.</param>
    abstract current: callback: RequestCallback<'TResultRow> -> unit
    /// <summary>Retrieve the next batch of the feed and pass them as an array to a function</summary>
    /// <param name="callback">Function execute on the feed response.</param>
    abstract executeNext: callback: RequestCallback<ResizeArray<'TResultRow>> -> unit
    /// <summary>Execute a provided function once per feed element.</summary>
    /// <param name="callback">Function to execute for each element. the function takes two parameters error, element. Note: the last element the callback
    /// will be called on will be undefined. If the callback explicitly returned false, the loop gets stopped.</param>
    abstract forEach: callback: RequestCallback<'TResultRow> -> unit
    /// DEPRECATED
    ///
    /// Instead check if callback(undefined, undefined) is invoked by nextItem(callback) or current(callback)
    ///
    /// Determine if there are still remaining resources to processs based on the value of the continuation token
    /// or the elements remaining on the current batch in the QueryIterator.
    abstract hasMoreResults: unit -> bool
    /// <summary>Execute a provided function on the next element in the QueryIterator.</summary>
    /// <param name="callback">Function to execute for each element.</param>
    abstract nextItem: callback: RequestCallback<'TResultRow> -> unit
    /// Reset the QueryIterator to the beginning and clear all the resources inside it
    abstract reset: unit -> unit
    /// <summary>Retrieve all the elements of the feed and pass them as an array to a function</summary>
    /// <param name="callback">Function execute on the feed response.</param>
    abstract toArray: callback: RequestCallback<ResizeArray<'TResultRow>> -> unit

/// Represents a QueryIterator Object, an implmenetation of feed or query response that enables traversal and iterating over the response in the Azure DocumentDB database service.
type [<AllowNullLiteral>] QueryIteratorStatic =
    /// <summary>Constructs a QueryIterator object</summary>
    /// <param name="documentclient">- The documentclient object.</param>
    /// <param name="query">- A SQL query.</param>
    /// <param name="options">- Represents the feed options.</param>
    /// <param name="fetchFunctions">- A function to retrieve each page of data. An array of functions may be used to query more than one partition.</param>
    /// <param name="resourceLinkopt">- An optional parameter that represents the resourceLink (will be used in orderby/top/parallel query)</param>
    [<Emit "new $0($1...)">] abstract Create: documentclient: DocumentClient * query: DocumentQuery * options: FeedOptions * fetchFunctions: U2<RequestCallback<'TResultRow>, Array<RequestCallback<'TResultRow>>> * ?resourceLinkopt: string -> QueryIterator<'TResultRow>

/// DEPRECATED
///
/// Support for IPartitionResolver is now obsolete.
/// It's recommended that you use Partitioned Collections for higher storage and throughput.
type [<AllowNullLiteral>] HashPartitionResolver =
    inherit PartitionResolver
    /// <summary>Extracts the partition key from the specified document using the partitionKeyExtractor</summary>
    /// <param name="document">- The document from which to extract the partition key.</param>
    abstract getPartitionKey: document: obj option -> string
    /// <summary>Given a partition key, returns the correct collection link for creating a document.</summary>
    /// <param name="partitionKey">- The partition key used to determine the target collection for create</param>
    abstract resolveForCreate: partitionKey: string -> string
    /// <summary>Given a partition key, returns a list of collection links to read from.</summary>
    /// <param name="partitionKey">- The partition key used to determine the target collection for query</param>
    abstract resolveForRead: partitionKey: string -> ResizeArray<string>

/// DEPRECATED
///
/// Support for IPartitionResolver is now obsolete.
/// It's recommended that you use Partitioned Collections for higher storage and throughput.
type [<AllowNullLiteral>] HashPartitionResolverStatic =
    /// <summary>DEPRECATED
    ///
    /// Support for IPartitionResolver is now obsolete.
    /// It's recommended that you use Partitioned Collections for higher storage and throughput.</summary>
    /// <param name="partitionKeyExtractor">- If partitionKeyExtractor is a string, it should be the name of the property in the document to execute the hashing on.
    /// If partitionKeyExtractor is a function, it should be a function to extract the partition key from an object.</param>
    /// <param name="options">- Options forr the ConsistentHashRing (MurmurHash)</param>
    [<Emit "new $0($1...)">] abstract Create: partitionKeyExtractor: U2<string, (obj option -> obj option)> * collectionLinks: ResizeArray<string> * ?options: ConsistentHashRingOptions -> HashPartitionResolver

/// DEPRECATED
///
/// Support for IPartitionResolver is now obsolete.
/// It's recommended that you use Partitioned Collections for higher storage and throughput.
type [<AllowNullLiteral>] Range =
    interface end

/// DEPRECATED
///
/// Support for IPartitionResolver is now obsolete.
/// It's recommended that you use Partitioned Collections for higher storage and throughput.
type [<AllowNullLiteral>] RangeStatic =
    /// <summary>DEPRECATED
    ///
    /// Support for IPartitionResolver is now obsolete.
    /// It's recommended that you use Partitioned Collections for higher storage and throughput.</summary>
    /// <param name="options">-  The Range constructor options.</param>
    [<Emit "new $0($1...)">] abstract Create: options: RangeOptions -> Range

/// DEPRECATED
///
/// Support for IPartitionResolver is now obsolete.
/// It's recommended that you use Partitioned Collections for higher storage and throughput.
type [<AllowNullLiteral>] RangePartitionResolver =
    inherit PartitionResolver
    /// <summary>Extracts the partition key from the specified document using the partitionKeyExtractor</summary>
    /// <param name="document">- The document from which to extract the partition key.</param>
    abstract getPartitionKey: document: obj option -> string
    /// <summary>Given a partition key, returns the correct collection link for creating a document.</summary>
    /// <param name="partitionKey">- The partition key used to determine the target collection for create</param>
    abstract resolveForCreate: partitionKey: string -> string
    /// <summary>Given a partition key, returns a list of collection links to read from.</summary>
    /// <param name="partitionKey">- The partition key used to determine the target collection for query</param>
    abstract resolveForRead: partitionKey: string -> ResizeArray<string>

/// DEPRECATED
///
/// Support for IPartitionResolver is now obsolete.
/// It's recommended that you use Partitioned Collections for higher storage and throughput.
type [<AllowNullLiteral>] RangePartitionResolverStatic =
    /// <summary>DEPRECATED
    ///
    /// Support for IPartitionResolver is now obsolete.
    /// It's recommended that you use Partitioned Collections for higher storage and throughput.</summary>
    /// <param name="partitionKeyExtractor">- If partitionKeyExtractor is a string, it should be the name of the property in the document to execute the
    /// hashing on. If partitionKeyExtractor is a function, it should be a function to extract the partition key from an object.</param>
    /// <param name="partitionKeyMap">- The map from Range to collection link that is used for partitioning requests.</param>
    /// <param name="compareFunction">- Optional function that accepts two arguments a and b and returns a negative value if a < b, zero if a = b, or a positive value if a > b.</param>
    [<Emit "new $0($1...)">] abstract Create: partitionKeyExtractor: U2<string, (obj option -> obj option)> * partitionKeyMap: ResizeArray<PartitionKeyMap> * ?compareFunction: (obj option -> obj option -> float) -> RangePartitionResolver

/// Provides a client-side logical representation of the Azure DocumentDB database account. This client is used to configure and execute requests against the service.
type [<AllowNullLiteral>] DocumentClient =
    /// <summary>Create an attachment for the document object.
    /// <p>
    ///   Each document may contain zero or more attachments. Attachments can be of any MIME type - text, image, binary data. <br>
    ///   These are stored externally in Azure Blob storage. Attachments are automatically deleted when the parent document is deleted.
    /// </p></summary>
    /// <param name="documentLink">- The self-link of the document.</param>
    /// <param name="body">- The metadata the defines the attachment media like media, contentType. It can include any other properties as part of the metedata</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract createAttachment: documentLink: string * body: Attachment * options: RequestOptions * callback: RequestCallback<AttachmentMeta> -> unit
    abstract createAttachment: documentLink: string * body: Attachment * callback: RequestCallback<AttachmentMeta> -> unit
    /// <summary>Create an attachment with media file for the document object.</summary>
    /// <param name="documentLink">- The self-link of the document.</param>
    /// <param name="readableStream">- The stream that represents the media itself that needs to be uploaded.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    // abstract createAttachmentAndUploadMedia: documentLink: string * readableStream: NodeJS.ReadableStream * options: MediaOptions * callback: RequestCallback<AttachmentMeta> -> unit
    // abstract createAttachmentAndUploadMedia: documentLink: string * readableStream: NodeJS.ReadableStream * callback: RequestCallback<AttachmentMeta> -> unit
    /// <summary>Send a request for creating a database.
    ///   A database manages users, permissions and a set of collections.
    ///   Each Azure DocumentDB Database Account is able to support multiple independent named databases, with the database being the logical container for data.
    ///   Each Database consists of one or more collections, each of which in turn contain one or more documents. Since databases are an an administrative
    ///   resource, the Service Master Key will be required in order to access and successfully complete any action using the User APIs.</summary>
    /// <param name="body">- A json object that represents The database to be created.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract createDatabase: body: UniqueId * options: RequestOptions * callback: RequestCallback<DatabaseMeta> -> unit
    abstract createDatabase: body: UniqueId * callback: RequestCallback<DatabaseMeta> -> unit
    /// <summary>Creates a collection.
    /// <p>
    /// A collection is a named logical container for documents. <br>
    /// A database may contain zero or more named collections and each collection consists of zero or more JSON documents. <br>
    /// Being schema-free, the documents in a collection do not need to share the same structure or fields. <br>
    /// Since collections are application resources, they can be authorized using either the master key or resource keys. <br>
    /// </p></summary>
    /// <param name="databaseLink">- The self-link of the database.</param>
    /// <param name="body">- Represents the body of the collection.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract createCollection: databaseLink: string * body: Collection * options: RequestOptions * callback: RequestCallback<CollectionMeta> -> unit
    abstract createCollection: databaseLink: string * body: Collection * callback: RequestCallback<CollectionMeta> -> unit
    /// <summary>Create a StoredProcedure.
    /// <p>
    /// DocumentDB allows stored procedures to be executed in the storage tier, directly against a document collection. The script <br>
    /// gets executed under ACID transactions on the primary storage partition of the specified collection. For additional details, <br>
    /// refer to the server-side JavaScript API documentation.
    /// </p></summary>
    /// <param name="collectionLink">- The self-link of the collection.</param>
    /// <param name="procedure">- Represents the body of the stored procedure.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract createStoredProcedure: collectionLink: string * procedure: Procedure * options: RequestOptions * callback: RequestCallback<ProcedureMeta> -> unit
    abstract createStoredProcedure: collectionLink: string * procedure: Procedure * callback: RequestCallback<ProcedureMeta> -> unit
    /// <summary>Create a UserDefinedFunction.
    /// <p>
    /// DocumentDB supports JavaScript UDFs which can be used inside queries, stored procedures and triggers. <br>
    /// For additional details, refer to the server-side JavaScript API documentation.
    /// </p></summary>
    /// <param name="collectionLink">- The self-link of the collection.</param>
    /// <param name="udf">- Represents the body of the userDefinedFunction.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract createUserDefinedFunction: collectionLink: string * udf: UserDefinedFunction * options: RequestOptions * callback: RequestCallback<UserDefinedFunctionMeta> -> unit
    abstract createUserDefinedFunction: collectionLink: string * udf: UserDefinedFunction * callback: RequestCallback<UserDefinedFunctionMeta> -> unit
    /// <summary>Create a trigger.
    /// <p>
    /// DocumentDB supports pre and post triggers defined in JavaScript to be executed on creates, updates and deletes. <br>
    /// For additional details, refer to the server-side JavaScript API documentation.
    /// </p></summary>
    /// <param name="collectionLink">- The self-link of the collection.</param>
    /// <param name="trigger">- Represents the body of the trigger.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract createTrigger: collectionLink: string * trigger: Trigger * options: RequestOptions * callback: RequestCallback<TriggerMeta> -> unit
    abstract createTrigger: collectionLink: string * trigger: Trigger * callback: RequestCallback<TriggerMeta> -> unit
    /// <summary>Create a document.
    /// <p>
    /// There is no set schema for JSON documents. They may contain any number of custom properties as well as an optional list of attachments. <br>
    /// A Document is an application resource and can be authorized using the master key or resource keys
    /// </p></summary>
    /// <param name="documentsFeedOrDatabaseLink">- The self-link of the collection.</param>
    /// <param name="document">- Represents the body of the document. Can contain any number of user defined properties.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract createDocument: documentsFeedOrDatabaseLink: string * document: NewDocument * options: DocumentOptions * callback: RequestCallback<RetrievedDocument> -> unit
    abstract createDocument: documentsFeedOrDatabaseLink: string * document: NewDocument * callback: RequestCallback<RetrievedDocument> -> unit
    /// <summary>Create a permission. A permission represents a per-User Permission to access a specific resource e.g. Document or Collection.</summary>
    /// <param name="userLink">- Self-link of the user.</param>
    /// <param name="body">- Permission body</param>
    /// <param name="options">- Request options</param>
    /// <param name="callback">- Callback for the request</param>
    abstract createPermission: userLink: string * body: Permission * options: RequestOptions * callback: RequestCallback<PermissionMeta> -> unit
    abstract createPermission: userLink: string * body: Permission * callback: RequestCallback<PermissionMeta> -> unit
    /// <summary>Create a user</summary>
    /// <param name="databaseLink">- The self-link of the database.</param>
    /// <param name="body">- Represents the body of the user.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract createUser: databaseLink: string * body: UniqueId * options: RequestOptions * callback: RequestCallback<AbstractMeta> -> unit
    abstract createUser: databaseLink: string * body: UniqueId * callback: RequestCallback<AbstractMeta> -> unit
    /// <summary>Execute the StoredProcedure represented by the object.</summary>
    /// <param name="procedureLink">- The self-link of the stored procedure.</param>
    /// <param name="params">- Represents the parameters of the stored procedure.</param>
    /// <param name="options">- The request options</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract executeStoredProcedure: procedureLink: string * ``params``: ResizeArray<obj option> * options: RequestOptions * callback: RequestCallback<'TResult> -> unit
    abstract executeStoredProcedure: procedureLink: string * paramsOrOptions: U2<ResizeArray<obj option>, RequestOptions> * callback: RequestCallback<'TResult> -> unit
    /// <summary>Lists all databases that satisfy a query.</summary>
    /// <param name="query">- A SQL query string.</param>
    /// <param name="options">- The feed options.</param>
    abstract queryDatabases: query: DocumentQuery * ?options: FeedOptions -> QueryIterator<DatabaseMeta>
    /// <summary>Query the collections for the database.</summary>
    /// <param name="databaseLink">- The self-link of the database.</param>
    /// <param name="query">- A SQL query string.</param>
    /// <param name="options">- Represents the feed options.</param>
    abstract queryCollections: databaseLink: string * query: DocumentQuery * ?options: FeedOptions -> QueryIterator<CollectionMeta>
    /// <summary>Query the storedProcedures for the collection.</summary>
    /// <param name="collectionLink">- The self-link of the collection.</param>
    /// <param name="query">- A SQL query string.</param>
    /// <param name="options">- Represents the feed options.</param>
    abstract queryStoredProcedures: collectionLink: string * query: DocumentQuery * ?options: FeedOptions -> QueryIterator<ProcedureMeta>
    /// <summary>Query the user-defined functions for the collection.</summary>
    /// <param name="collectionLink">- The self-link of the collection.</param>
    /// <param name="query">- A SQL query string.</param>
    /// <param name="options">- Represents the feed options.</param>
    abstract queryUserDefinedFunctions: collectionLink: string * query: DocumentQuery * ?options: FeedOptions -> QueryIterator<UserDefinedFunctionMeta>
    /// <summary>Query the documents for the collection.</summary>
    /// <param name="collectionLink">- The self-link of the collection.</param>
    /// <param name="query">- A SQL query string.</param>
    /// <param name="options">- Represents the feed options.</param>
    abstract queryDocuments: collectionLink: string * query: DocumentQuery * ?options: FeedOptions -> QueryIterator<RetrievedDocument>
    /// <summary>Query the triggers for the collection.</summary>
    /// <param name="collectionLink">- The self-link of the collection.</param>
    /// <param name="query">- A SQL query.</param>
    /// <param name="options">- Represents the feed options.</param>
    abstract queryTriggers: collectionLink: string * query: DocumentQuery * ?options: FeedOptions -> QueryIterator<TriggerMeta>
    /// <summary>Query the attachments for the document.</summary>
    /// <param name="documentLink">- The self-link of the document.</param>
    /// <param name="query">- A SQL query.</param>
    /// <param name="options">- Represents the feed options.</param>
    abstract queryAttachments: documentLink: string * query: DocumentQuery * ?options: FeedOptions -> QueryIterator<'T>
    /// <summary>Query the conflicts for the collection.</summary>
    /// <param name="collectionLink">- The self-link of the collection.</param>
    /// <param name="query">- A SQL query.</param>
    /// <param name="options">- Represents the feed options.</param>
    abstract queryConflicts: collectionLink: string * query: DocumentQuery * ?options: FeedOptions -> QueryIterator<obj option>
    /// <summary>Lists all offers that satisfy a query.</summary>
    /// <param name="query">- A SQL query.</param>
    /// <param name="options">- The feed options.</param>
    abstract queryOffers: query: DocumentQuery * ?options: FeedOptions -> QueryIterator<obj option>
    /// <summary>Query the permission for the user.</summary>
    /// <param name="userLink">- The self-link of the user.</param>
    /// <param name="query">- A SQL query.</param>
    /// <param name="options">- Feed options.</param>
    abstract queryPermissions: userLink: string * query: DocumentQuery * ?options: FeedOptions -> QueryIterator<PermissionMeta>
    /// <summary>Query the users for the database.</summary>
    /// <param name="databaseLink">- The self-link of the database.</param>
    /// <param name="query">- A SQL query.</param>
    /// <param name="options">- Represents the feed options.</param>
    abstract queryUsers: databaseLink: string * query: DocumentQuery * ?options: FeedOptions -> QueryIterator<AbstractMeta>
    /// <summary>Delete the document object.</summary>
    /// <param name="documentLink">- The self-link of the document.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract deleteDocument: documentLink: string * options: RequestOptions * callback: RequestCallback<unit> -> unit
    abstract deleteDocument: documentLink: string * callback: RequestCallback<unit> -> unit
    /// <summary>Delete the database object.</summary>
    /// <param name="databaseLink">- The self-link of the database.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract deleteDatabase: databaseLink: string * options: RequestOptions * callback: RequestCallback<unit> -> unit
    abstract deleteDatabase: databaseLink: string * callback: RequestCallback<unit> -> unit
    /// <summary>Delete the collection object.</summary>
    /// <param name="collectionLink">- The self-link of the collection.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract deleteCollection: collectionLink: string * options: RequestOptions * callback: RequestCallback<unit> -> unit
    abstract deleteCollection: collectionLink: string * callback: RequestCallback<unit> -> unit
    /// <summary>Delete the StoredProcedure object.</summary>
    /// <param name="procedureLink">- The self-link of the stored procedure.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract deleteStoredProcedure: procedureLink: string * options: RequestOptions * callback: RequestCallback<unit> -> unit
    abstract deleteStoredProcedure: procedureLink: string * callback: RequestCallback<unit> -> unit
    /// <summary>Delete an attachment</summary>
    /// <param name="attachmentLink">- The self-link of the attachment.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract deleteAttachment: attachmentLink: string * options: RequestOptions * callback: RequestCallback<unit> -> unit
    abstract deleteAttachment: attachmentLink: string * callback: RequestCallback<unit> -> unit
    /// <summary>Delete a conflict</summary>
    /// <param name="conflictLink">- The self-link of the conflict.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract deleteConflict: conflictLink: string * options: RequestOptions * callback: RequestCallback<unit> -> unit
    abstract deleteConflict: conflictLink: string * callback: RequestCallback<unit> -> unit
    /// <summary>Delete a permission</summary>
    /// <param name="permissionLink">- The self-link of the permission.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract deletePermission: permissionLink: string * options: RequestOptions * callback: RequestCallback<unit> -> unit
    abstract deletePermission: permissionLink: string * callback: RequestCallback<unit> -> unit
    /// <summary>Delete a trigger</summary>
    /// <param name="triggerLink">- The self-link of the trigger.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract deleteTrigger: triggerLink: string * options: RequestOptions * callback: RequestCallback<unit> -> unit
    abstract deleteTrigger: triggerLink: string * callback: RequestCallback<unit> -> unit
    /// <summary>Delete a user</summary>
    /// <param name="userLink">- The self-link of the user.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract deleteUser: userLink: string * options: RequestOptions * callback: RequestCallback<unit> -> unit
    abstract deleteUser: userLink: string * callback: RequestCallback<unit> -> unit
    /// <summary>Delete a user-defined function</summary>
    /// <param name="udfLink">- The self-link of the user defined function.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract deleteUserDefinedFunction: udfLink: string * options: RequestOptions * callback: RequestCallback<unit> -> unit
    abstract deleteUserDefinedFunction: udfLink: string * callback: RequestCallback<unit> -> unit
    /// <summary>Replace the document object.</summary>
    /// <param name="documentLink">- The self-link of the document.</param>
    /// <param name="document">- Represent the new document body.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract replaceDocument: documentLink: string * document: NewDocument * options: RequestOptions * callback: RequestCallback<RetrievedDocument> -> unit
    abstract replaceDocument: documentLink: string * document: NewDocument * callback: RequestCallback<RetrievedDocument> -> unit
    /// <summary>Replace the StoredProcedure object.</summary>
    /// <param name="procedureLink">- The self-link of the stored procedure.</param>
    /// <param name="procedure">- Represent the new procedure body.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract replaceStoredProcedure: procedureLink: string * procedure: Procedure * options: RequestOptions * callback: RequestCallback<ProcedureMeta> -> unit
    abstract replaceStoredProcedure: procedureLink: string * procedure: Procedure * callback: RequestCallback<ProcedureMeta> -> unit
    /// <summary>Replace the attachment object.</summary>
    /// <param name="attachmentLink">- The self-link of the attachment.</param>
    /// <param name="attachment">- Represent the new attachment body.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract replaceAttachment: attachmentLink: string * attachment: Attachment * options: RequestOptions * callback: RequestCallback<AttachmentMeta> -> unit
    abstract replaceAttachment: attachmentLink: string * attachment: Attachment * callback: RequestCallback<AttachmentMeta> -> unit
    /// <summary>Replace the document collection.</summary>
    /// <param name="collectionLink">- The self-link of the document collection.</param>
    /// <param name="collection">- Represent the new document collection body.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract replaceCollection: collectionLink: string * collection: Collection * options: RequestOptions * callback: RequestCallback<CollectionMeta> -> unit
    abstract replaceCollection: collectionLink: string * collection: Collection * callback: RequestCallback<CollectionMeta> -> unit
    /// <summary>Replace the offer object.</summary>
    /// <param name="offerLink">- The self-link of the offer.</param>
    /// <param name="offer">- Represent the new offer body.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract replaceOffer: offerLink: string * offer: obj option * callback: RequestCallback<obj option> -> unit
    /// <summary>Replace the permission object.</summary>
    /// <param name="permissionLink">- The self-link of the permission.</param>
    /// <param name="permission">- Represent the new permission body.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract replacePermission: permissionLink: string * permission: Permission * options: RequestOptions * callback: RequestCallback<PermissionMeta> -> unit
    abstract replacePermission: permissionLink: string * permission: Permission * callback: RequestCallback<PermissionMeta> -> unit
    /// <summary>Replace the trigger object.</summary>
    /// <param name="triggerLink">- The self-link of the trigger.</param>
    /// <param name="trigger">- Represent the new trigger body.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract replaceTrigger: triggerLink: string * trigger: Trigger * options: RequestOptions * callback: RequestCallback<TriggerMeta> -> unit
    abstract replaceTrigger: triggerLink: string * trigger: Trigger * callback: RequestCallback<TriggerMeta> -> unit
    /// <summary>Replace the user object.</summary>
    /// <param name="userLink">- The self-link of the user.</param>
    /// <param name="user">- Represent the new user body.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract replaceUser: userLink: string * user: UniqueId * options: RequestOptions * callback: RequestCallback<AbstractMeta> -> unit
    abstract replaceUser: userLink: string * user: UniqueId * callback: RequestCallback<AbstractMeta> -> unit
    /// <summary>Replace the UserDefinedFunction object.</summary>
    /// <param name="udfLink">- The self-link of the user defined function.</param>
    /// <param name="udf">- Represent the new udf body.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract replaceUserDefinedFunction: udfLink: string * udf: UserDefinedFunction * options: RequestOptions * callback: RequestCallback<UserDefinedFunctionMeta> -> unit
    abstract replaceUserDefinedFunction: udfLink: string * udf: UserDefinedFunction * callback: RequestCallback<UserDefinedFunctionMeta> -> unit
    /// <summary>Read an Attachment object.</summary>
    /// <param name="attachmentLink">- The self-link of the attachment.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract readAttachment: attachmentLink: string * options: RequestOptions * callback: RequestCallback<AttachmentMeta> -> unit
    abstract readAttachment: attachmentLink: string * callback: RequestCallback<AttachmentMeta> -> unit
    /// <summary>Get all attachments for this document.</summary>
    /// <param name="documentLink">- The self-link of the document.</param>
    /// <param name="options">- The feed options.</param>
    abstract readAttachments: documentLink: string * ?options: FeedOptions -> QueryIterator<AttachmentMeta>
    /// <summary>Read a collection.</summary>
    /// <param name="collectionLink">- The self-link of the collection.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract readCollection: collectionLink: string * options: RequestOptions * callback: RequestCallback<CollectionMeta> -> unit
    abstract readCollection: collectionLink: string * callback: RequestCallback<CollectionMeta> -> unit
    /// <summary>Get all collections in this database.</summary>
    /// <param name="databaseLink">- The self-link of the database.</param>
    /// <param name="options">- The feed options.</param>
    abstract readCollections: databaseLink: string * ?options: FeedOptions -> QueryIterator<CollectionMeta>
    /// <summary>Read a conflict.</summary>
    /// <param name="conflictLink">- The self-link of the conflict.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract readConflict: conflictLink: string * options: RequestOptions * callback: RequestCallback<obj option> -> unit
    abstract readConflict: conflictLink: string * callback: RequestCallback<obj option> -> unit
    /// <summary>Get all conflicts in this collection.</summary>
    /// <param name="collectionLink">- The self-link of the collection.</param>
    /// <param name="options">- The feed options.</param>
    abstract readConflicts: collectionLink: string * ?options: FeedOptions -> QueryIterator<obj option>
    /// <summary>Read a database.</summary>
    /// <param name="databaseLink">- The self-link of the database.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract readDatabase: databaseLink: string * options: RequestOptions * callback: RequestCallback<DatabaseMeta> -> unit
    abstract readDatabase: databaseLink: string * callback: RequestCallback<DatabaseMeta> -> unit
    /// <summary>List all databases.</summary>
    /// <param name="options">- The request options.</param>
    abstract readDatabases: ?options: FeedOptions -> QueryIterator<DatabaseMeta>
    /// <summary>Read a document.</summary>
    /// <param name="documentLink">- The self-link of the document.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract readDocument: documentLink: string * options: RequestOptions * callback: RequestCallback<RetrievedDocument> -> unit
    abstract readDocument: documentLink: string * callback: RequestCallback<RetrievedDocument> -> unit
    /// <summary>Get all documents in this collection.</summary>
    /// <param name="collectionLink">- The self-link of the collection.</param>
    /// <param name="options">- The feed options.</param>
    abstract readDocuments: collectionLink: string * ?options: FeedOptions -> QueryIterator<RetrievedDocument>
    /// <summary>Read the media for the attachment object.</summary>
    /// <param name="mediaLink">- The media link of the media in the attachment.</param>
    /// <param name="callback">- The callback for the request, the result parameter can be a buffer or a stream depending on the value of MediaReadMode</param>
    // abstract readMedia: mediaLink: string * callback: RequestCallback<U2<Buffer, NodeJS.ReadableStream>> -> unit
    /// <summary>Read an offer.</summary>
    /// <param name="offerLink">- The self-link of the offer.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract readOffer: offerLink: string * callback: RequestCallback<obj option> -> unit
    /// <summary>List all offers</summary>
    /// <param name="options">- The feed options.</param>
    abstract readOffers: ?options: FeedOptions -> QueryIterator<ResizeArray<obj option>>
    /// <summary>Read a permission.</summary>
    /// <param name="permissionLink">- The self-link of the permission.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract readPermission: permissionLink: string * options: RequestOptions * callback: RequestCallback<PermissionMeta> -> unit
    abstract readPermission: permissionLink: string * callback: RequestCallback<PermissionMeta> -> unit
    /// <summary>Get all permissions for this user.</summary>
    /// <param name="userLink">- The self-link of the user.</param>
    /// <param name="feedOptions">- The feed options</param>
    abstract readPermissions: userLink: string * ?feedOptions: FeedOptions -> QueryIterator<PermissionMeta>
    /// <summary>Read a stored procedure</summary>
    /// <param name="sprocLink">- The self-link of the stored procedure.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract readStoredProcedure: sprocLink: string * options: RequestOptions * callback: RequestCallback<ProcedureMeta> -> unit
    abstract readStoredProcedure: sprocLink: string * callback: RequestCallback<ProcedureMeta> -> unit
    /// <summary>Get all StoredProcedures in this collection.</summary>
    /// <param name="collectionLink">- The self-link of the collection.</param>
    /// <param name="options">- The feed options.</param>
    abstract readStoredProcedures: collectionLink: string * ?options: RequestOptions -> QueryIterator<ProcedureMeta>
    /// <summary>Reads a trigger object.</summary>
    /// <param name="triggerLink">- The self-link of the trigger.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract readTrigger: triggerLink: string * options: RequestOptions * callback: RequestCallback<TriggerMeta> -> unit
    abstract readTrigger: triggerLink: string * callback: RequestCallback<TriggerMeta> -> unit
    /// <summary>Get all triggers in this collection.</summary>
    /// <param name="collectionLink">- The self-link of the collection.</param>
    /// <param name="options">- The feed options.</param>
    abstract readTriggers: collectionLink: string * ?options: FeedOptions -> QueryIterator<TriggerMeta>
    /// <summary>Reads a user.</summary>
    /// <param name="userLink">- The self-link of the user.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract readUser: userLink: string * options: RequestOptions * callback: RequestCallback<AbstractMeta> -> unit
    abstract readUser: userLink: string * callback: RequestCallback<AbstractMeta> -> unit
    /// <summary>Reads a udf object.</summary>
    /// <param name="udfLink">- The self-link of the user defined function.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract readUserDefinedFunction: udfLink: string * options: RequestOptions * callback: RequestCallback<UserDefinedFunctionMeta> -> unit
    abstract readUserDefinedFunction: udfLink: string * callback: RequestCallback<UserDefinedFunctionMeta> -> unit
    /// <summary>Get all UserDefinedFunctions in this collection.</summary>
    /// <param name="collectionLink">- The self-link of the collection.</param>
    /// <param name="options">- The feed options.</param>
    abstract readUserDefinedFunctions: collectionLink: string * ?options: FeedOptions -> QueryIterator<UserDefinedFunctionMeta>
    /// <summary>Get all users in this database.</summary>
    /// <param name="databaseLink">- The self-link of the database.</param>
    /// <param name="feedOptions">- The feed options.</param>
    abstract readUsers: databaseLink: string * ?feedOptions: FeedOptions -> QueryIterator<ResizeArray<AbstractMeta>>
    /// <summary>Update media for the attachment</summary>
    /// <param name="mediaLink">- The media link of the media in the attachment.</param>
    /// <param name="readableStream">- The stream that represents the media itself that needs to be uploaded.</param>
    /// <param name="options">- options for the media</param>
    /// <param name="callback">- The callback for the request.</param>
    // abstract updateMedia: mediaLink: string * readableStream: NodeJS.ReadableStream * options: MediaOptions * callback: RequestCallback<obj option> -> unit
    // abstract updateMedia: mediaLink: string * readableStream: NodeJS.ReadableStream * callback: RequestCallback<obj option> -> unit
    /// <summary>Upsert an attachment for the document object.
    /// <p>
    ///   Each document may contain zero or more attachments. Attachments can be of any MIME type - text, image, binary data.
    ///   These are stored externally in Azure Blob storage. Attachments are automatically deleted when the parent document is deleted.
    /// </p></summary>
    /// <param name="documentLink">- The self-link of the document.</param>
    /// <param name="body">- The metadata the defines the attachment media like media, contentType. It can include any other properties as part of the metedata.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract upsertAttachment: documentLink: string * body: Attachment * options: RequestOptions * callback: RequestCallback<AttachmentMeta> -> unit
    abstract upsertAttachment: documentLink: string * body: Attachment * callback: RequestCallback<AttachmentMeta> -> unit
    /// <summary>Upsert an attachment for the document object.</summary>
    /// <param name="documentLink">- The self-link of the document.</param>
    /// <param name="readableStream">- the stream that represents the media itself that needs to be uploaded.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    // abstract upsertAttachmentAndUploadMedia: documentLink: string * readableStream: NodeJS.ReadableStream * options: MediaOptions * callback: RequestCallback<obj option> -> unit
    // abstract upsertAttachmentAndUploadMedia: documentLink: string * readableStream: NodeJS.ReadableStream * callback: RequestCallback<obj option> -> unit
    /// <summary>Upsert a document.
    /// <p>
    ///   There is no set schema for JSON documents. They may contain any number of custom properties as well as an optional list of attachments.
    ///   A Document is an application resource and can be authorized using the master key or resource keys
    /// </p></summary>
    /// <param name="documentsFeedOrDatabaseLink">- The collection link or database link if using a partition resolver</param>
    /// <param name="body">- Represents the body of the document. Can contain any number of user defined properties.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract upsertDocument: documentsFeedOrDatabaseLink: string * body: NewDocument * options: DocumentOptions * callback: RequestCallback<RetrievedDocument> -> unit
    abstract upsertDocument: documentsFeedOrDatabaseLink: string * body: NewDocument * callback: RequestCallback<RetrievedDocument> -> unit
    /// <summary>Upsert a permission.
    /// <p>
    ///   A permission represents a per-User Permission to access a specific resource e.g. Document or Collection.
    /// </p></summary>
    /// <param name="userLink">- The self-link of the user.</param>
    /// <param name="body">- Represents the body of the permission.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract upsertPermission: userLink: string * body: Permission * options: RequestOptions * callback: RequestCallback<PermissionMeta> -> unit
    abstract upsertPermission: userLink: string * body: Permission * callback: RequestCallback<PermissionMeta> -> unit
    /// <summary>Upsert a StoredProcedure.
    /// <p>
    ///   DocumentDB allows stored procedures to be executed in the storage tier, directly against a document collection. The script
    ///   gets executed under ACID transactions on the primary storage partition of the specified collection. For additional details,
    ///   refer to the server-side JavaScript API documentation.
    /// </p></summary>
    /// <param name="collectionLink">- The self-link of the collection.</param>
    /// <param name="sproc">- Represents the body of the stored procedure.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract upsertStoredProcedure: collectionLink: string * sproc: Procedure * options: RequestOptions * callback: RequestCallback<ProcedureMeta> -> unit
    abstract upsertStoredProcedure: collectionLink: string * sproc: Procedure * callback: RequestCallback<ProcedureMeta> -> unit
    /// <summary>Upsert a trigger.
    /// <p>
    ///   DocumentDB supports pre and post triggers defined in JavaScript to be executed on creates, updates and deletes.
    ///   For additional details, refer to the server-side JavaScript API documentation.
    /// </p></summary>
    /// <param name="collectionLink">- The self-link of the collection.</param>
    /// <param name="trigger">- Represents the body of the trigger.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract upsertTrigger: collectionLink: string * trigger: Trigger * options: RequestOptions * callback: RequestCallback<TriggerMeta> -> unit
    abstract upsertTrigger: collectionLink: string * trigger: Trigger * callback: RequestCallback<TriggerMeta> -> unit
    /// <summary>Upsert a database user.</summary>
    /// <param name="databaseLink">- The self-link of the database.</param>
    /// <param name="body">- Represents the body of the user.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract upsertUser: databaseLink: string * body: UniqueId * options: RequestOptions * callback: RequestCallback<AbstractMeta> -> unit
    abstract upsertUser: databaseLink: string * body: UniqueId * callback: RequestCallback<AbstractMeta> -> unit
    /// <summary>Upsert a UserDefinedFunction.
    /// <p>
    ///   DocumentDB supports JavaScript UDFs which can be used inside queries, stored procedures and triggers.
    ///   For additional details, refer to the server-side JavaScript API documentation.
    /// </p></summary>
    /// <param name="collectionLink">- The self-link of the collection.</param>
    /// <param name="udf">- Represents the body of the userDefinedFunction.</param>
    /// <param name="options">- The request options.</param>
    /// <param name="callback">- The callback for the request.</param>
    abstract upsertUserDefinedFunction: collectionLink: string * udf: UserDefinedFunction * options: RequestOptions * callback: RequestCallback<UserDefinedFunctionMeta> -> unit
    abstract upsertUserDefinedFunction: collectionLink: string * udf: UserDefinedFunction * callback: RequestCallback<UserDefinedFunctionMeta> -> unit
    /// <summary>Gets the Database account information.</summary>
    /// <param name="options">- The request options</param>
    /// <param name="callback">- The callback for the request</param>
    abstract getDatabaseAccount: options: DatabaseAccountRequestOptions * callback: RequestCallback<DatabaseAccount> -> unit
    abstract getDatabaseAccount: callback: RequestCallback<DatabaseAccount> -> unit
    /// <summary>Gets the curent read endpoint for a geo-replicated database account.</summary>
    /// <param name="callback">- The callback for the request</param>
    abstract getReadEndpoint: callback: RequestCallback<string> -> unit
    /// <summary>Gets the curent write endpoint for a geo-replicated database account.</summary>
    /// <param name="callback">- The callback for the request</param>
    abstract getWriteEndpoint: callback: RequestCallback<string> -> unit

/// Provides a client-side logical representation of the Azure DocumentDB database account. This client is used to configure and execute requests against the service.
type [<AllowNullLiteral>] DocumentClientStatic =
    /// <summary>Constructs a DocumentClient.</summary>
    /// <param name="urlConnection">- The service endpoint to use to create the client.</param>
    /// <param name="auth">- An object that is used for authenticating requests and must contains one of the options.</param>
    /// <param name="connectionPolicy">- An instance of {</param>
    /// <param name="consistencyLevel">- An optional parameter that represents the consistency level. It can take any value from {</param>
    [<Emit "new $0($1...)">] abstract Create: urlConnection: string * auth: AuthOptions * ?connectionPolicy: ConnectionPolicy * ?consistencyLevel: ConsistencyLevel -> DocumentClient

module UriFactory =

    type [<AllowNullLiteral>] IExports =
        /// <summary>Given a database id, this creates a database link.</summary>
        /// <param name="databaseId">-The database id</param>
        abstract createDatabaseUri: databaseId: string -> string
        /// <summary>Given a database and collection id, this creates a collection link.</summary>
        /// <param name="databaseId">-The database id</param>
        /// <param name="collectionId">-The collection id</param>
        abstract createDocumentCollectionUri: databaseId: string * collectionId: string -> string
        /// <summary>Given a database and collection id, this creates a collection link.</summary>
        /// <param name="databaseId">-The database id</param>
        /// <param name="collectionId">-The collection id</param>
        /// <param name="documentId">-The document id</param>
        // abstract createDocumentUri: databaseId: string * collectionId: string * documentId: string -> string
        /// <summary>Given a database, collection and document id, this creates a document link.</summary>
        /// <param name="databaseId">-The database Id</param>
        /// <param name="userId">-The user Id</param>
        /// <param name="permissionId">- The permissionId</param>
        // abstract createPermissionUri: databaseId: string * userId: string * permissionId: string -> string
        /// <summary>Given a database, collection and stored proc id, this creates a stored proc link.</summary>
        /// <param name="databaseId">-The database Id</param>
        /// <param name="collectionId">-The collection Id</param>
        /// <param name="storedProcedureId">-The stored procedure Id</param>
        // abstract createStoredProcedureUri: databaseId: string * collectionId: string * storedProcedureId: string -> string
        /// <param name="databaseId">-The database Id</param>
        /// <param name="collectionId">-The collection Id</param>
        /// <param name="triggerId">-The trigger Id</param>
        // abstract createTriggerUri: databaseId: string * collectionId: string * triggerId: string -> string
        /// <param name="databaseId">-The database Id</param>
        /// <param name="collectionId">-The collection Id</param>
        /// <param name="udfId">-The User Defined Function Id</param>
        // abstract createUserDefinedFunctionUri: databaseId: string * collectionId: string * udfId: string -> string
        /// <param name="databaseId">-The database Id</param>
        /// <param name="collectionId">-The collection Id</param>
        /// <param name="conflictId">-The conflict Id</param>
        // abstract createConflictUri: databaseId: string * collectionId: string * conflictId: string -> string
        /// <param name="databaseId">-The database Id</param>
        /// <param name="collectionId">-The collection Id</param>
        /// <param name="documentId">-The document Id\</param>
        /// <param name="attachmentId">-The attachment Id</param>
        // abstract createAttachmentUri: databaseId: string * collectionId: string * documentId: string * attachmentId: string -> string
        /// <param name="databaseId">-The database Id</param>
        /// <param name="collectionId">-The collection Id</param>
        abstract createPartitionKeyRangesUri: databaseId: string * collectionId: string -> string

type [<StringEnum>] [<RequireQualifiedAccess>] MediaReadMode =
    | [<CompiledName "Buffered">] Buffered
    | [<CompiledName "Streamed">] Streamed

type [<StringEnum>] [<RequireQualifiedAccess>] ConsistencyLevel =
    | [<CompiledName "Strong">] Strong
    | [<CompiledName "BoundedStaleness">] BoundedStaleness
    | [<CompiledName "Session">] Session
    | [<CompiledName "Eventual">] Eventual

type [<StringEnum>] [<RequireQualifiedAccess>] IndexingMode =
    | [<CompiledName "Consistent">] Consistent
    | [<CompiledName "Lazy">] Lazy

type [<StringEnum>] [<RequireQualifiedAccess>] IndexKind =
    | [<CompiledName "Hash">] Hash
    | [<CompiledName "Range">] Range
    | [<CompiledName "Spatial">] Spatial

type [<StringEnum>] [<RequireQualifiedAccess>] PermissionMode =
    | [<CompiledName "None">] None
    | [<CompiledName "Read">] Read
    | [<CompiledName "All">] All

type [<StringEnum>] [<RequireQualifiedAccess>] TriggerType =
    | [<CompiledName "Pre">] Pre
    | [<CompiledName "Post">] Post
    // | Pre
    // | Post

type [<StringEnum>] [<RequireQualifiedAccess>] TriggerOperation =
    | [<CompiledName "All">] All
    | [<CompiledName "Create">] Create
    | [<CompiledName "Update">] Update
    | [<CompiledName "Delete">] Delete
    | [<CompiledName "Replace">] Replace
    // | All
    // | Create
    // | Update
    // | Delete
    // | Replace

type UserDefinedFunctionType =
    string

type PartitionKind =
    string
