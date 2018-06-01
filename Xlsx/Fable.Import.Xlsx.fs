// ts2fable 0.5.2
module rec Fable.Import.Xlsx
open System
open Fable.Core
open Fable.Import.JS

// module CFB = Cfb
// module SSF = Ssf

type [<AllowNullLiteral>] IExports =
    abstract version: string
    /// NODE ONLY! Attempts to read filename and parse
    abstract readFile: filename: string * ?opts: ParsingOptions -> WorkBook
    /// Attempts to parse data
    abstract read: data: obj option * ?opts: ParsingOptions -> WorkBook
    /// Attempts to write or download workbook data to file
    abstract writeFile: data: WorkBook * filename: string * ?opts: WritingOptions -> obj option
    /// Attempts to write the workbook data
    abstract write: data: WorkBook * ?opts: WritingOptions -> obj option
    abstract utils: Utils
    abstract stream: StreamUtils

type NumberFormat =
    U2<string, float>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module NumberFormat =
    let ofString v: NumberFormat = v |> U2.Case1
    let isString (v: NumberFormat) = match v with U2.Case1 _ -> true | _ -> false
    let asString (v: NumberFormat) = match v with U2.Case1 o -> Some o | _ -> None
    let ofFloat v: NumberFormat = v |> U2.Case2
    let isFloat (v: NumberFormat) = match v with U2.Case2 _ -> true | _ -> false
    let asFloat (v: NumberFormat) = match v with U2.Case2 o -> Some o | _ -> None

/// Basic File Properties
type [<AllowNullLiteral>] Properties =
    /// Summary tab "Title"
    abstract Title: string option with get, set
    /// Summary tab "Subject"
    abstract Subject: string option with get, set
    /// Summary tab "Author"
    abstract Author: string option with get, set
    /// Summary tab "Manager"
    abstract Manager: string option with get, set
    /// Summary tab "Company"
    abstract Company: string option with get, set
    /// Summary tab "Category"
    abstract Category: string option with get, set
    /// Summary tab "Keywords"
    abstract Keywords: string option with get, set
    /// Summary tab "Comments"
    abstract Comments: string option with get, set
    /// Statistics tab "Last saved by"
    abstract LastAuthor: string option with get, set
    /// Statistics tab "Created"
    abstract CreatedDate: DateTime option with get, set

/// Other supported properties
type [<AllowNullLiteral>] FullProperties =
    inherit Properties
    abstract ModifiedDate: DateTime option with get, set
    abstract Application: string option with get, set
    abstract AppVersion: string option with get, set
    abstract DocSecurity: string option with get, set
    abstract HyperlinksChanged: bool option with get, set
    abstract SharedDoc: bool option with get, set
    abstract LinksUpToDate: bool option with get, set
    abstract ScaleCrop: bool option with get, set
    abstract Worksheets: float option with get, set
    abstract SheetNames: ResizeArray<string> option with get, set
    abstract ContentStatus: string option with get, set
    abstract LastPrinted: string option with get, set
    abstract Revision: U2<string, float> option with get, set
    abstract Version: string option with get, set
    abstract Identifier: string option with get, set
    abstract Language: string option with get, set

type [<AllowNullLiteral>] CommonOptions =
    /// If true, throw errors when features are not understood
    abstract WTF: bool option with get, set
    /// When reading a file with VBA macros, expose CFB blob to `vbaraw` field
    /// When writing BIFF8/XLSB/XLSM, reseat `vbaraw` and export to file
    abstract bookVBA: bool option with get, set
    /// When reading a file, store dates as type d (default is n)
    /// When writing XLSX/XLSM file, use native date (default uses date codes)
    abstract cellDates: bool option with get, set
    /// When reading a file, save style/theme info to the .s field
    /// When writing a file, export style/theme info
    abstract cellStyles: bool option with get, set

type [<AllowNullLiteral>] DateNFOption =
    /// Use specified date format
    abstract dateNF: NumberFormat option with get, set

/// Options for read and readFile
type [<AllowNullLiteral>] ParsingOptions =
    inherit CommonOptions
    /// Input data encoding
    abstract ``type``: U6<string, string, string, string, string, string> option with get, set
    /// Default codepage
    abstract codepage: float option with get, set
    /// Save formulae to the .f field
    abstract cellFormula: bool option with get, set
    /// Parse rich text and save HTML to the .h field
    abstract cellHTML: bool option with get, set
    /// Save number format string to the .z field
    abstract cellNF: bool option with get, set
    /// Generate formatted text to the .w field
    abstract cellText: bool option with get, set
    /// Override default date format (code 14)
    abstract dateNF: string option with get, set
    /// Create cell objects for stub cells
    abstract sheetStubs: bool option with get, set
    /// If >0, read the first sheetRows rows
    abstract sheetRows: float option with get, set
    /// If true, parse calculation chains
    abstract bookDeps: bool option with get, set
    /// If true, add raw files to book object
    abstract bookFiles: bool option with get, set
    /// If true, only parse enough to get book metadata
    abstract bookProps: bool option with get, set
    /// If true, only parse enough to get the sheet names
    abstract bookSheets: bool option with get, set
    /// If defined and file is encrypted, use password
    abstract password: string option with get, set
    abstract raw: bool option with get, set
    abstract dense: bool option with get, set

/// Options for write and writeFile
type [<AllowNullLiteral>] WritingOptions =
    inherit CommonOptions
    /// Output data encoding
    abstract ``type``: U6<string, string, string, string, string, string> option with get, set
    /// Generate Shared String Table
    abstract bookSST: bool option with get, set
    /// File format of generated workbook
    // abstract bookType: BookType option with get, set
    /// Name of Worksheet (for single-sheet formats)
    abstract sheet: string option with get, set
    /// Use ZIP compression for ZIP-based formats
    abstract compression: bool option with get, set
    /// Override workbook properties on save
    abstract Props: Properties option with get, set

/// Workbook Object
type [<AllowNullLiteral>] WorkBook =
    /// A dictionary of the worksheets in the workbook.
    /// Use SheetNames to reference these.
    abstract Sheets: obj with get, set
    /// Ordered list of the sheet names in the workbook
    abstract SheetNames: ResizeArray<string> with get, set
    /// an object storing the standard properties. wb.Custprops stores custom properties.
    /// Since the XLS standard properties deviate from the XLSX standard, XLS parsing stores core properties in both places.
    abstract Props: FullProperties option with get, set
    abstract Workbook: WBProps option with get, set
    abstract vbaraw: obj option option with get, set

type [<AllowNullLiteral>] SheetProps =
    /// Sheet Visibility (0=Visible 1=Hidden 2=VeryHidden)
    abstract Hidden: obj option with get, set
    /// Name of Document Module in associated VBA Project
    abstract CodeName: string option with get, set

/// Defined Name Object
type [<AllowNullLiteral>] DefinedName =
    /// Name
    abstract Name: string with get, set
    /// Reference
    abstract Ref: string with get, set
    /// Scope (undefined for workbook scope)
    abstract Sheet: float option with get, set
    /// Name comment
    abstract Comment: string option with get, set

/// Workbook-Level Attributes
type [<AllowNullLiteral>] WBProps =
    /// Sheet Properties
    abstract Sheets: ResizeArray<SheetProps> option with get, set
    /// Defined Names
    abstract Names: ResizeArray<DefinedName> option with get, set
    /// Workbook Views
    abstract Views: ResizeArray<WBView> option with get, set
    /// Other Workbook Properties
    abstract WBProps: WorkbookProperties option with get, set

/// Workbook View
type [<AllowNullLiteral>] WBView =
    /// Right-to-left mode
    abstract RTL: bool option with get, set

/// Other Workbook Properties
type [<AllowNullLiteral>] WorkbookProperties =
    /// Worksheet Epoch (1904 if true, 1900 if false)
    abstract date1904: bool option with get, set
    /// Warn or strip personally identifying info on save
    abstract filterPrivacy: bool option with get, set
    /// Name of Document Module in associated VBA Project
    abstract CodeName: string option with get, set

/// Column Properties Object
type [<AllowNullLiteral>] ColInfo =
    /// if true, the column is hidden
    abstract hidden: bool option with get, set
    /// width in Excel's "Max Digit Width", width*256 is integral
    abstract width: float option with get, set
    /// width in screen pixels
    abstract wpx: float option with get, set
    /// width in "characters"
    abstract wch: float option with get, set
    /// Excel's "Max Digit Width" unit, always integral
    abstract MDW: float option with get, set

/// Row Properties Object
type [<AllowNullLiteral>] RowInfo =
    /// if true, the column is hidden
    abstract hidden: bool option with get, set
    /// height in screen pixels
    abstract hpx: float option with get, set
    /// height in points
    abstract hpt: float option with get, set
    /// outline / group level
    abstract level: float option with get, set

/// Write sheet protection properties.
type [<AllowNullLiteral>] ProtectInfo =
    /// The password for formats that support password-protected sheets
    /// (XLSX/XLSB/XLS). The writer uses the XOR obfuscation method.
    abstract password: string option with get, set
    /// Select locked cells
    abstract selectLockedCells: bool option with get, set
    /// Select unlocked cells
    abstract selectUnlockedCells: bool option with get, set
    /// Format cells
    abstract formatCells: bool option with get, set
    /// Format columns
    abstract formatColumns: bool option with get, set
    /// Format rows
    abstract formatRows: bool option with get, set
    /// Insert columns
    abstract insertColumns: bool option with get, set
    /// Insert rows
    abstract insertRows: bool option with get, set
    /// Insert hyperlinks
    abstract insertHyperlinks: bool option with get, set
    /// Delete columns
    abstract deleteColumns: bool option with get, set
    /// Delete rows
    abstract deleteRows: bool option with get, set
    /// Sort
    abstract sort: bool option with get, set
    /// Filter
    abstract autoFilter: bool option with get, set
    /// Use PivotTable reports
    abstract pivotTables: bool option with get, set
    /// Edit objects
    abstract objects: bool option with get, set
    /// Edit scenarios
    abstract scenarios: bool option with get, set

/// Page Margins -- see Excel Page Setup .. Margins diagram for explanation
type [<AllowNullLiteral>] MarginInfo =
    /// Left side margin (inches)
    abstract left: float option with get, set
    /// Right side margin (inches)
    abstract right: float option with get, set
    /// Top side margin (inches)
    abstract top: float option with get, set
    /// Bottom side margin (inches)
    abstract bottom: float option with get, set
    /// Header top margin (inches)
    abstract header: float option with get, set
    /// Footer bottom height (inches)
    abstract footer: float option with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] SheetType =
    | Sheet
    | Chart

type SheetKeys =
    U3<string, MarginInfo, SheetType>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module SheetKeys =
    let ofString v: SheetKeys = v |> U3.Case1
    let isString (v: SheetKeys) = match v with U3.Case1 _ -> true | _ -> false
    let asString (v: SheetKeys) = match v with U3.Case1 o -> Some o | _ -> None
    let ofMarginInfo v: SheetKeys = v |> U3.Case2
    let isMarginInfo (v: SheetKeys) = match v with U3.Case2 _ -> true | _ -> false
    let asMarginInfo (v: SheetKeys) = match v with U3.Case2 o -> Some o | _ -> None
    let ofSheetType v: SheetKeys = v |> U3.Case3
    let isSheetType (v: SheetKeys) = match v with U3.Case3 _ -> true | _ -> false
    let asSheetType (v: SheetKeys) = match v with U3.Case3 o -> Some o | _ -> None

/// General object representing a Sheet (worksheet or chartsheet)
type [<AllowNullLiteral>] Sheet =
    /// Indexing with a cell address string maps to a cell object
    /// Special keys start with '!'
    [<Emit "$0[$1]{{=$2}}">] abstract Item: cell: string -> U3<CellObject, SheetKeys, obj option> with get, set
    /// Sheet type
    // abstract !type: SheetType option with get, set
    /// Sheet Range
    // abstract !ref: string option with get, set
    /// Page Margins
    // abstract !margins: MarginInfo option with get, set

/// AutoFilter properties
type [<AllowNullLiteral>] AutoFilterInfo =
    /// Range of the AutoFilter table
    abstract ref: string with get, set

type WSKeys =
    U6<SheetKeys, ResizeArray<ColInfo>, ResizeArray<RowInfo>, ResizeArray<Range>, ProtectInfo, AutoFilterInfo>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module WSKeys =
    let ofSheetKeys v: WSKeys = v |> U6.Case1
    let isSheetKeys (v: WSKeys) = match v with U6.Case1 _ -> true | _ -> false
    let asSheetKeys (v: WSKeys) = match v with U6.Case1 o -> Some o | _ -> None
    let ofColInfoArray v: WSKeys = v |> U6.Case2
    let isColInfoArray (v: WSKeys) = match v with U6.Case2 _ -> true | _ -> false
    let asColInfoArray (v: WSKeys) = match v with U6.Case2 o -> Some o | _ -> None
    let ofRowInfoArray v: WSKeys = v |> U6.Case3
    let isRowInfoArray (v: WSKeys) = match v with U6.Case3 _ -> true | _ -> false
    let asRowInfoArray (v: WSKeys) = match v with U6.Case3 o -> Some o | _ -> None
    let ofRangeArray v: WSKeys = v |> U6.Case4
    let isRangeArray (v: WSKeys) = match v with U6.Case4 _ -> true | _ -> false
    let asRangeArray (v: WSKeys) = match v with U6.Case4 o -> Some o | _ -> None
    let ofProtectInfo v: WSKeys = v |> U6.Case5
    let isProtectInfo (v: WSKeys) = match v with U6.Case5 _ -> true | _ -> false
    let asProtectInfo (v: WSKeys) = match v with U6.Case5 o -> Some o | _ -> None
    let ofAutoFilterInfo v: WSKeys = v |> U6.Case6
    let isAutoFilterInfo (v: WSKeys) = match v with U6.Case6 _ -> true | _ -> false
    let asAutoFilterInfo (v: WSKeys) = match v with U6.Case6 o -> Some o | _ -> None

/// Worksheet Object
type [<AllowNullLiteral>] WorkSheet =
    inherit Sheet
    /// Indexing with a cell address string maps to a cell object
    /// Special keys start with '!'
    [<Emit "$0[$1]{{=$2}}">] abstract Item: cell: string -> U3<CellObject, WSKeys, obj option> with get, set
    /// Column Info
    // abstract !cols: ResizeArray<ColInfo> option with get, set
    /// Row Info
    // abstract !rows: ResizeArray<RowInfo> option with get, set
    /// Merge Ranges
    // abstract !merges: ResizeArray<Range> option with get, set
    /// Worksheet Protection info
    // abstract !protect: ProtectInfo option with get, set
    /// AutoFilter info
    // abstract !autofilter: AutoFilterInfo option with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] ExcelDataType =
    | B
    | N
    | E
    | S
    | D
    | Z

type [<StringEnum>] [<RequireQualifiedAccess>] BookType =
    | Xlsx
    | Xlsm
    | Xlsb
    | Xls
    | Xla
    | Biff8
    | Biff5
    | Biff2
    | Xlml
    | Ods
    | Fods
    | Csv
    | Txt
    | Sylk
    | Html
    | Dif
    | Rtf
    | Prn
    | Eth

/// Comment element
type [<AllowNullLiteral>] Comment =
    /// Author of the comment block
    abstract a: string option with get, set
    /// Plaintext of the comment
    abstract t: string with get, set

/// Link object
type [<AllowNullLiteral>] Hyperlink =
    /// Target of the link (HREF)
    abstract Target: string with get, set
    /// Plaintext tooltip to display when mouse is over cell
    abstract Tooltip: string option with get, set

/// Worksheet Cell Object
type [<AllowNullLiteral>] CellObject =
    /// The raw value of the cell.  Can be omitted if a formula is specified
    abstract v: U4<string, float, bool, DateTime> option with get, set
    /// Formatted text (if applicable)
    abstract w: string option with get, set
    /// The Excel Data Type of the cell.
    /// b Boolean, n Number, e Error, s String, d Date, z Empty
    abstract t: ExcelDataType with get, set
    /// Cell formula (if applicable)
    abstract f: string option with get, set
    /// Range of enclosing array if formula is array formula (if applicable)
    abstract F: string option with get, set
    /// Rich text encoding (if applicable)
    abstract r: obj option option with get, set
    /// HTML rendering of the rich text (if applicable)
    abstract h: string option with get, set
    /// Comments associated with the cell
    abstract c: ResizeArray<Comment> option with get, set
    /// Number format string associated with the cell (if requested)
    abstract z: NumberFormat option with get, set
    /// Cell hyperlink object (.Target holds link, .tooltip is tooltip)
    abstract l: Hyperlink option with get, set
    /// The style/theme of the cell (if applicable)
    abstract s: obj option option with get, set

/// Simple Cell Address
type [<AllowNullLiteral>] CellAddress =
    /// Column number
    abstract c: float with get, set
    /// Row number
    abstract r: float with get, set

/// Range object (representing ranges like "A1:B2")
type [<AllowNullLiteral>] Range =
    /// Starting cell
    abstract s: CellAddress with get, set
    /// Ending cell
    abstract e: CellAddress with get, set

type [<AllowNullLiteral>] Sheet2CSVOpts =
    inherit DateNFOption
    /// Field Separator ("delimiter")
    abstract FS: string option with get, set
    /// Record Separator ("row separator")
    abstract RS: string option with get, set
    /// Remove trailing field separators in each record
    abstract strip: bool option with get, set
    /// Include blank lines in the CSV output
    abstract blankrows: bool option with get, set
    /// Skip hidden rows and columns in the CSV output
    abstract skipHidden: bool option with get, set

type [<AllowNullLiteral>] OriginOption =
    /// Top-Left cell for operation (CellAddress or A1 string or row)
    abstract origin: U3<float, string, CellAddress> option with get, set

type [<AllowNullLiteral>] Sheet2HTMLOpts =
    /// TABLE element id attribute
    abstract id: string option with get, set
    /// Add contenteditable to every cell
    abstract editable: bool option with get, set
    /// Header HTML
    abstract header: string option with get, set
    /// Footer HTML
    abstract footer: string option with get, set

type [<AllowNullLiteral>] Sheet2JSONOpts =
    inherit DateNFOption
    /// Output format
    abstract header: U3<string, float, ResizeArray<string>> option with get, set
    /// Override worksheet range
    abstract range: obj option option with get, set
    /// Include or omit blank lines in the output
    abstract blankrows: bool option with get, set
    /// Default value for null/undefined values
    abstract defval: obj option option with get, set
    /// if true, return raw data; if false, return formatted text
    abstract raw: bool option with get, set

type [<AllowNullLiteral>] AOA2SheetOpts =
    inherit CommonOptions
    inherit DateNFOption
    /// Create cell objects for stub cells
    abstract sheetStubs: bool option with get, set

type [<AllowNullLiteral>] SheetAOAOpts =
    inherit AOA2SheetOpts
    inherit OriginOption

type [<AllowNullLiteral>] JSON2SheetOpts =
    inherit CommonOptions
    inherit DateNFOption
    /// Use specified column order
    abstract header: ResizeArray<string> option with get, set
    /// Skip header row in generated sheet
    abstract skipHeader: bool option with get, set

type [<AllowNullLiteral>] SheetJSONOpts =
    inherit JSON2SheetOpts
    inherit OriginOption

type [<AllowNullLiteral>] Table2SheetOpts =
    inherit CommonOptions
    inherit DateNFOption
    abstract raw: bool option with get, set
    /// If >0, read the first sheetRows rows
    abstract sheetRows: float option with get, set

/// General utilities
type [<AllowNullLiteral>] ``Utils`` =
//     /// Converts an array of arrays of JS data to a worksheet.
//     abstract aoa_to_sheet: data: ResizeArray<ResizeArray<'T>> * ?opts: AOA2SheetOpts -> WorkSheet
//     abstract aoa_to_sheet: data: ResizeArray<ResizeArray<obj option>> * ?opts: AOA2SheetOpts -> WorkSheet
//     /// Converts an array of JS objects to a worksheet.
//     abstract json_to_sheet: data: ResizeArray<'T> * ?opts: JSON2SheetOpts -> WorkSheet
//     abstract json_to_sheet: data: ResizeArray<obj option> * ?opts: JSON2SheetOpts -> WorkSheet
//     /// BROWSER ONLY! Converts a TABLE DOM element to a worksheet.
//     abstract table_to_sheet: data: obj option * ?opts: Table2SheetOpts -> WorkSheet
//     abstract table_to_book: data: obj option * ?opts: Table2SheetOpts -> WorkBook
//     /// Converts a worksheet object to an array of JSON objects
    abstract sheet_to_json: worksheet: WorkSheet * ?opts: Sheet2JSONOpts -> ResizeArray<'T>
    // abstract sheet_to_json: worksheet: WorkSheet * ?opts: Sheet2JSONOpts -> ResizeArray<ResizeArray<obj option>>
//     /// Generates delimiter-separated-values output
//     abstract sheet_to_csv: worksheet: WorkSheet * ?options: Sheet2CSVOpts -> string
//     /// Generates UTF16 Formatted Text
//     abstract sheet_to_txt: worksheet: WorkSheet * ?options: Sheet2CSVOpts -> string
//     /// Generates HTML
//     abstract sheet_to_html: worksheet: WorkSheet * ?options: Sheet2HTMLOpts -> string
//     /// Generates a list of the formulae (with value fallbacks)
//     abstract sheet_to_formulae: worksheet: WorkSheet -> ResizeArray<string>
//     /// Generates DIF
//     abstract sheet_to_dif: worksheet: WorkSheet * ?options: Sheet2HTMLOpts -> string
//     /// Generates SYLK (Symbolic Link)
//     abstract sheet_to_slk: worksheet: WorkSheet * ?options: Sheet2HTMLOpts -> string
//     /// Generates ETH
//     abstract sheet_to_eth: worksheet: WorkSheet * ?options: Sheet2HTMLOpts -> string
//     /// Converts 0-indexed cell address to A1 form
//     abstract encode_cell: cell: CellAddress -> string
//     /// Converts 0-indexed row to A1 form
//     abstract encode_row: row: float -> string
//     /// Converts 0-indexed column to A1 form
//     abstract encode_col: col: float -> string
//     /// Converts 0-indexed range to A1 form
//     abstract encode_range: s: CellAddress * e: CellAddress -> string
//     abstract encode_range: r: Range -> string
//     /// Converts A1 cell address to 0-indexed form
//     abstract decode_cell: address: string -> CellAddress
//     /// Converts A1 row to 0-indexed form
//     abstract decode_row: row: string -> float
//     /// Converts A1 column to 0-indexed form
//     abstract decode_col: col: string -> float
//     /// Converts A1 range to 0-indexed form
//     abstract decode_range: range: string -> Range
//     /// Format cell
//     abstract format_cell: cell: CellObject * ?v: obj option * ?opts: obj option -> string
//     /// Creates a new workbook
//     abstract book_new: unit -> WorkBook
//     /// Append a worksheet to a workbook
//     abstract book_append_sheet: workbook: WorkBook * worksheet: WorkSheet * ?name: string -> unit
//     /// Set sheet visibility (visible/hidden/very hidden)
//     abstract book_set_sheet_visibility: workbook: WorkBook * sheet: U2<float, string> * visibility: float -> unit
//     /// Set number format for a cell
//     abstract cell_set_number_format: cell: CellObject * fmt: U2<string, float> -> CellObject
//     /// Set hyperlink for a cell
//     abstract cell_set_hyperlink: cell: CellObject * target: string * ?tooltip: string -> CellObject
//     /// Set internal link for a cell
//     abstract cell_set_internal_link: cell: CellObject * target: string * ?tooltip: string -> CellObject
//     /// Add comment to a cell
//     abstract cell_add_comment: cell: CellObject * text: string * ?author: string -> unit
//     /// Assign an Array Formula to a range
//     abstract sheet_set_array_formula: ws: WorkSheet * range: U2<Range, string> * formula: string -> WorkSheet
//     /// Add an array of arrays of JS data to a worksheet
//     abstract sheet_add_aoa: ws: WorkSheet * data: ResizeArray<ResizeArray<'T>> * ?opts: SheetAOAOpts -> WorkSheet
//     abstract sheet_add_aoa: ws: WorkSheet * data: ResizeArray<ResizeArray<obj option>> * ?opts: SheetAOAOpts -> WorkSheet
//     /// Add an array of JS objects to a worksheet
//     abstract sheet_add_json: ws: WorkSheet * data: ResizeArray<obj option> * ?opts: SheetJSONOpts -> WorkSheet
//     abstract sheet_add_json: ws: WorkSheet * data: ResizeArray<'T> * ?opts: SheetJSONOpts -> WorkSheet
//     abstract consts: ``XLSX$Consts`` with get, set

// type [<AllowNullLiteral>] ``XLSX$Consts`` =
//     /// Visibility: Visible
//     abstract SHEET_VISIBLE: obj with get, set
//     /// Visibility: Hidden
//     abstract SHEET_HIDDEN: obj with get, set
//     /// Visibility: Very Hidden
//     abstract SHEET_VERYHIDDEN: obj with get, set

/// NODE ONLY! these return Readable Streams
type [<AllowNullLiteral>] StreamUtils =
    /// CSV output stream, generate one line at a time
    abstract to_csv: sheet: WorkSheet * ?opts: Sheet2CSVOpts -> obj option
    /// HTML output stream, generate one line at a time
    abstract to_html: sheet: WorkSheet * ?opts: Sheet2HTMLOpts -> obj option
