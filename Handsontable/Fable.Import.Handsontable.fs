// // ts2fable 0.5.2
module rec Fable.Import.Handsontable
open System
open Fable.Core
open Fable.Import.JS
open Fable.Import.Browser

// let [<Import("*","handsontable")>] _Handsontable: _Handsontable.IExports = jsNative

type [<AllowNullLiteral>] IExports =
    abstract Handsontable: HandsontableStatic

module _Handsontable =

    // type [<AllowNullLiteral>] IExports =
    //     abstract Core: CoreStatic

    type [<AllowNullLiteral>] Core =
//         abstract addHook: key: string * callback: U2<(unit -> unit), ResizeArray<obj option>> -> unit
//         abstract addHookOnce: key: string * callback: U2<(unit -> unit), ResizeArray<obj option>> -> unit
//         abstract alter: action: U4<string, string, string, string> * ?index: U2<float, Array<float * float>> * ?amount: float * ?source: string * ?keepEmptyRows: bool -> unit
//         abstract clear: unit -> unit
//         abstract colOffset: unit -> float
//         abstract colToProp: col: float -> U2<string, float>
//         abstract countCols: unit -> float
//         abstract countEmptyCols: ?ending: bool -> float
//         abstract countEmptyRows: ?ending: bool -> float
//         abstract countRenderedCols: unit -> float
//         abstract countRenderedRows: unit -> float
//         abstract countRows: unit -> float
//         abstract countSourceCols: unit -> float
//         abstract countSourceRows: unit -> float
//         abstract countVisibleCols: unit -> float
//         abstract countVisibleRows: unit -> float
//         abstract deselectCell: unit -> unit
//         abstract destroy: unit -> unit
//         abstract destroyEditor: ?revertOriginal: bool -> unit
//         abstract emptySelectedCells: unit -> unit
//         abstract getActiveEditor: unit -> obj
//         abstract getCell: row: float * col: float * ?topmost: bool -> Element
//         abstract getCellEditor: row: float * col: float -> obj
//         abstract getCellMeta: row: float * col: float -> obj
//         abstract getCellMetaAtRow: row: float -> ResizeArray<obj option>
//         abstract getCellRenderer: row: float * col: float -> (unit -> unit)
//         abstract getCellValidator: row: float * col: float -> obj option
//         abstract getColHeader: ?col: float -> U2<ResizeArray<obj option>, string>
//         abstract getColWidth: col: float -> float
//         abstract getCoords: elem: Element -> obj
//         abstract getCopyableData: row: float * column: float -> string
//         abstract getCopyableText: startRow: float * startCol: float * endRow: float * endCol: float -> string
//         abstract getData: ?r: float * ?c: float * ?r2: float * ?c2: float -> ResizeArray<obj option>
        abstract getDataAtCell: row: float * col: float -> obj option
//         abstract getDataAtCol: col: float -> ResizeArray<obj option>
//         abstract getDataAtProp: prop: U2<string, float> -> ResizeArray<obj option>
//         abstract getDataAtRow: row: float -> ResizeArray<obj option>
//         abstract getDataAtRowProp: row: float * prop: string -> obj option
//         abstract getDataType: rowFrom: float * columnFrom: float * rowTo: float * columnTo: float -> string
//         abstract getInstance: unit -> obj option
//         abstract getPlugin: pluginName: string -> obj option
//         abstract getRowHeader: ?row: float -> U2<ResizeArray<obj option>, string>
//         abstract getRowHeight: row: float -> float
//         abstract getSchema: unit -> obj
//         abstract getSelected: unit -> Array<float * float * float * float> option
//         abstract getSelectedLast: unit -> ResizeArray<float> option
//         abstract getSelectedRange: unit -> ResizeArray<Range> option
//         abstract getSelectedRangeLast: unit -> Range option
//         abstract getSettings: unit -> obj
//         abstract getSourceData: ?r: float * ?c: float * ?r2: float * ?c2: float -> ResizeArray<obj option>
//         abstract getSourceDataArray: ?r: float * ?c: float * ?r2: float * ?c2: float -> ResizeArray<obj option>
//         abstract getSourceDataAtCell: row: float * column: float -> obj option
//         abstract getSourceDataAtCol: column: float -> ResizeArray<obj option>
//         abstract getSourceDataAtRow: row: float -> U2<ResizeArray<obj option>, obj>
        abstract getValue: unit -> obj option
//         abstract hasColHeaders: unit -> bool
//         abstract hasHook: key: string -> bool
//         abstract hasRowHeaders: unit -> bool
//         abstract isEmptyCol: col: float -> bool
//         abstract isEmptyRow: row: float -> bool
//         abstract isListening: unit -> bool
//         abstract listen: unit -> unit
//         abstract loadData: data: ResizeArray<obj option> -> unit
//         abstract populateFromArray: row: float * col: float * input: ResizeArray<obj option> * ?endRow: float * ?endCol: float * ?source: string * ?``method``: string * ?direction: string * ?deltas: ResizeArray<obj option> -> obj option
//         abstract propToCol: prop: U2<string, float> -> float
//         abstract removeCellMeta: row: float * col: float * key: string -> unit
//         abstract removeHook: key: string * callback: (unit -> unit) -> unit
//         abstract render: unit -> unit
//         abstract rowOffset: unit -> float
//         abstract runHooks: key: string * ?p1: obj option * ?p2: obj option * ?p3: obj option * ?p4: obj option * ?p5: obj option * ?p6: obj option -> obj option
//         abstract scrollViewportTo: ?row: float * ?column: float * ?snapToBottom: bool * ?snapToRight: bool -> bool
//         abstract selectCell: row: float * col: float * ?endRow: float * ?endCol: float * ?scrollToCell: bool * ?changeListener: bool -> bool
//         abstract selectCellByProp: row: float * prop: string * ?endRow: float * ?endProp: string * ?scrollToCell: bool -> bool
//         abstract setCellMeta: row: float * col: float * key: string * ``val``: string -> unit
//         abstract setCellMetaObject: row: float * col: float * prop: obj -> unit
        abstract setDataAtCell: row: U2<float, ResizeArray<obj option>> * col: float * value: U2<string, obj> * ?source: string -> unit
//         abstract setDataAtRowProp: row: U2<float, ResizeArray<obj option>> * prop: string * value: string * ?source: string -> unit
//         abstract spliceCol: col: float * index: float * amount: float * ?elements: obj option -> unit
//         abstract spliceRow: row: float * index: float * amount: float * ?elements: obj option -> unit
//         abstract toPhysicalColumn: column: float -> float
//         abstract toPhysicalRow: row: float -> float
//         abstract toVisualColumn: column: float -> float
//         abstract toVisualRow: row: float -> float
//         abstract unlisten: unit -> unit
//         abstract updateSettings: settings: obj * init: bool -> unit
//         abstract validateCells: callback: (unit -> unit) -> unit

    // type [<AllowNullLiteral>] CoreStatic =
    //     [<Emit "new $0($1...)">] abstract Create: element: Element * options: Handsontable.DefaultSettings -> Core

module Handsontable =
//     let [<Import("_editors","handsontable/Handsontable")>] _editors: _editors.IExports = jsNative
//     let [<Import("plugins","handsontable/Handsontable")>] plugins: Plugins.IExports = jsNative

//     module Wot =

//         type [<AllowNullLiteral>] CellCoords =
//             abstract col: float with get, set
//             abstract row: float with get, set

//         type [<AllowNullLiteral>] CellRange =
//             abstract highlight: CellCoords with get, set
//             abstract from: CellCoords with get, set
//             abstract ``to``: CellCoords with get, set

//     module CellTypes =

//         type [<AllowNullLiteral>] Autocomplete =
//             abstract editor: _editors.Autocomplete with get, set
//             abstract renderer: Renderers.Autocomplete with get, set
//             abstract validator: (obj option -> (unit -> unit) -> bool) with get, set

//         type [<AllowNullLiteral>] Checkbox =
//             abstract editor: _editors.Checkbox with get, set
//             abstract renderer: Renderers.Checkbox with get, set

//         type [<AllowNullLiteral>] Date =
//             abstract editor: _editors.Date with get, set
//             abstract renderer: Renderers.Autocomplete with get, set
//             abstract validator: (obj option -> (unit -> unit) -> bool) with get, set

//         type [<AllowNullLiteral>] Dropdown =
//             abstract editor: _editors.Dropdown with get, set
//             abstract renderer: Renderers.Autocomplete with get, set
//             abstract validator: (obj option -> (unit -> unit) -> bool) with get, set

//         type [<AllowNullLiteral>] Handsontable =
//             abstract editor: _editors.Handsontable with get, set
//             abstract renderer: Renderers.Autocomplete with get, set

//         type [<AllowNullLiteral>] Numeric =
//             abstract dataType: string with get, set
//             abstract editor: _editors.Numeric with get, set
//             abstract renderer: Renderers.Numeric with get, set
//             abstract validator: (obj option -> (unit -> unit) -> bool) with get, set

//         type [<AllowNullLiteral>] Password =
//             abstract copyable: bool with get, set
//             abstract editor: _editors.Password with get, set
//             abstract renderer: Renderers.Password with get, set

//         type [<AllowNullLiteral>] Text =
//             abstract editor: _editors.Text with get, set
//             abstract renderer: Renderers.Text with get, set

//         type [<AllowNullLiteral>] Time =
//             abstract editor: _editors.Text with get, set
//             abstract renderer: Renderers.Text with get, set
//             abstract validator: (obj option -> (unit -> unit) -> bool) with get, set

    module _editors =

//         type [<AllowNullLiteral>] IExports =
//             abstract Base: BaseStatic
//             abstract Checkbox: CheckboxStatic
//             abstract Mobile: MobileStatic
//             abstract Select: SelectStatic
//             abstract Text: TextStatic
//             abstract Date: DateStatic
//             abstract Handsontable: HandsontableStatic
//             abstract Numeric: NumericStatic
//             abstract Password: PasswordStatic
//             abstract Autocomplete: AutocompleteStatic
//             abstract Dropdown: DropdownStatic
//             abstract CommentEditor: CommentEditorStatic

        type [<AllowNullLiteral>] Base =
            abstract instance: _Handsontable.Core with get, set
//             abstract row: float with get, set
//             abstract col: float with get, set
//             abstract prop: U2<string, float> with get, set
//             abstract TD: HTMLElement with get, set
//             abstract cellProperties: obj with get, set
//             abstract beginEditing: ?initialValue: string -> unit
//             abstract cancelChanges: unit -> unit
//             abstract checkEditorSection: unit -> unit
//             abstract close: unit -> unit
//             abstract discardEditor: ?validationResult: bool -> unit
//             abstract enableFullEditMode: unit -> unit
//             abstract extend: unit -> unit
//             abstract finishEditing: ?restoreOriginalValue: bool * ?ctrlDown: bool * ?callback: (unit -> unit) -> unit
//             abstract getValue: unit -> unit
//             abstract init: unit -> unit
//             abstract isInFullEditMode: unit -> unit
//             abstract isOpened: unit -> bool
//             abstract isWaiting: unit -> bool
//             abstract ``open``: unit -> unit
//             abstract prepare: row: float * col: float * prop: U2<string, float> * TD: HTMLElement * originalValue: obj option * cellProperties: obj -> unit
//             abstract saveValue: ?``val``: obj option * ?ctrlDown: bool -> unit
//             abstract setValue: ?newValue: obj option -> unit

//         type [<AllowNullLiteral>] BaseStatic =
//             [<Emit "new $0($1...)">] abstract Create: hotInstance: _Handsontable.Core * row: float * col: float * prop: U2<string, float> * TD: HTMLElement * cellProperties: obj -> Base

//         type [<AllowNullLiteral>] Checkbox =
//             inherit Base

//         type [<AllowNullLiteral>] CheckboxStatic =
//             [<Emit "new $0($1...)">] abstract Create: unit -> Checkbox

//         type [<AllowNullLiteral>] Mobile =
//             inherit Base
//             abstract hideCellPointer: unit -> unit
//             abstract onBeforeKeyDown: ?``event``: Event -> unit
//             abstract prepareAndSave: unit -> unit
//             abstract scrollToView: unit -> unit
//             abstract updateEditorData: unit -> unit
//             abstract updateEditorPosition: ?x: float * ?y: float -> unit
//             abstract valueChanged: unit -> unit

//         type [<AllowNullLiteral>] MobileStatic =
//             [<Emit "new $0($1...)">] abstract Create: unit -> Mobile

//         type [<AllowNullLiteral>] Select =
//             inherit Base
//             abstract focus: unit -> unit
//             abstract getEditedCell: unit -> unit
//             abstract prepareOptions: ?optionsToPrepare: U2<obj, ResizeArray<obj option>> -> unit
//             abstract refreshDimensions: unit -> unit
//             abstract refreshValue: unit -> unit
//             abstract registerHooks: unit -> unit

//         type [<AllowNullLiteral>] SelectStatic =
//             [<Emit "new $0($1...)">] abstract Create: unit -> Select

//         type [<AllowNullLiteral>] Text =
//             inherit Base
//             abstract bindEvents: unit -> unit
//             abstract close: ?tdOutside: HTMLElement -> unit
//             abstract createElements: unit -> unit
//             abstract destroy: unit -> unit
//             abstract focus: unit -> unit
//             abstract getEditedCell: unit -> unit
//             abstract refreshDimensions: unit -> unit
//             abstract refreshValue: unit -> unit
//             abstract TEXTAREA: HTMLInputElement with get, set
//             abstract TEXTAREA_PARENT: HTMLElement with get, set
//             abstract textareaStyle: CSSStyleDeclaration with get, set

//         type [<AllowNullLiteral>] TextStatic =
//             [<Emit "new $0($1...)">] abstract Create: unit -> Text

//         type [<AllowNullLiteral>] Date =
//             inherit Text
//             abstract close: unit -> unit
//             abstract destroyElements: unit -> unit
//             abstract finishEditing: ?isCancelled: bool * ?ctrlDown: bool -> unit
//             abstract getDatePickerConfig: unit -> obj
//             abstract hideDatepicker: unit -> unit
//             abstract ``open``: ?``event``: Event -> unit
//             abstract showDatepicker: ?``event``: Event -> unit

//         type [<AllowNullLiteral>] DateStatic =
//             [<Emit "new $0($1...)">] abstract Create: unit -> DateTime

//         type [<AllowNullLiteral>] Handsontable =
//             inherit Text
//             abstract assignHooks: unit -> unit
//             abstract beginEditing: ?initialValue: obj option -> unit
//             abstract close: unit -> unit
//             abstract finishEditing: ?isCancelled: bool * ?ctrlDown: bool -> unit
//             abstract focus: unit -> unit
//             abstract ``open``: unit -> unit

//         type [<AllowNullLiteral>] HandsontableStatic =
//             [<Emit "new $0($1...)">] abstract Create: unit -> Handsontable

//         type [<AllowNullLiteral>] Numeric =
//             inherit Text

//         type [<AllowNullLiteral>] NumericStatic =
//             [<Emit "new $0($1...)">] abstract Create: unit -> Numeric

//         type [<AllowNullLiteral>] Password =
//             inherit Text

//         type [<AllowNullLiteral>] PasswordStatic =
//             [<Emit "new $0($1...)">] abstract Create: unit -> Password

//         type [<AllowNullLiteral>] Autocomplete =
//             inherit Handsontable
//             abstract allowKeyEventPropagation: ?keyCode: float -> unit
//             abstract finishEditing: ?restoreOriginalValue: bool -> unit
//             abstract flipDropdown: ?dropdownHeight: float -> unit
//             abstract flipDropdownIfNeeded: unit -> unit
//             abstract getDropdownHeight: unit -> unit
//             abstract highlightBestMatchingChoice: ?index: float -> unit
//             abstract limitDropdownIfNeeded: ?spaceAvailable: float * ?dropdownHeight: float -> unit
//             abstract queryChoices: ?query: obj option -> unit
//             abstract sortByRelevance: ?value: obj option * ?choices: ResizeArray<obj option> * ?caseSensitive: bool -> ResizeArray<obj option>
//             abstract setDropdownHeight: ?height: float -> unit
//             abstract updateChoicesList: ?choices: ResizeArray<obj option> -> unit
//             abstract unflipDropdown: unit -> unit
//             abstract updateDropdownHeight: unit -> unit

//         type [<AllowNullLiteral>] AutocompleteStatic =
//             [<Emit "new $0($1...)">] abstract Create: unit -> Autocomplete

//         type [<AllowNullLiteral>] Dropdown =
//             inherit Autocomplete

//         type [<AllowNullLiteral>] DropdownStatic =
//             [<Emit "new $0($1...)">] abstract Create: unit -> Dropdown

//         type [<AllowNullLiteral>] CommentEditor =
//             abstract editor: HTMLElement with get, set
//             abstract editorStyle: CSSStyleDeclaration with get, set
//             abstract hidden: bool with get, set
//             abstract setPosition: x: float * y: float -> unit
//             abstract setSize: width: float * height: float -> unit
//             abstract resetSize: unit -> unit
//             abstract setReadOnlyState: state: bool -> unit
//             abstract show: unit -> unit
//             abstract hide: unit -> unit
//             abstract isVisible: unit -> unit
//             abstract setValue: ?value: string -> unit
//             abstract getValue: unit -> string
//             abstract isFocused: unit -> bool
//             abstract focus: unit -> unit
//             abstract createEditor: unit -> HTMLElement
//             abstract getInputElement: unit -> HTMLElement
//             abstract destroy: unit -> unit

//         type [<AllowNullLiteral>] CommentEditorStatic =
//             [<Emit "new $0($1...)">] abstract Create: unit -> CommentEditor

//     module Plugins =

//         type [<AllowNullLiteral>] IExports =
//             abstract Base: BaseStatic

//         module FiltersPlugin =

//             type [<StringEnum>] [<RequireQualifiedAccess>] OperationType =
//                 | Conjunction
//                 | Disjunction

//             type [<StringEnum>] [<RequireQualifiedAccess>] ConditionName =
//                 | Begins_with
//                 | Between
//                 | By_value
//                 | Contains
//                 | Empty
//                 | Ends_with
//                 | Eq
//                 | Gt
//                 | Gte
//                 | Lt
//                 | Lte
//                 | Not_between
//                 | Not_contains
//                 | Not_empty
//                 | Neq

//             type [<AllowNullLiteral>] ConditionId =
//                 abstract args: ResizeArray<obj option> with get, set
//                 abstract name: ConditionName option with get, set
//                 abstract command: obj option with get, set

//             type [<AllowNullLiteral>] Condition =
//                 abstract name: ConditionName with get, set
//                 abstract args: ResizeArray<obj option> with get, set
//                 abstract func: (CellValue -> ResizeArray<obj option> -> bool) with get, set

//             type [<AllowNullLiteral>] CellLikeData =
//                 abstract meta: obj with get, set
//                 abstract value: string with get, set

//             type [<AllowNullLiteral>] BaseComponent =
//                 abstract elements: ResizeArray<obj option> with get, set
//                 abstract hidden: bool with get, set
//                 abstract destroy: unit -> bool
//                 abstract hide: unit -> unit
//                 abstract isHidden: unit -> bool
//                 abstract reset: unit -> unit
//                 abstract show: unit -> unit

//             type [<AllowNullLiteral>] ActionBarComponent =
//                 inherit BaseComponent
//                 abstract getMenuItemDescriptor: unit -> obj
//                 abstract accept: unit -> unit
//                 abstract cancel: unit -> unit

//             type [<AllowNullLiteral>] ConditionComponent =
//                 inherit BaseComponent
//                 abstract getInputElement: ?index: float -> InputUI
//                 abstract getInputElements: unit -> ResizeArray<obj option>
//                 abstract getMenuItemDescriptor: unit -> obj
//                 abstract getSelectElement: unit -> SelectUI
//                 abstract getState: unit -> obj
//                 abstract setState: value: obj -> unit
//                 abstract updateState: stateInfo: obj -> unit

//             type [<AllowNullLiteral>] ValueComponent =
//                 inherit BaseComponent
//                 abstract getMenuItemDescriptor: unit -> obj
//                 abstract getMultipleSelectElement: unit -> MultipleSelectUI
//                 abstract getState: unit -> obj
//                 abstract setState: value: obj -> unit
//                 abstract updateState: stateInfo: obj -> unit

//             type [<AllowNullLiteral>] BaseUI =
//                 abstract buildState: bool with get, set
//                 abstract eventManager: EventManager with get, set
//                 abstract hot: _Handsontable.Core with get, set
//                 abstract options: obj with get, set
//                 abstract build: unit -> unit
//                 abstract destroy: unit -> unit
//                 abstract element: unit -> Element
//                 abstract focus: unit -> unit
//                 abstract getValue: unit -> obj option
//                 abstract hide: unit -> unit
//                 abstract isBuilt: unit -> bool
//                 abstract reset: unit -> unit
//                 abstract setValue: value: obj option -> obj option
//                 abstract show: unit -> unit
//                 abstract update: unit -> unit

//             type [<AllowNullLiteral>] InputUI =
//                 inherit BaseUI

//             type [<AllowNullLiteral>] MultipleSelectUI =
//                 inherit BaseUI
//                 abstract clearAllUI: BaseUI with get, set
//                 abstract items: ResizeArray<obj option> with get, set
//                 abstract itemsBox: _Handsontable.Core with get, set
//                 abstract searchInput: InputUI with get, set
//                 abstract selectAllUI: BaseUI with get, set
//                 abstract getItems: unit -> unit
//                 abstract getValue: unit -> ResizeArray<obj option>
//                 abstract isSelectedAllValues: unit -> bool
//                 abstract setItems: items: ResizeArray<obj option> -> unit

//             type [<AllowNullLiteral>] SelectUI =
//                 inherit BaseUI
//                 abstract menu: U2<Menu, unit> with get, set
//                 abstract items: ResizeArray<obj option> with get, set
//                 abstract setItems: items: ResizeArray<obj option> -> unit
//                 abstract openOptions: unit -> unit
//                 abstract closeOptions: unit -> unit

//             type [<AllowNullLiteral>] ConditionCollection =
//                 abstract conditions: obj with get, set
//                 abstract orderStack: ResizeArray<obj option> with get, set
//                 abstract addCondition: column: float * conditionDefinition: ConditionId * ?operation: OperationType -> unit
//                 abstract clean: unit -> unit
//                 abstract clearConditions: column: float -> unit
//                 abstract destroy: unit -> unit
//                 abstract exportAllConditions: unit -> ResizeArray<ConditionId>
//                 abstract getConditions: column: float -> ResizeArray<Condition>
//                 abstract hasConditions: column: float * name: string -> bool
//                 abstract isEmpty: unit -> bool
//                 abstract isMatch: value: CellLikeData * column: float -> bool
//                 abstract isMatchInConditions: conditions: ResizeArray<Condition> * value: CellLikeData * ?operationType: OperationType -> bool
//                 abstract importAllConditions: conditions: ResizeArray<ConditionId> -> unit
//                 abstract removeConditions: column: float -> unit

//             type [<AllowNullLiteral>] ConditionUpdateObserver =
//                 abstract changes: ResizeArray<float> with get, set
//                 abstract columnDataFactory: (float -> ResizeArray<obj>) with get, set
//                 abstract conditionCollection: ConditionCollection with get, set
//                 abstract grouping: bool with get, set
//                 abstract latestEditedColumnPosition: float with get, set
//                 abstract latestOrderStack: ResizeArray<float> with get, set
//                 abstract destroy: unit -> unit
//                 abstract flush: unit -> unit
//                 abstract groupChanges: unit -> unit
//                 abstract updateStatesAtColumn: column: float * conditionArgsChange: obj -> unit

//         type [<AllowNullLiteral>] BindStrategy =
//             abstract klass: (unit -> unit) with get, set
//             abstract strategy: U2<string, unit> with get, set
//             abstract clearMap: unit -> unit
//             abstract createMap: length: float -> unit
//             abstract createRow: ``params``: obj option -> unit
//             abstract destroy: unit -> unit
//             abstract removeRow: ``params``: obj option -> unit
//             abstract setStrategy: name: string -> unit
//             abstract translate: ``params``: obj option -> unit

//         type [<AllowNullLiteral>] CommandExecutor =
//             abstract hot: _Handsontable.Core with get, set
//             abstract commands: obj with get, set
//             abstract commonCallback: U2<(unit -> unit), unit> with get, set
//             abstract registerCommand: name: string * commandDescriptor: obj -> unit
//             abstract setCommonCallback: callback: (unit -> unit) -> unit
//             abstract execute: commandName: string * [<ParamArray>] ``params``: ResizeArray<obj option> -> unit

//         type [<AllowNullLiteral>] Cursor =
//             abstract cellHeight: float with get, set
//             abstract cellWidth: float with get, set
//             abstract left: float with get, set
//             abstract leftRelative: float with get, set
//             abstract scrollLeft: float with get, set
//             abstract scrollTop: float with get, set
//             abstract top: float with get, set
//             abstract topRelative: float with get, set
//             abstract ``type``: string with get, set
//             abstract fitsAbove: element: HTMLElement -> bool
//             abstract fitsBelow: element: HTMLElement * ?viewportHeight: float -> bool
//             abstract fitsOnLeft: element: HTMLElement -> bool
//             abstract fitsOnRight: element: HTMLElement * ?viewportHeight: float -> bool
//             abstract getSourceType: ``object``: obj option -> string

//         type [<AllowNullLiteral>] Endpoints =
//             abstract plugin: Plugins.ColumnSummary with get, set
//             abstract hot: _Handsontable.Core with get, set
//             abstract endpoints: ResizeArray<obj option> with get, set
//             abstract settings: U2<obj, (unit -> unit)> with get, set
//             abstract settingsType: string with get, set
//             abstract currentEndpoint: U2<obj, unit> with get, set
//             abstract assignSetting: settings: obj * endpoint: obj * name: string * defaultValue: obj option -> unit
//             abstract getAllEndpoints: unit -> ResizeArray<obj option>
//             abstract getEndpoint: index: float -> obj
//             abstract parseSettings: settings: ResizeArray<obj option> -> unit
//             abstract refreshAllEndpoints: init: bool -> unit
//             abstract refreshChangedEndpoints: changes: ResizeArray<obj option> -> unit
//             abstract refreshEndpoint: endpoint: obj -> unit
//             abstract resetAllEndpoints: endpoints: ResizeArray<obj option> * ?useOffset: bool -> unit
//             abstract resetEndpointValue: endpoint: obj * ?useOffset: bool -> unit
//             abstract setEndpointValue: endpoint: obj * source: string * ?render: bool -> unit

//         type [<AllowNullLiteral>] EventManager =
//             abstract context: obj option with get, set
//             abstract addEventListener: element: Element * eventName: string * callback: (unit -> unit) -> (unit -> unit)
//             abstract removeEventListener: element: Element * eventName: string * callback: (unit -> unit) -> unit
//             abstract clearEvents: unit -> unit
//             abstract clear: unit -> unit
//             abstract destroy: unit -> unit
//             abstract fireEvent: element: Element * eventName: string -> unit
//             abstract extendEvent: context: obj * ``event``: Event -> obj option

//         type [<AllowNullLiteral>] GhostTable =
//             abstract columns: ResizeArray<float> with get, set
//             abstract container: HTMLElement option with get, set
//             abstract hot: _Handsontable.Core with get, set
//             abstract injected: bool with get, set
//             abstract rows: ResizeArray<obj> with get, set
//             abstract samples: obj option with get, set
//             abstract settings: obj with get, set
//             abstract addRow: row: float * samples: obj -> unit
//             abstract addColumn: column: float * samples: obj -> unit
//             abstract addColumnHeadersRow: samples: obj -> unit
//             abstract clean: unit -> unit
//             abstract createCol: column: float -> DocumentFragment
//             abstract createColElement: column: float -> HTMLElement
//             abstract createColGroupsCol: unit -> DocumentFragment
//             abstract createColumnHeadersRow: unit -> DocumentFragment
//             abstract createContainer: ?className: string -> obj
//             abstract createRow: row: float -> DocumentFragment
//             abstract createTable: ?className: string -> obj
//             abstract getHeights: callback: (float -> float -> unit) -> unit
//             abstract getWidths: callback: (float -> float -> unit) -> unit
//             abstract getSettings: unit -> U2<obj, unit>
//             abstract getSetting: name: string -> U2<bool, unit>
//             abstract injectTable: ?parent: U2<HTMLElement, unit> -> unit
//             abstract isHorizontal: unit -> bool
//             abstract isVertical: unit -> bool
//             abstract removeTable: unit -> unit
//             abstract setSettings: settings: obj -> unit
//             abstract setSetting: name: string * value: obj option -> unit

//         type [<AllowNullLiteral>] ItemsFactory =
//             abstract defaultOrderPattern: U2<ResizeArray<obj option>, unit> with get, set
//             abstract hot: _Handsontable.Core with get, set
//             abstract predefinedItems: obj with get, set
//             abstract getItems: ?pattern: U3<ResizeArray<obj option>, obj, bool> -> ResizeArray<obj option>
//             abstract setPredefinedItems: predefinedItems: ResizeArray<obj option> -> unit

//         type [<AllowNullLiteral>] Menu =
//             abstract container: HTMLElement with get, set
//             abstract eventManager: EventManager with get, set
//             abstract hot: _Handsontable.Core with get, set
//             abstract hotMenu: _Handsontable.Core with get, set
//             abstract hotSubMenus: obj with get, set
//             abstract keyEvent: bool with get, set
//             abstract menuItems: ResizeArray<obj option> option with get, set
//             abstract offset: obj with get, set
//             abstract options: obj with get, set
//             abstract origOutsideClickDeselects: U2<bool, (unit -> unit)> with get, set
//             abstract parentMenu: Menu option with get, set
//             abstract close: ?closeParent: bool -> unit
//             abstract closeSubMenu: row: float -> unit
//             abstract closeAllSubMenus: unit -> unit
//             abstract destroy: unit -> unit
//             abstract executeCommand: ``event``: Event -> unit
//             abstract isOpened: unit -> bool
//             abstract isSubMenu: unit -> bool
//             abstract ``open``: unit -> unit
//             abstract openSubMenu: row: float -> U2<Menu, bool>
//             abstract setMenuItems: menuItems: ResizeArray<obj option> -> unit
//             abstract setOffset: area: string * ?offset: float -> unit
//             abstract selectLastCell: unit -> unit
//             abstract selectFirstCell: unit -> unit
//             abstract selectPrevCell: row: float * col: float -> unit
//             abstract selectNextCell: row: float * col: float -> unit
//             abstract setPosition: coords: U2<Event, obj> -> unit
//             abstract setPositionAboveCursor: cursor: Cursor -> unit
//             abstract setPositionBelowCursor: cursor: Cursor -> unit
//             abstract setPositionOnLeftOfCursor: cursor: Cursor -> unit
//             abstract setPositionOnRightOfCursor: cursor: Cursor -> unit

//         type [<AllowNullLiteral>] SamplesGenerator =
//             abstract allowDuplicates: bool option with get, set
//             abstract customSampleCount: bool option with get, set
//             abstract dataFactory: (unit -> unit) with get, set
//             abstract samples: obj option with get, set
//             abstract generateColumnSamples: colRange: obj * rowRange: obj -> obj
//             abstract generateRowSamples: rowRange: U2<obj, float> * colRange: obj -> obj
//             abstract generateSamples: ``type``: string * range: obj * specifierRange: U2<obj, float> -> obj
//             abstract generateSample: ``type``: string * range: obj * specifierValue: float -> obj
//             abstract getSampleCount: unit -> float
//             abstract setAllowDuplicates: allowDuplicates: bool -> unit
//             abstract setSampleCount: sampleCount: float -> unit

//         type [<AllowNullLiteral>] Base =
//             abstract pluginName: string with get, set
//             abstract pluginsInitializedCallback: ResizeArray<obj option> with get, set
//             abstract isPluginsReady: bool with get, set
//             abstract enabled: bool with get, set
//             abstract initialized: bool with get, set
//             abstract addHook: name: string * callback: (unit -> unit) -> unit
//             abstract callOnPluginsReady: callback: (unit -> unit) -> unit
//             abstract clearHooks: unit -> unit
//             abstract destroy: unit -> unit
//             abstract disablePlugin: unit -> unit
//             abstract enablePlugin: unit -> unit
//             abstract init: unit -> unit
//             abstract removeHook: name: string -> unit

//         type [<AllowNullLiteral>] BaseStatic =
//             [<Emit "new $0($1...)">] abstract Create: ?hotInstance: _Handsontable.Core -> Base

//         type [<AllowNullLiteral>] AutoColumnSize =
//             inherit Base
//             abstract firstCalculation: bool with get, set
//             abstract ghostTable: GhostTable with get, set
//             abstract inProgress: bool with get, set
//             abstract sampleGenerator: SamplesGenerator with get, set
//             abstract widths: ResizeArray<obj option> with get, set
//             abstract calculateAllColumnsWidth: ?rowRange: U2<float, obj> -> unit
//             abstract calculateColumnsWidth: ?colRange: U2<float, obj> * ?rowRange: U2<float, obj> * ?force: bool -> unit
//             abstract clearCache: ?columns: ResizeArray<obj option> -> unit
//             abstract findColumnsWhereHeaderWasChanged: unit -> ResizeArray<obj option>
//             abstract getColumnWidth: col: float * ?defaultWidth: float * ?keepMinimum: bool -> float
//             abstract getFirstVisibleColumn: unit -> float
//             abstract getLastVisibleColumn: unit -> float
//             abstract getSyncCalculationLimit: unit -> float
//             abstract isNeedRecalculate: unit -> bool
//             abstract recalculateAllColumnsWidth: unit -> unit

//         type [<AllowNullLiteral>] AutoRowSize =
//             inherit Base
//             abstract firstCalculation: bool with get, set
//             abstract heights: ResizeArray<obj option> with get, set
//             abstract ghostTable: GhostTable with get, set
//             abstract inProgress: bool with get, set
//             abstract sampleGenerator: SamplesGenerator with get, set
//             abstract calculateAllRowsHeight: ?colRange: U2<float, obj> -> unit
//             abstract calculateRowsHeight: ?rowRange: U2<float, obj> * ?colRange: U2<float, obj> * ?force: bool -> unit
//             abstract clearCache: unit -> unit
//             abstract clearCacheByRange: range: U2<float, obj> -> unit
//             abstract findColumnsWhereHeaderWasChanged: unit -> ResizeArray<obj option>
//             abstract getColumnHeaderHeight: unit -> U2<float, unit>
//             abstract getFirstVisibleRow: unit -> float
//             abstract getLastVisibleRow: unit -> float
//             abstract getRowHeight: col: float * ?defaultHeight: float -> float
//             abstract getSyncCalculationLimit: unit -> float
//             abstract isNeedRecalculate: unit -> bool
//             abstract recalculateAllRowsHeight: unit -> unit

//         type [<AllowNullLiteral>] Autofill =
//             inherit Base
//             abstract addingStarted: bool with get, set
//             abstract autoInsertRow: bool with get, set
//             abstract directions: ResizeArray<string> with get, set
//             abstract eventManager: EventManager with get, set
//             abstract handleDraggedCells: bool with get, set
//             abstract mouseDownOnCellCorner: bool with get, set
//             abstract mouseDragOutside: bool with get, set

//         type [<AllowNullLiteral>] BindRowsWithHeaders =
//             inherit Base
//             abstract bindStrategy: BindStrategy with get, set
//             abstract removeRows: ResizeArray<obj option> with get, set

//         type [<AllowNullLiteral>] CollapsibleColumns =
//             inherit Base
//             abstract buttonEnabledList: obj with get, set
//             abstract collapsedSections: obj with get, set
//             abstract columnHeaderLevelCount: float with get, set
//             abstract eventManager: EventManager with get, set
//             abstract hiddenColumnsPlugin: obj with get, set
//             abstract nestedHeadersPlugin: obj with get, set
//             abstract settings: U2<bool, ResizeArray<obj option>> with get, set
//             abstract checkDependencies: unit -> unit
//             abstract collapseAll: unit -> unit
//             abstract collapseSection: coords: obj -> unit
//             abstract expandAll: unit -> unit
//             abstract expandSection: coords: obj -> unit
//             abstract generateIndicator: col: float * TH: HTMLElement -> HTMLElement
//             abstract markSectionAs: state: string * row: float * column: float * recursive: bool -> unit
//             abstract meetsDependencies: unit -> bool
//             abstract parseSettings: unit -> unit
//             abstract toggleAllCollapsibleSections: action: string -> unit
//             abstract toggleCollapsibleSection: coords: obj * action: string -> unit

//         type [<AllowNullLiteral>] ColumnSorting =
//             inherit Base
//             abstract lastSortedColumn: float with get, set
//             abstract sortEmptyCells: bool with get, set
//             abstract sortIndicators: ResizeArray<obj option> with get, set
//             abstract dateSort: sortOrder: bool * columnMeta: obj -> (obj option -> obj option -> bool)
//             abstract defaultSort: sortOrder: bool * columnMeta: obj -> (obj option -> obj option -> bool)
//             abstract enableObserveChangesPlugin: unit -> unit
//             abstract getColHeader: col: float * TH: HTMLElement -> unit
//             abstract isSorted: unit -> bool
//             abstract loadSortingState: unit -> obj option
//             abstract numericSort: sortOrder: bool * columnMeta: obj -> (obj option -> obj option -> bool)
//             abstract saveSortingState: unit -> unit
//             abstract setSortingColumn: col: float * order: U2<bool, unit> -> unit
//             abstract sort: unit -> unit
//             abstract sortBySettings: unit -> unit
//             abstract sortByColumn: col: float * order: U2<bool, unit> -> unit
//             abstract translateRow: row: float -> float
//             abstract untranslateRow: row: float -> float
//             abstract updateOrderClass: unit -> unit
//             abstract updateSortIndicator: unit -> unit

//         type [<AllowNullLiteral>] ColumnSummary =
//             inherit Base
//             abstract endpoints: U2<Endpoints, unit> with get, set
//             abstract calculate: endpoint: Endpoints -> unit
//             abstract calculateAverage: endpoint: Endpoints -> float
//             abstract calculateMinMax: endpoint: Endpoints * ``type``: string -> float
//             abstract calculateSum: endpoint: Endpoints -> unit
//             abstract countEmpty: rowRange: ResizeArray<obj option> * col: float -> float
//             abstract countEntries: endpoint: Endpoints -> float
//             abstract getCellValue: row: float * col: float -> string
//             abstract getPartialMinMax: rowRange: ResizeArray<obj option> * col: float * ``type``: string -> float
//             abstract getPartialSum: rowRange: ResizeArray<obj option> * col: float -> float

//         type CommentsRangeObject =
//             obj

//         type [<AllowNullLiteral>] Comments =
//             inherit Base
//             abstract contextMenuEvent: bool with get, set
//             abstract displayDelay: float with get, set
//             abstract editor: _editors.CommentEditor with get, set
//             abstract eventManager: EventManager with get, set
//             abstract mouseDown: bool with get, set
//             abstract range: CommentsRangeObject with get, set
//             abstract timer: obj option with get, set
//             abstract clearRange: unit -> unit
//             abstract getComment: unit -> obj
//             abstract getCommentMeta: row: float * column: float * property: string -> obj option
//             abstract hide: unit -> unit
//             abstract refreshEditor: ?force: bool -> unit
//             abstract removeComment: ?forceRender: bool -> unit
//             abstract removeCommentAtCell: row: float * col: float * ?forceRender: bool -> unit
//             abstract setComment: value: string -> unit
//             abstract setCommentAtCell: row: float * col: float * value: string -> unit
//             abstract setRange: range: CommentsRangeObject -> unit
//             abstract show: unit -> bool
//             abstract showAtCell: row: float * col: float -> bool
//             abstract targetIsCellWithComment: ``event``: Event -> bool
//             abstract targetIsCommentTextArea: ``event``: Event -> bool
//             abstract updateCommentMeta: row: float * column: float * metaObject: obj -> unit

//         type [<AllowNullLiteral>] ContextMenu =
//             inherit Base
//             abstract eventManager: EventManager with get, set
//             abstract commandExecutor: CommandExecutor with get, set
//             abstract itemsFactory: U2<ItemsFactory, unit> with get, set
//             abstract menu: U2<Menu, unit> with get, set
//             abstract close: unit -> unit
//             abstract executeCommand: commandName: string * [<ParamArray>] ``params``: ResizeArray<obj option> -> unit
//             abstract ``open``: ``event``: Event -> unit

//         type [<AllowNullLiteral>] Textarea =
//             abstract element: HTMLElement with get, set
//             abstract isAppended: bool with get, set
//             abstract refCounter: float with get, set
//             abstract append: unit -> unit
//             abstract create: unit -> unit
//             abstract deselect: unit -> unit
//             abstract destroy: unit -> unit
//             abstract getValue: unit -> string
//             abstract hasBeenDestroyed: unit -> bool
//             abstract isActive: unit -> bool
//             abstract select: unit -> unit
//             abstract setValue: data: string -> unit

//         type [<StringEnum>] [<RequireQualifiedAccess>] PasteModeType =
//             | Overwrite
//             | Shift_down
//             | Shift_right

//         type RangeType =
//             obj

//         type [<AllowNullLiteral>] CopyPaste =
//             inherit Base
//             abstract eventManager: EventManager with get, set
//             abstract columnsLimit: float with get, set
//             abstract copyableRanges: ResizeArray<obj option> with get, set
//             abstract pasteMode: PasteModeType with get, set
//             abstract rowsLimit: float with get, set
//             abstract textarea: Textarea with get, set
//             abstract setCopyableText: unit -> unit
//             abstract getRangedCopyableData: ranges: ResizeArray<RangeType> -> string
//             abstract getRangedData: ranges: ResizeArray<RangeType> -> ResizeArray<obj option>
//             abstract copy: ?triggeredByClick: bool -> unit
//             abstract cut: ?triggeredByClick: bool -> unit
//             abstract paste: ?triggeredByClick: bool -> unit

//         type [<AllowNullLiteral>] DragToScroll =
//             inherit Base
//             abstract boundaries: U2<obj, unit> with get, set
//             abstract callback: U2<(unit -> unit), unit> with get, set
//             abstract check: x: float * y: float -> unit
//             abstract setBoundaries: boundaries: obj -> unit
//             abstract setCallback: callback: (unit -> unit) -> unit

//         type SeparatorObject =
//             obj

//         type [<AllowNullLiteral>] DropdownMenu =
//             inherit Base
//             abstract eventManager: EventManager with get, set
//             abstract commandExecutor: CommandExecutor with get, set
//             abstract itemsFactory: U2<ItemsFactory, unit> with get, set
//             abstract menu: U2<Menu, unit> with get, set
//             abstract SEPARATOR: SeparatorObject with get, set
//             abstract close: unit -> unit
//             abstract executeCommand: commandName: string * [<ParamArray>] ``params``: ResizeArray<obj option> -> unit
//             abstract ``open``: ``event``: Event -> unit

//         type [<AllowNullLiteral>] ExportFile =
//             inherit Base
//             abstract downloadFile: format: string * options: obj -> unit
//             abstract exportAsString: format: string * ?options: obj -> string
//             abstract exportAsBlob: format: string * ?options: obj -> Blob

//         type [<AllowNullLiteral>] Filters =
//             inherit Base
//             abstract actionBarComponent: U2<FiltersPlugin.ActionBarComponent, unit> with get, set
//             abstract dropdownMenuPlugin: U2<DropdownMenu, unit> with get, set
//             abstract eventManager: EventManager with get, set
//             abstract conditionComponent: U2<FiltersPlugin.ConditionComponent, unit> with get, set
//             abstract conditionCollection: U2<FiltersPlugin.ConditionCollection, unit> with get, set
//             abstract conditionUpdateObserver: U2<FiltersPlugin.ConditionUpdateObserver, unit> with get, set
//             abstract lastSelectedColumn: U2<float, unit> option with get, set
//             abstract trimRowsPlugin: U2<TrimRows, unit> with get, set
//             abstract valueComponent: U2<FiltersPlugin.ValueComponent, unit> with get, set
//             abstract addCondition: column: float * name: string * args: ResizeArray<obj option> * operationId: FiltersPlugin.OperationType -> unit
//             abstract clearColumnSelection: unit -> unit
//             abstract clearConditions: ?column: U2<float, unit> -> unit
//             abstract getDataMapAtColumn: column: float -> ResizeArray<FiltersPlugin.CellLikeData>
//             abstract getSelectedColumn: unit -> U2<float, unit>
//             abstract filter: unit -> unit
//             abstract removeConditions: column: float -> unit

//         type [<AllowNullLiteral>] RecordTranslator =
//             abstract hot: _Handsontable.Core with get, set
//             abstract toPhysical: row: U2<float, obj> * ?column: float -> U2<obj, ResizeArray<obj option>>
//             abstract toPhysicalColumn: column: float -> float
//             abstract toPhysicalRow: row: float -> float
//             abstract toVisual: row: U2<float, obj> * ?column: float -> U2<obj, ResizeArray<obj option>>
//             abstract toVisualColumn: column: float -> float
//             abstract toVisualRow: row: float -> float

//         type [<AllowNullLiteral>] DataProvider =
//             abstract changes: obj with get, set
//             abstract hot: _Handsontable.Core with get, set
//             abstract t: RecordTranslator with get, set
//             abstract clearChanges: unit -> unit
//             abstract collectChanges: row: float * column: float * value: obj option -> unit
//             abstract destroy: unit -> unit
//             abstract getDataAtCell: row: float * column: float -> obj option
//             abstract getDataByRange: row1: float * column1: float * row2: float * column2: float -> ResizeArray<obj option>
//             abstract getRawDataAtCell: row: float * column: float -> obj option
//             abstract getRawDataByRange: row1: float * column1: float * row2: float * column2: float -> ResizeArray<obj option>
//             abstract getSourceDataByRange: row1: float * column1: float * row2: float * column2: float -> ResizeArray<obj option>
//             abstract getSourceDataAtCell: row: float * column: float -> obj option
//             abstract isInDataRange: row: float * column: float -> bool
//             abstract updateSourceData: row: float * column: float * value: obj option -> unit

//         type [<AllowNullLiteral>] AlterManager =
//             abstract sheet: Sheet with get, set
//             abstract hot: _Handsontable.Core with get, set
//             abstract dataProvider: DataProvider with get, set
//             abstract matrix: Matrix with get, set
//             abstract prepareAlter: action: string * args: obj option -> unit
//             abstract triggerAlter: action: string * args: obj option -> unit
//             abstract destroy: unit -> unit

//         type [<AllowNullLiteral>] Matrix =
//             abstract t: RecordTranslator with get, set
//             abstract data: ResizeArray<obj option> with get, set
//             abstract cellReferences: ResizeArray<obj option> with get, set
//             abstract getCellAt: row: float * column: float -> U2<CellValue, unit>
//             abstract getOutOfDateCells: unit -> ResizeArray<obj option>
//             abstract add: cellValue: U2<CellValue, obj> -> unit
//             abstract remove: cellValue: U3<CellValue, obj, ResizeArray<obj option>> -> unit
//             abstract getDependencies: cellCoord: obj -> unit
//             abstract registerCellRef: cellReference: U2<CellReference, obj> -> unit
//             abstract removeCellRefsAtRange: start: obj * ``end``: obj -> ResizeArray<obj option>
//             abstract reset: unit -> unit

//         type [<AllowNullLiteral>] BaseCell =
//             abstract columnAbsolute: bool with get, set
//             abstract columnOffset: float with get, set
//             abstract rowAbsolute: bool with get, set
//             abstract rowOffset: float with get, set
//             abstract isEqual: cell: BaseCell -> bool
//             abstract toString: unit -> string
//             abstract translateTo: rowOffset: float * columnOffset: float -> unit

//         type [<AllowNullLiteral>] CellReference =
//             inherit BaseCell

//         type [<AllowNullLiteral>] CellValue =
//             inherit BaseCell
//             abstract error: U2<string, unit> with get, set
//             abstract precedents: ResizeArray<obj option> with get, set
//             abstract state: string with get, set
//             abstract value: obj option with get, set
//             abstract addPrecedent: cellReference: CellReference -> unit
//             abstract clearPrecedents: unit -> unit
//             abstract getError: unit -> U2<string, unit>
//             abstract getPrecedents: unit -> ResizeArray<obj option>
//             abstract getValue: unit -> obj option
//             abstract hasError: unit -> bool
//             abstract hasPrecedent: cellReference: CellReference -> bool
//             abstract hasPrecedents: unit -> bool
//             abstract isState: state: float -> bool
//             abstract removePrecedent: cellReference: CellReference -> unit
//             abstract setError: error: string -> unit
//             abstract setState: state: float -> unit
//             abstract setValue: value: obj option -> unit

//         type Parser =
//             obj

//         type [<AllowNullLiteral>] Sheet =
//             abstract alterManager: AlterManager with get, set
//             abstract dataProvider: DataProvider with get, set
//             abstract hot: _Handsontable.Core with get, set
//             abstract matrix: Matrix with get, set
//             abstract parser: Parser with get, set
//             abstract t: RecordTranslator with get, set
//             abstract applyChanges: row: float * column: float * newValue: obj option -> unit
//             abstract destroy: unit -> unit
//             abstract getCellAt: row: float * column: float -> U2<CellValue, unit>
//             abstract getCellDependencies: row: float * column: float -> ResizeArray<obj option>
//             abstract getVariable: name: string -> obj option
//             abstract parseExpression: cellValue: U2<CellValue, obj> * formula: string -> unit
//             abstract recalculate: unit -> unit
//             abstract recalculateFull: unit -> unit
//             abstract recalculateOptimized: unit -> unit
//             abstract setVariable: name: string * value: obj option -> unit

//         type [<AllowNullLiteral>] Stack =
//             abstract items: ResizeArray<obj option> with get, set
//             abstract isEmpty: unit -> bool
//             abstract peek: unit -> obj option
//             abstract pop: unit -> obj option
//             abstract push: items: obj option -> unit
//             abstract size: unit -> float

//         type [<AllowNullLiteral>] UndoRedoSnapshot =
//             abstract sheet: Sheet with get, set
//             abstract stack: Stack with get, set
//             abstract destroy: unit -> unit
//             abstract restore: unit -> unit
//             abstract save: axis: string * index: float * amount: float -> unit

//         type [<AllowNullLiteral>] Formulas =
//             inherit Base
//             abstract dataProvider: DataProvider with get, set
//             abstract eventManager: EventManager with get, set
//             abstract sheet: Sheet with get, set
//             abstract undoRedoSnapshot: UndoRedoSnapshot with get, set
//             abstract getCellValue: row: float * column: float -> obj option
//             abstract getVariable: name: string -> obj option
//             abstract hasComputedCellValue: row: float * column: float -> bool
//             abstract recalculate: unit -> unit
//             abstract recalculateFull: unit -> unit
//             abstract recalculateOptimized: unit -> unit
//             abstract setVariable: name: string * value: obj option -> unit

//         type [<AllowNullLiteral>] GanttChart =
//             inherit Base
//             abstract colorData: obj with get, set
//             abstract currentYear: U2<float, unit> with get, set
//             abstract dateCalculator: U2<obj, unit> with get, set
//             abstract dataFeed: U2<obj, unit> with get, set
//             abstract hotSource: U2<_Handsontable.Core, unit> with get, set
//             abstract initialSettings: U2<obj, unit> with get, set
//             abstract monthHeadersArray: ResizeArray<obj option> with get, set
//             abstract monthList: ResizeArray<obj option> with get, set
//             abstract nestedHeadersPlugin: U2<NestedHeaders, unit> with get, set
//             abstract overallWeekSectionCount: U2<float, unit> with get, set
//             abstract rangeBarMeta: U2<obj, unit> with get, set
//             abstract rangeBars: obj with get, set
//             abstract rangeList: obj with get, set
//             abstract settings: obj with get, set
//             abstract weekHeadersArray: ResizeArray<obj option> with get, set
//             abstract addRangeBar: row: float * startDate: U2<DateTime, string> * endDate: U2<DateTime, string> * additionalData: obj -> U2<bool, ResizeArray<obj option>>
//             abstract applyRangeBarMetaCache: unit -> unit
//             abstract cacheRangeBarMeta: row: float * col: float * key: string * value: U2<obj option, ResizeArray<obj option>> -> unit
//             abstract checkDependencies: unit -> unit
//             abstract getRangeBarCoordinates: row: float -> obj
//             abstract getRangeBarData: row: float * column: float -> U2<obj, bool>
//             abstract renderRangeBar: row: float * startDateColumn: float * endDateColumn: float * additionalData: obj -> unit
//             abstract removeRangeBarByDate: row: float * startDate: U2<DateTime, string> -> unit
//             abstract removeRangeBarByColumn: row: float * startDateColumn: float -> unit
//             abstract removeAllRangeBars: unit -> unit
//             abstract setRangeBarColors: rows: obj -> unit
//             abstract setYear: year: float -> unit
//             abstract uniformBackgroundRenderer: instance: _Handsontable.Core * TD: HTMLElement * row: float * col: float * prop: U2<string, float> * value: U2<string, float> * cellProperties: obj -> unit
//             abstract unrenderRangeBar: row: float * startDateColumn: float * endDateColumn: float -> unit
//             abstract updateRangeBarData: row: float * column: float * data: obj -> unit

//         type [<AllowNullLiteral>] HeaderTooltips =
//             inherit Base
//             abstract settings: U2<bool, obj> with get, set
//             abstract parseSettings: unit -> unit

//         type [<AllowNullLiteral>] HiddenColumns =
//             inherit Base
//             abstract hiddenColumns: U2<bool, ResizeArray<obj option>> with get, set
//             abstract lastSelectedColumn: float with get, set
//             abstract settings: U2<obj, unit> with get, set
//             abstract isHidden: column: float * ?isLogicIndex: bool -> bool
//             abstract hideColumn: column: float -> unit
//             abstract hideColumns: columns: ResizeArray<obj option> -> unit
//             abstract showColumn: column: float -> unit
//             abstract showColumns: columns: ResizeArray<obj option> -> unit

//         type [<AllowNullLiteral>] HiddenRows =
//             inherit Base
//             abstract hiddenRows: U2<bool, ResizeArray<obj option>> with get, set
//             abstract lastSelectedRow: float with get, set
//             abstract settings: U2<obj, unit> with get, set
//             abstract isHidden: row: float * ?isLogicIndex: bool -> bool
//             abstract hideRow: row: float -> unit
//             abstract hideRows: rows: ResizeArray<obj option> -> unit
//             abstract showRow: row: float -> unit
//             abstract showRows: rows: ResizeArray<obj option> -> unit

//         type [<AllowNullLiteral>] ManualColumnFreeze =
//             inherit Base
//             abstract frozenColumnsBasePositions: ResizeArray<obj option> with get, set
//             abstract manualColumnMovePlugin: ManualColumnMove with get, set
//             abstract freezeColumn: column: float -> unit
//             abstract unfreezeColumn: column: float -> unit

//         type [<AllowNullLiteral>] arrayMapper =
//             abstract getValueByIndex: index: float -> obj option
//             abstract getIndexByValue: value: obj option -> float
//             abstract insertItems: index: float * ?amount: float -> ResizeArray<obj option>
//             abstract removeItems: index: float * ?amount: float -> ResizeArray<obj option>
//             abstract shiftItems: index: float * ?amount: float -> unit
//             abstract unshiftItems: index: float * ?amount: float -> unit

//         type [<AllowNullLiteral>] MoveColumnsMapper =
//             inherit arrayMapper
//             abstract manualColumnMove: ManualColumnMove with get, set
//             abstract clearNull: unit -> unit
//             abstract createMap: ?length: float -> unit
//             abstract destroy: unit -> unit
//             abstract moveColumn: from: float * ``to``: float -> unit

//         type [<AllowNullLiteral>] MoveRowsMapper =
//             inherit arrayMapper
//             abstract manualRowMove: ManualRowMove with get, set
//             abstract clearNull: unit -> unit
//             abstract createMap: ?length: float -> unit
//             abstract destroy: unit -> unit
//             abstract moveColumn: from: float * ``to``: float -> unit

//         type [<AllowNullLiteral>] TrimRowsMapper =
//             inherit arrayMapper
//             abstract trimRows: TrimRows with get, set
//             abstract createMap: ?length: float -> unit
//             abstract destroy: unit -> unit

//         module MoveUI =

//             type [<AllowNullLiteral>] BaseUI =
//                 abstract hot: _Handsontable.Core with get, set
//                 abstract state: float with get, set
//                 abstract appendTo: wrapper: HTMLElement -> unit
//                 abstract build: unit -> unit
//                 abstract destroy: unit -> unit
//                 abstract getOffset: unit -> obj
//                 abstract getPosition: unit -> obj
//                 abstract getSize: unit -> obj
//                 abstract isAppended: unit -> bool
//                 abstract isBuilt: unit -> bool
//                 abstract setOffset: top: float * left: float -> unit
//                 abstract setPosition: top: float * left: float -> unit
//                 abstract setSize: width: float * height: float -> unit

//             type [<AllowNullLiteral>] BacklightUI =
//                 inherit BaseUI

//             type [<AllowNullLiteral>] GuidelineUI =
//                 inherit BaseUI

//         type [<AllowNullLiteral>] MergeCells =
//             inherit Base
//             abstract mergedCellsCollection: MergeCellsPlugin.MergedCellsCollection with get, set
//             abstract autofillCalculations: MergeCellsPlugin.AutofillCalculations with get, set
//             abstract selectionCalculations: MergeCellsPlugin.SelectionCalculations with get, set
//             abstract clearCollections: unit -> unit
//             abstract mergeSelection: cellRange: Wot.CellRange -> unit
//             abstract merge: startRow: float * startColumn: float * endRow: float * endColumn: float -> unit
//             abstract unmerge: startRow: float * startColumn: float * endRow: float * endColumn: float -> unit

//         module MergeCellsPlugin =

//             type [<AllowNullLiteral>] AutofillCalculations =
//                 abstract plugin: MergeCells with get, set
//                 abstract mergedCellsCollection: MergeCellsPlugin.MergedCellsCollection with get, set
//                 abstract currentFillData: obj with get, set
//                 abstract correctSelectionAreaSize: selectionArea: ResizeArray<float> -> unit
//                 abstract getDirection: selectionArea: ResizeArray<float> * finalArea: ResizeArray<float> -> string
//                 abstract snapDragArea: baseArea: ResizeArray<float> * dragArea: ResizeArray<float> * dragDirection: string * foundMergedCells: ResizeArray<MergeCellsPlugin.MergedCellCoords> -> ResizeArray<float>
//                 abstract recreateAfterDataPopulation: changes: ResizeArray<obj option> -> unit
//                 abstract dragAreaOverlapsCollections: baseArea: ResizeArray<float> * fullArea: ResizeArray<float> * direction: string -> bool

//             type [<AllowNullLiteral>] SelectionCalculations =
//                 abstract snapDelta: delta: obj * selectionRange: Wot.CellRange * mergedCell: MergeCellsPlugin.MergedCellCoords -> unit
//                 abstract getUpdatedSelectionRange: oldSelectionRange: Wot.CellRange * delta: obj -> Wot.CellRange

//             type [<AllowNullLiteral>] MergedCellCoords =
//                 abstract row: float with get, set
//                 abstract col: float with get, set
//                 abstract rowspan: float with get, set
//                 abstract colspan: float with get, set
//                 abstract removed: bool with get, set
//                 abstract normalize: hotInstance: _Handsontable.Core -> unit
//                 abstract includes: row: float * column: float -> bool
//                 abstract includesHorizontally: column: float -> bool
//                 abstract includesVertically: row: float -> bool
//                 abstract shift: shiftVector: ResizeArray<float> * indexOfChange: float -> bool
//                 abstract isFarther: mergedCell: MergeCellsPlugin.MergedCellCoords * direction: string -> U2<bool, unit>
//                 abstract getLastRow: unit -> float
//                 abstract getLastColumn: unit -> float
//                 abstract getRange: unit -> Wot.CellRange

//             type [<AllowNullLiteral>] MergedCellsCollection =
//                 abstract plugin: MergeCells with get, set
//                 abstract mergedCells: ResizeArray<MergeCellsPlugin.MergedCellCoords> with get, set
//                 abstract hot: _Handsontable.Core with get, set
//                 abstract get: row: float * column: float -> U2<MergeCellsPlugin.MergedCellCoords, bool>
//                 abstract getByRange: range: U2<Wot.CellRange, obj> -> U2<MergeCellsPlugin.MergedCellCoords, bool>
//                 abstract getWithinRange: range: U2<Wot.CellRange, obj> * countPartials: bool -> U2<ResizeArray<MergeCellsPlugin.MergedCellCoords>, bool>
//                 abstract add: mergedCellInfo: obj -> U2<MergeCellsPlugin.MergedCellCoords, bool>
//                 abstract remove: row: float * column: float -> U2<MergeCellsPlugin.MergedCellCoords, bool>
//                 abstract clear: unit -> unit
//                 abstract isOverlapping: mergedCell: MergeCellsPlugin.MergedCellCoords -> bool
//                 abstract isMergedParent: row: float * column: float -> bool
//                 abstract shiftCollections: direction: string * index: float * count: float -> unit

//         type [<AllowNullLiteral>] ManualColumnMove =
//             inherit Base
//             abstract backlight: MoveUI.BacklightUI with get, set
//             abstract columnsMapper: MoveColumnsMapper with get, set
//             abstract eventManager: EventManager with get, set
//             abstract guideline: MoveUI.GuidelineUI with get, set
//             abstract removedColumns: ResizeArray<obj option> with get, set
//             abstract moveColumn: column: float * target: float -> unit
//             abstract moveColumns: columns: ResizeArray<float> * target: float -> unit

//         type [<AllowNullLiteral>] ManualColumnResize =
//             inherit Base
//             abstract autoresizeTimeout: U2<(unit -> unit), unit> with get, set
//             abstract currentCol: U2<float, unit> with get, set
//             abstract currentTH: U2<HTMLElement, unit> with get, set
//             abstract currentWidth: U2<float, unit> with get, set
//             abstract dblclick: float with get, set
//             abstract eventManager: EventManager with get, set
//             abstract guide: HTMLElement with get, set
//             abstract handle: HTMLElement with get, set
//             abstract manualColumnWidths: ResizeArray<obj option> with get, set
//             abstract newSize: U2<float, unit> with get, set
//             abstract pressed: U2<_Handsontable.Core, unit> with get, set
//             abstract selectedCols: ResizeArray<obj option> with get, set
//             abstract startOffset: U2<float, unit> with get, set
//             abstract startWidth: U2<float, unit> with get, set
//             abstract startY: U2<float, unit> with get, set
//             abstract checkIfColumnHeader: element: HTMLElement -> bool
//             abstract clearManualSize: column: float -> unit
//             abstract getTHFromTargetElement: element: HTMLElement -> HTMLElement
//             abstract hideHandleAndGuide: unit -> unit
//             abstract loadManualColumnWidths: unit -> unit
//             abstract refreshGuidePosition: unit -> unit
//             abstract refreshHandlePosition: unit -> unit
//             abstract saveManualColumnWidths: unit -> unit
//             abstract setManualSize: column: float * width: float -> float
//             abstract setupGuidePosition: unit -> unit
//             abstract setupHandlePosition: TH: HTMLElement -> U2<bool, unit>

//         type [<AllowNullLiteral>] ManualRowMove =
//             inherit Base
//             abstract backlight: MoveUI.BacklightUI with get, set
//             abstract eventManager: EventManager with get, set
//             abstract guideline: MoveUI.GuidelineUI with get, set
//             abstract removedRows: ResizeArray<obj option> with get, set
//             abstract rowsMapper: MoveRowsMapper with get, set
//             abstract moveRow: row: float * target: float -> unit
//             abstract moveRows: rows: ResizeArray<float> * target: float -> unit

//         type [<AllowNullLiteral>] ManualRowResize =
//             inherit Base
//             abstract autoresizeTimeout: U2<(unit -> unit), unit> with get, set
//             abstract currentRow: U2<float, unit> with get, set
//             abstract currentTH: U2<HTMLElement, unit> with get, set
//             abstract currentWidth: U2<float, unit> with get, set
//             abstract dblclick: float with get, set
//             abstract eventManager: EventManager with get, set
//             abstract guide: HTMLElement with get, set
//             abstract handle: HTMLElement with get, set
//             abstract manualRowHeights: ResizeArray<obj option> with get, set
//             abstract newSize: U2<float, unit> with get, set
//             abstract pressed: U2<_Handsontable.Core, unit> with get, set
//             abstract selectedRows: ResizeArray<obj option> with get, set
//             abstract startOffset: U2<float, unit> with get, set
//             abstract startWidth: U2<float, unit> with get, set
//             abstract startY: U2<float, unit> with get, set
//             abstract checkIfRowHeader: element: HTMLElement -> bool
//             abstract clearManualSize: column: float -> unit
//             abstract getTHFromTargetElement: element: HTMLElement -> HTMLElement
//             abstract hideHandleAndGuide: unit -> unit
//             abstract loadManualRowHeights: unit -> unit
//             abstract refreshGuidePosition: unit -> unit
//             abstract refreshHandlePosition: unit -> unit
//             abstract saveManualRowHeights: unit -> unit
//             abstract setManualSize: column: float * width: float -> float
//             abstract setupGuidePosition: unit -> unit
//             abstract setupHandlePosition: TH: HTMLElement -> U2<bool, unit>

//         type [<AllowNullLiteral>] MultipleSelectionHandles =
//             inherit Base
//             abstract dragged: ResizeArray<obj option> with get, set
//             abstract eventManager: EventManager with get, set
//             abstract lastSetCell: U2<HTMLElement, unit> with get, set
//             abstract getCurrentRangeCoords: selectedRange: Wot.CellRange * currentTouch: Wot.CellCoords * touchStartDirection: string * currentDirection: string * draggedHandle: string -> obj
//             abstract isDragged: unit -> bool

//         type [<AllowNullLiteral>] GhostTableNestedHeaders =
//             abstract container: obj option with get, set
//             abstract nestedHeaders: NestedHeaders with get, set
//             abstract widthsCache: ResizeArray<obj option> with get, set
//             abstract clear: unit -> unit

//         type [<AllowNullLiteral>] NestedHeaders =
//             inherit Base
//             abstract colspanArray: ResizeArray<obj option> with get, set
//             abstract columnHeaderLevelCount: float with get, set
//             abstract ghostTable: GhostTableNestedHeaders with get, set
//             abstract settings: ResizeArray<obj option> with get, set
//             abstract checkForFixedColumnsCollision: unit -> unit
//             abstract checkForOverlappingHeaders: unit -> unit
//             abstract getChildHeaders: row: float * column: float -> ResizeArray<obj option>
//             abstract fillColspanArrayWithDummies: colspan: float * level: float -> unit
//             abstract fillTheRemainingColspans: unit -> unit
//             abstract getColspan: row: float * column: float -> float
//             abstract getNestedParent: level: float * column: float -> obj option
//             abstract headerRendererFactory: headerRow: float -> (unit -> unit)
//             abstract levelToRowCoords: level: float -> float
//             abstract rowCoordsToLevel: row: float -> float
//             abstract setupColspanArray: unit -> unit

//         type [<AllowNullLiteral>] DataManager =
//             abstract cache: obj with get, set
//             abstract data: obj with get, set
//             abstract hot: _Handsontable.Core with get, set
//             abstract parentReference: obj option with get, set
//             abstract plugin: NestedRows with get, set
//             abstract addChild: parent: obj * ?element: obj -> unit
//             abstract addChildAtIndex: parent: obj * index: float * ?element: obj * ?globalIndex: float -> unit
//             abstract addSibling: index: float * ?where: string -> unit
//             abstract countAllRows: unit -> float
//             abstract countChildren: parent: U2<obj, float> -> float
//             abstract detachFromParent: elements: U2<obj, ResizeArray<obj option>> * ?forceRender: bool -> unit
//             abstract getDataObject: row: float -> U2<obj option, unit>
//             abstract getRowIndex: rowObj: obj -> U2<float, unit>
//             abstract getRowIndexWithinParent: row: U2<float, obj> -> float
//             abstract getRowLevel: row: float -> U2<float, unit>
//             abstract getRowParent: row: U2<float, obj> -> U2<obj, unit>
//             abstract hasChildren: row: U2<float, obj> -> bool
//             abstract isParent: row: U2<float, obj> -> bool
//             abstract moveRow: fromIndex: float * toIndex: float -> unit
//             abstract rewriteCache: unit -> unit

//         type [<AllowNullLiteral>] NestedRows =
//             inherit Base
//             abstract bindRowsWithHeadersPlugin: U2<BindRowsWithHeaders, unit> with get, set
//             abstract dataManager: U2<DataManager, unit> with get, set
//             abstract headersUI: U2<obj, unit> with get, set
//             abstract sourceData: U2<obj, unit> with get, set
//             abstract trimRowsPlugin: U2<TrimRows, unit> with get, set

//         type [<AllowNullLiteral>] DataObserver =
//             abstract observedData: ResizeArray<obj option> with get, set
//             abstract observer: obj with get, set
//             abstract paused: bool with get, set
//             abstract destroy: unit -> unit
//             abstract isPaused: unit -> bool
//             abstract pause: unit -> unit
//             abstract resume: unit -> unit
//             abstract setObservedData: observedData: obj option -> unit

//         type [<AllowNullLiteral>] ObserveChanges =
//             inherit Base
//             abstract observer: U2<DataObserver, unit> with get, set

//         type [<AllowNullLiteral>] TouchScroll =
//             inherit Base
//             abstract clones: ResizeArray<obj option> with get, set
//             abstract lockedCollection: bool with get, set
//             abstract scrollbars: ResizeArray<obj option> with get, set

//         type [<AllowNullLiteral>] TrimRows =
//             inherit Base
//             abstract trimmedRows: ResizeArray<obj option> with get, set
//             abstract removedRows: ResizeArray<obj option> with get, set
//             abstract rowsMapper: TrimRowsMapper with get, set
//             abstract isTrimmed: row: float -> bool
//             abstract trimRow: row: float -> unit
//             abstract trimRows: rows: ResizeArray<float> -> unit
//             abstract untrimAll: unit -> unit
//             abstract untrimRow: row: float -> unit
//             abstract untrimRows: rows: ResizeArray<float> -> unit

    module Renderers =

        type [<AllowNullLiteral>] Base =
            [<Emit "$0($1...)">] abstract Invoke: instance: _Handsontable.Core * TD: HTMLElement * row: float * col: float * prop: U2<string, float> * value: obj option * cellProperties: GridSettings -> HTMLElement
            [<Emit "$0.apply(this,arguments)">] abstract Apply: unit -> unit

        type [<AllowNullLiteral>] Autocomplete =
            inherit Base

        type [<AllowNullLiteral>] Checkbox =
            inherit Base

        type [<AllowNullLiteral>] Html =
            inherit Base

        type [<AllowNullLiteral>] Numeric =
            inherit Base

        type [<AllowNullLiteral>] Password =
            inherit Base

        type [<AllowNullLiteral>] Text =
            inherit Base

//     type [<AllowNullLiteral>] DefaultSettings =
//         inherit GridSettings
//         inherit Hooks

    type [<AllowNullLiteral>] GridSettings =
//         inherit Hooks
//         abstract allowEmpty: bool option with get, set
//         abstract allowHtml: bool option with get, set
//         abstract allowInsertColumn: bool option with get, set
        // abstract allowInsertRow: bool option with get, set
        abstract allowInvalid: bool option with get, set
//         abstract allowRemoveColumn: bool option with get, set
        // abstract allowRemoveRow: bool option with get, set
//         abstract autoColumnSize: U2<obj, bool> option with get, set
//         abstract autoComplete: ResizeArray<obj option> option with get, set
//         abstract autoRowSize: U2<obj, bool> option with get, set
//         abstract autoWrapCol: bool option with get, set
//         abstract autoWrapRow: bool option with get, set
//         abstract bindRowsWithHeaders: U2<bool, string> option with get, set
//         abstract cell: ResizeArray<obj option> option with get, set
        // abstract cells: (float -> float -> obj -> GridSettings) option with get, set
//         abstract checkedTemplate: U2<bool, string> option with get, set
//         abstract className: U2<string, ResizeArray<obj option>> option with get, set
//         abstract colHeaders: U3<(float -> unit), bool, ResizeArray<obj option>> option with get, set
//         abstract collapsibleColumns: U2<bool, ResizeArray<obj option>> option with get, set
//         abstract columnHeaderHeight: U2<float, ResizeArray<obj option>> option with get, set
//         abstract columns: U2<(float -> unit), ResizeArray<obj option>> option with get, set
//         abstract columnSorting: U2<bool, obj> option with get, set
//         abstract columnSummary: obj option with get, set
//         abstract colWidths: U4<(float -> unit), float, string, ResizeArray<obj option>> option with get, set
//         abstract commentedCellClassName: string option with get, set
//         abstract comments: U2<bool, ResizeArray<CommentObject>> option with get, set
        // abstract contextMenu: U3<bool, ResizeArray<obj option>, ContextMenu.Settings> option with get, set
//         abstract contextMenuCopyPaste: obj option with get, set
//         abstract copyable: bool option with get, set
//         abstract copyColsLimit: float option with get, set
//         abstract copyPaste: bool option with get, set
//         abstract copyRowsLimit: float option with get, set
//         abstract correctFormat: bool option with get, set
//         abstract currentColClassName: string option with get, set
//         abstract currentHeaderClassName: string option with get, set
//         abstract currentRowClassName: string option with get, set
//         abstract customBorders: U2<bool, ResizeArray<obj option>> option with get, set
//         abstract data: U2<obj option, ResizeArray<obj option>> option with get, set
//         abstract dataSchema: obj option with get, set
//         abstract dateFormat: string option with get, set
//         abstract numericFormat: obj option with get, set
//         abstract debug: bool option with get, set
//         abstract defaultDate: string option with get, set
//         abstract disableVisualSelection: U3<bool, string, ResizeArray<obj option>> option with get, set
//         abstract dropdownMenu: U3<bool, obj, ResizeArray<obj option>> option with get, set
//         abstract editor: U3<string, (unit -> unit), bool> option with get, set
//         abstract enterBeginsEditing: bool option with get, set
//         abstract enterMoves: U2<obj, (unit -> unit)> option with get, set
//         abstract fillHandle: U3<bool, string, obj> option with get, set
//         abstract filter: bool option with get, set
//         abstract filteringCaseSensitive: bool option with get, set
//         abstract filters: bool option with get, set
//         abstract fixedColumnsLeft: float option with get, set
//         abstract fixedRowsBottom: float option with get, set
//         abstract fixedRowsTop: float option with get, set
//         abstract fragmentSelection: U2<bool, string> option with get, set
//         abstract ganttChart: obj option with get, set
//         abstract headerTooltips: U2<bool, obj> option with get, set
//         abstract height: U2<float, (unit -> unit)> option with get, set
//         abstract hiddenColumns: U2<bool, obj> option with get, set
//         abstract hiddenRows: U2<bool, obj> option with get, set
        abstract invalidCellClassName: string option with get, set
//         abstract isEmptyCol: (float -> bool) option with get, set
//         abstract isEmptyRow: (float -> bool) option with get, set
//         abstract label: obj option with get, set
//         abstract language: string option with get, set
//         abstract manualColumnFreeze: bool option with get, set
//         abstract manualColumnMove: U2<bool, ResizeArray<obj option>> option with get, set
//         abstract manualColumnResize: U2<bool, ResizeArray<obj option>> option with get, set
//         abstract manualRowMove: U2<bool, ResizeArray<obj option>> option with get, set
//         abstract manualRowResize: U2<bool, ResizeArray<obj option>> option with get, set
//         abstract maxCols: float option with get, set
//         abstract maxRows: float option with get, set
//         abstract mergeCells: U2<bool, ResizeArray<obj option>> option with get, set
//         abstract minCols: float option with get, set
        abstract minRows: float option with get, set
//         abstract minSpareCols: float option with get, set
//         abstract minSpareRows: float option with get, set
//         abstract selectionMode: U3<string, string, string> option with get, set
//         abstract nestedHeaders: ResizeArray<obj option> option with get, set
//         abstract noWordWrapClassName: string option with get, set
//         abstract observeChanges: bool option with get, set
//         abstract observeDOMVisibility: bool option with get, set
//         abstract outsideClickDeselects: bool option with get, set
//         abstract pasteMode: string option with get, set
//         abstract persistentState: bool option with get, set
//         abstract placeholder: obj option option with get, set
//         abstract placeholderCellClassName: string option with get, set
//         abstract preventOverflow: U2<string, bool> option with get, set
//         abstract readOnly: bool option with get, set
//         abstract readOnlyCellClassName: string option with get, set
//         abstract renderAllRows: bool option with get, set
        abstract renderer: U2<string, (unit -> unit)> option with get, set
//         abstract rowHeaders: U3<bool, ResizeArray<obj option>, (unit -> unit)> option with get, set
//         abstract rowHeaderWidth: U2<float, ResizeArray<obj option>> option with get, set
//         abstract rowHeights: U4<ResizeArray<obj option>, (unit -> unit), float, string> option with get, set
//         abstract search: bool option with get, set
//         abstract selectOptions: ResizeArray<obj option> option with get, set
//         abstract skipColumnOnPaste: bool option with get, set
//         abstract sortByRelevance: bool option with get, set
//         abstract sortFunction: (unit -> unit) option with get, set
//         abstract sortIndicator: bool option with get, set
        abstract source: U2<ResizeArray<obj option>, (unit -> unit)> option with get, set
//         abstract startCols: float option with get, set
//         abstract startRows: float option with get, set
//         abstract stretchH: string option with get, set
//         abstract strict: bool option with get, set
//         abstract tableClassName: U2<string, ResizeArray<obj option>> option with get, set
//         abstract tabMoves: obj option with get, set
//         abstract title: string option with get, set
//         abstract trimDropdown: bool option with get, set
//         abstract trimRows: bool option with get, set
//         abstract trimWhitespace: bool option with get, set
        abstract ``type``: string option with get, set
//         abstract uncheckedTemplate: U2<bool, string> option with get, set
//         abstract undo: bool option with get, set
//         abstract valid: bool option with get, set
//         abstract validator: U2<(unit -> unit), RegExp> option with get, set
//         abstract viewportColumnRenderingOffset: U2<float, string> option with get, set
//         abstract viewportRowRenderingOffset: U2<float, string> option with get, set
//         abstract visibleRows: float option with get, set
//         abstract width: U2<float, (unit -> unit)> option with get, set
//         abstract wordWrap: bool option with get, set

//    type [<AllowNullLiteral>] Hooks =
//         abstract afterAddChild: (obj -> U2<obj, unit> -> U2<float, unit> -> unit) option with get, set
//         abstract afterBeginEdting: (float -> float -> unit) option with get, set
//         abstract afterCellMetaReset: (unit -> unit) option with get, set
//        abstract afterChange: (ResizeArray<obj option> -> string -> unit) option with get, set
//         abstract afterChangesObserved: (unit -> unit) option with get, set
//         abstract afterColumnMove: (float -> float -> unit) option with get, set
//         abstract afterColumnResize: (float -> float -> bool -> unit) option with get, set
//         abstract afterColumnSort: (float -> bool -> unit) option with get, set
//         abstract afterContextMenuDefaultOptions: (ResizeArray<obj option> -> unit) option with get, set
//         abstract afterContextMenuHide: (obj -> unit) option with get, set
//         abstract afterContextMenuShow: (obj -> unit) option with get, set
//         abstract afterCopy: (ResizeArray<obj option> -> ResizeArray<obj option> -> unit) option with get, set
//         abstract afterCopyLimit: (float -> float -> float -> float -> unit) option with get, set
//         abstract afterCreateCol: (float -> float -> unit) option with get, set
//         abstract afterCreateRow: (float -> float -> unit) option with get, set
//         abstract afterCut: (ResizeArray<obj option> -> ResizeArray<obj option> -> unit) option with get, set
//         abstract afterDeselect: (unit -> unit) option with get, set
//         abstract afterDestroy: (unit -> unit) option with get, set
//         abstract afterDetachChild: (obj -> obj -> unit) option with get, set
//         abstract afterDocumentKeyDown: (Event -> unit) option with get, set
//         abstract afterDropdownMenuDefaultOptions: (ResizeArray<obj option> -> unit) option with get, set
//         abstract afterDropdownMenuHide: (obj option -> unit) option with get, set
//         abstract afterDropdownMenuShow: (obj option -> unit) option with get, set
//         abstract afterFilter: (ResizeArray<obj option> -> unit) option with get, set
//         abstract afterGetCellMeta: (float -> float -> obj -> unit) option with get, set
//         abstract afterGetColHeader: (float -> Element -> unit) option with get, set
//         abstract afterGetColumnHeaderRenderers: (ResizeArray<obj option> -> unit) option with get, set
//         abstract afterGetRowHeader: (float -> Element -> unit) option with get, set
//         abstract afterGetRowHeaderRenderers: (ResizeArray<obj option> -> unit) option with get, set
//         abstract afterInit: (unit -> unit) option with get, set
//         abstract afterLoadData: (bool -> unit) option with get, set
//         abstract afterModifyTransformEnd: (Wot.CellCoords -> float -> float -> unit) option with get, set
//         abstract afterModifyTransformStart: (Wot.CellCoords -> float -> float -> unit) option with get, set
//         abstract afterMomentumScroll: (unit -> unit) option with get, set
//         abstract afterOnCellCornerDblClick: (obj -> unit) option with get, set
//         abstract afterOnCellCornerMouseDown: (obj -> unit) option with get, set
//         abstract afterOnCellMouseDown: (obj -> obj -> Element -> unit) option with get, set
//         abstract afterOnCellMouseOver: (obj -> obj -> Element -> unit) option with get, set
//         abstract afterOnCellMouseOut: (obj -> obj -> Element -> unit) option with get, set
//         abstract afterPaste: (ResizeArray<obj option> -> ResizeArray<obj option> -> unit) option with get, set
//         abstract afterPluginsInitialized: (unit -> unit) option with get, set
//         abstract afterRedo: (obj -> unit) option with get, set
//         abstract afterRemoveCol: (float -> float -> unit) option with get, set
//         abstract afterRemoveRow: (float -> float -> unit) option with get, set
//         abstract afterRender: (bool -> unit) option with get, set
//         abstract afterRenderer: (Element -> float -> float -> U2<string, float> -> string -> obj -> unit) option with get, set
//         abstract afterRowMove: (float -> float -> unit) option with get, set
//         abstract afterRowResize: (float -> float -> bool -> unit) option with get, set
//         abstract afterScrollHorizontally: (unit -> unit) option with get, set
//         abstract afterScrollVertically: (unit -> unit) option with get, set
//         abstract afterSelection: (float -> float -> float -> float -> obj -> float -> unit) option with get, set
//         abstract afterSelectionByProp: (float -> string -> float -> string -> obj -> float -> unit) option with get, set
//         abstract afterSelectionEnd: (float -> float -> float -> float -> float -> unit) option with get, set
//         abstract afterSelectionEndByProp: (float -> string -> float -> string -> float -> unit) option with get, set
//         abstract afterSetCellMeta: (float -> float -> string -> obj option -> unit) option with get, set
//         abstract afterSetDataAtCell: (ResizeArray<obj option> -> string -> unit) option with get, set
//         abstract afterSetDataAtRowProp: (ResizeArray<obj option> -> string -> unit) option with get, set
//         abstract afterTrimRow: (ResizeArray<obj option> -> unit) option with get, set
//         abstract afterUndo: (obj -> unit) option with get, set
//         abstract afterUntrimRow: (ResizeArray<obj option> -> unit) option with get, set
//         abstract afterUpdateSettings: (unit -> unit) option with get, set
//         abstract afterValidate: (bool -> obj option -> float -> U2<string, float> -> string -> U2<unit, bool>) option with get, set
//         abstract afterViewportColumnCalculatorOverride: (obj -> unit) option with get, set
//         abstract afterViewportRowCalculatorOverride: (obj -> unit) option with get, set
//         abstract beforeAddChild: (obj -> U2<obj, unit> -> U2<float, unit> -> unit) option with get, set
//         abstract beforeAutofill: (obj -> obj -> ResizeArray<obj option> -> unit) option with get, set
//         abstract beforeAutofillInsidePopulate: (obj -> string -> ResizeArray<obj option> -> ResizeArray<obj option> -> unit) option with get, set
//         abstract beforeCellAlignment: (obj option -> obj option -> string -> string -> unit) option with get, set
//         abstract beforeChange: (ResizeArray<obj option> -> string -> unit) option with get, set
//         abstract beforeChangeRender: (ResizeArray<obj option> -> string -> unit) option with get, set
//         abstract beforeColumnMove: (float -> float -> unit) option with get, set
//         abstract beforeColumnResize: (float -> float -> bool -> unit) option with get, set
//         abstract beforeColumnSort: (float -> bool -> unit) option with get, set
//         abstract beforeContextMenuSetItems: (ResizeArray<obj option> -> unit) option with get, set
//         abstract beforeCopy: (ResizeArray<obj option> -> ResizeArray<obj option> -> obj option) option with get, set
//         abstract beforeCreateCol: (float -> float -> string -> unit) option with get, set
//         abstract beforeCreateRow: (float -> float -> string -> unit) option with get, set
//         abstract beforeCut: (ResizeArray<obj option> -> ResizeArray<obj option> -> obj option) option with get, set
//         abstract beforeDetachChild: (obj -> obj -> unit) option with get, set
//         abstract beforeDrawBorders: (ResizeArray<obj option> -> string -> unit) option with get, set
//         abstract beforeDropdownMenuSetItems: (ResizeArray<obj option> -> unit) option with get, set
//         abstract beforeFilter: (ResizeArray<obj option> -> unit) option with get, set
//         abstract beforeGetCellMeta: (float -> float -> obj -> unit) option with get, set
//         abstract beforeInit: (unit -> unit) option with get, set
//         abstract beforeInitWalkontable: (obj -> unit) option with get, set
//         abstract beforeKeyDown: (Event -> unit) option with get, set
//         abstract beforeOnCellMouseDown: (Event -> obj -> Element -> unit) option with get, set
//         abstract beforeOnCellMouseOut: (Event -> Wot.CellCoords -> Element -> unit) option with get, set
//         abstract beforeOnCellMouseOver: (Event -> Wot.CellCoords -> Element -> obj -> unit) option with get, set
//         abstract beforePaste: (ResizeArray<obj option> -> ResizeArray<obj option> -> obj option) option with get, set
//         abstract beforeRedo: (obj -> unit) option with get, set
//         abstract beforeRemoveCol: (float -> float -> ResizeArray<obj option> -> unit) option with get, set
//         abstract beforeRemoveRow: (float -> float -> ResizeArray<obj option> -> unit) option with get, set
//         abstract beforeRender: (bool -> obj -> unit) option with get, set
//         abstract beforeRenderer: (Element -> float -> float -> U2<string, float> -> string -> obj -> unit) option with get, set
//         abstract beforeRowMove: (float -> float -> unit) option with get, set
//         abstract beforeRowResize: (float -> float -> bool -> obj option) option with get, set
//         abstract beforeSetRangeEnd: (Wot.CellCoords -> unit) option with get, set
//         abstract beforeSetRangeStart: (Wot.CellCoords -> unit) option with get, set
//         abstract beforeStretchingColumnWidth: (float -> float -> unit) option with get, set
//         abstract beforeTouchScroll: (unit -> unit) option with get, set
//         abstract beforeUndo: (obj -> unit) option with get, set
//         abstract beforeValidate: (obj option -> float -> U2<string, float> -> string -> unit) option with get, set
//         abstract beforeValueRender: (obj option -> obj -> unit) option with get, set
//         abstract construct: (unit -> unit) option with get, set
//         abstract hiddenColumn: (float -> unit) option with get, set
//         abstract hiddenRow: (float -> unit) option with get, set
//         abstract init: (unit -> unit) option with get, set
//         abstract manualRowHeights: (ResizeArray<obj option> -> unit) option with get, set
//         abstract modifyAutofillRange: (ResizeArray<obj option> -> ResizeArray<obj option> -> unit) option with get, set
//         abstract modifyCol: (float -> unit) option with get, set
//         abstract modifyColHeader: (float -> unit) option with get, set
//         abstract modifyColWidth: (float -> float -> unit) option with get, set
//         abstract modifyCopyableRange: (ResizeArray<obj option> -> unit) option with get, set
//         abstract modifyData: (float -> float -> obj -> string -> unit) option with get, set
//         abstract modifyRow: (float -> unit) option with get, set
//         abstract modifyRowHeader: (float -> unit) option with get, set
//         abstract modifyRowHeaderWidth: (float -> unit) option with get, set
//         abstract modifyRowHeight: (float -> float -> unit) option with get, set
//         abstract modifyRowSourceData: (float -> unit) option with get, set
//         abstract modifyTransformEnd: (Wot.CellCoords -> unit) option with get, set
//         abstract modifyTransformStart: (Wot.CellCoords -> unit) option with get, set
//         abstract persistentStateLoad: (string -> obj -> unit) option with get, set
//         abstract persistentStateReset: (string -> unit) option with get, set
//         abstract persistentStateSave: (string -> obj option -> unit) option with get, set
//         abstract skipLengthCache: (float -> unit) option with get, set
//         abstract unmodifyCol: (float -> unit) option with get, set
//         abstract unmodifyRow: (float -> unit) option with get, set

//     type [<AllowNullLiteral>] CellTypes =
//         abstract autocomplete: CellTypes.Autocomplete with get, set
//         abstract checkbox: CellTypes.Checkbox with get, set
//         abstract date: CellTypes.Date with get, set
//         abstract dropdown: CellTypes.Dropdown with get, set
//         abstract handsontable: CellTypes.Handsontable with get, set
//         abstract numeric: CellTypes.Numeric with get, set
//         abstract password: CellTypes.Password with get, set
//         abstract text: CellTypes.Text with get, set
//         abstract time: CellTypes.Time with get, set

//     type [<AllowNullLiteral>] Editors =
//         abstract AutocompleteEditor: obj with get, set
//         abstract BaseEditor: obj with get, set
//         abstract CheckboxEditor: obj with get, set
//         abstract DateEditor: obj with get, set
//         abstract DropdownEditor: obj with get, set
//         abstract HandsontableEditor: obj with get, set
//         abstract MobileEditor: obj with get, set
//         abstract NumericEditor: obj with get, set
//         abstract PasswordEditor: obj with get, set
//         abstract SelectEditor: obj with get, set
//         abstract TextEditor: obj with get, set
//         abstract getEditor: (string -> Handsontable -> obj option) with get, set
//         abstract registerEditor: (string -> obj option -> unit) with get, set

    type [<AllowNullLiteral>] Renderers =
        abstract AutocompleteRenderer: Renderers.Autocomplete with get, set
        abstract BaseRenderer: Renderers.Base with get, set
        abstract CheckboxRenderer: Renderers.Checkbox with get, set
        abstract HtmlRenderer: Renderers.Html with get, set
        abstract NumericRenderer: Renderers.Numeric with get, set
        abstract PasswordRenderer: Renderers.Password with get, set
        abstract TextRenderer: Renderers.Text with get, set

//     type [<AllowNullLiteral>] Helper =
//         abstract KEY_CODES: obj
//         abstract arrayAvg: array: ResizeArray<obj option> -> float
//         abstract arrayEach: array: ResizeArray<obj option> * iteratee: (obj option -> float -> ResizeArray<obj option> -> unit) -> ResizeArray<obj option>
//         abstract arrayFilter: array: ResizeArray<obj option> * predicate: (obj option -> float -> ResizeArray<obj option> -> unit) -> ResizeArray<obj option>
//         abstract arrayFlatten: array: ResizeArray<obj option> -> ResizeArray<obj option>
//         abstract arrayIncludes: array: ResizeArray<obj option> * searchElement: obj option * fromIndex: float -> ResizeArray<obj option>
//         abstract arrayMap: array: ResizeArray<obj option> * iteratee: (obj option -> float -> ResizeArray<obj option> -> unit) -> ResizeArray<obj option>
//         abstract arrayMax: array: ResizeArray<obj option> -> float
//         abstract arrayMin: array: ResizeArray<obj option> -> float
//         abstract arrayReduce: array: ResizeArray<obj option> * iteratee: (obj option -> float -> ResizeArray<obj option> -> unit) * accumulator: obj option * initFromArray: bool -> obj option
//         abstract arraySum: array: ResizeArray<obj option> -> float
//         abstract arrayUnique: array: ResizeArray<obj option> -> ResizeArray<obj option>
//         abstract cancelAnimationFrame: id: float -> unit
//         abstract cellMethodLookupFactory: methodName: string * allowUndefined: bool -> unit
//         abstract clone: ``object``: obj -> obj
//         abstract columnFactory: GridSettings: GridSettings * conflictList: ResizeArray<obj option> -> obj
//         abstract createEmptySpreadsheetData: rows: float * columns: float -> ResizeArray<obj option>
//         abstract createObjectPropListener: ?defaultValue: obj option * ?propertyToListen: string -> obj
//         abstract createSpreadsheetData: ?rows: float * ?columns: float -> ResizeArray<obj option>
//         abstract createSpreadsheetObjectData: ?rows: float * ?colCount: float -> ResizeArray<obj option>
//         abstract curry: func: (unit -> unit) -> (unit -> unit)
//         abstract curryRight: func: (unit -> unit) -> (unit -> unit)
//         abstract debounce: func: (unit -> unit) * ?wait: float -> (unit -> unit)
//         abstract deepClone: obj: obj -> obj
//         abstract deepExtend: target: obj * extension: obj -> unit
//         abstract deepObjectSize: ``object``: obj -> float
//         abstract defineGetter: ``object``: obj * property: obj option * value: obj option * options: obj -> unit
//         abstract duckSchema: ``object``: U2<ResizeArray<obj option>, obj> -> U2<ResizeArray<obj option>, obj>
//         abstract endsWith: string: string * needle: string -> bool
//         abstract equalsIgnoreCase: [<ParamArray>] string: ResizeArray<string> -> bool
//         abstract extend: target: obj * extension: obj -> unit
//         abstract extendArray: arr: ResizeArray<obj option> * extension: ResizeArray<obj option> -> unit
//         abstract getComparisonFunction: language: string * ?options: obj -> U2<obj option, unit>
//         abstract getNormalizedDate: dateString: string -> DateTime
//         abstract getProperty: ``object``: obj * name: string -> U2<obj option, unit>
//         abstract getPrototypeOf: obj: obj -> U2<obj option, unit>
//         abstract hasCaptionProblem: unit -> U2<bool, unit>
//         abstract ``inherit``: Child: obj * Parent: obj -> obj
//         abstract isChrome: unit -> bool
//         abstract isCtrlKey: keyCode: float -> bool
//         abstract isDefined: variable: obj option -> bool
//         abstract isEmpty: variable: obj option -> bool
//         abstract isFunction: func: obj option -> bool
//         abstract isIE8: unit -> bool
//         abstract isIE9: unit -> bool
//         abstract isKey: keyCode: float * baseCode: string -> bool
//         abstract isMetaKey: keyCode: float -> bool
//         abstract isMobileBrowser: ?userAgent: string -> bool
//         abstract isNumeric: n: obj option -> bool
//         abstract isObject: obj: obj option -> bool
//         abstract isObjectEqual: object1: U2<obj, ResizeArray<obj option>> * object2: U2<obj, ResizeArray<obj option>> -> bool
//         abstract isPercentValue: value: string -> bool
//         abstract isPrintableChar: keyCode: float -> bool
//         abstract isSafari: unit -> bool
//         abstract isTouchSupported: unit -> bool
//         abstract isUndefined: variable: obj option -> bool
//         abstract isWebComponentSupportedNatively: unit -> bool
//         abstract ``mixin``: Base: obj * [<ParamArray>] mixins: ResizeArray<obj> -> obj
//         abstract objectEach: ``object``: obj * iteratee: (obj option -> obj option -> obj -> unit) -> obj
//         abstract padStart: string: string * maxLength: float * ?fillString: string -> string
//         abstract partial: func: (unit -> unit) * [<ParamArray>] ``params``: ResizeArray<obj option> -> (unit -> unit)
//         abstract pipe: [<ParamArray>] functions: ResizeArray<(unit -> unit)> -> (unit -> unit)
//         abstract pivot: arr: ResizeArray<obj option> -> ResizeArray<obj option>
//         abstract randomString: unit -> string
//         abstract rangeEach: rangeFrom: float * rangeTo: float * iteratee: (float -> unit) -> unit
//         abstract rangeEachReverse: rangeFrom: float * rangeTo: float * iteratee: (float -> unit) -> unit
//         abstract requestAnimationFrame: callback: (unit -> unit) -> float
//         abstract spreadsheetColumnIndex: label: string -> float
//         abstract spreadsheetColumnLabel: index: float -> string
//         abstract startsWith: string: string * needle: string -> bool
//         abstract stringify: value: obj option -> string
//         abstract stripTags: string: string -> string
//         abstract substitute: template: string * ?variables: obj -> string
//         abstract throttle: func: (unit -> unit) * ?wait: float -> (unit -> unit)
//         abstract throttleAfterHits: func: (unit -> unit) * ?wait: float * ?hits: float -> (unit -> unit)
//         abstract to2dArray: arr: ResizeArray<obj option> -> unit
//         abstract toUpperCaseFirst: string: string -> string
//         abstract translateRowsToColumns: input: ResizeArray<obj option> -> ResizeArray<obj option>
//         abstract valueAccordingPercent: value: float * percent: U2<string, float> -> float

//     type [<AllowNullLiteral>] Dom =
//         abstract HTML_CHARACTERS: RegExp with get, set
//         abstract addClass: (HTMLElement -> U2<string, ResizeArray<obj option>> -> unit) with get, set
//         abstract addEvent: (HTMLElement -> string -> (unit -> unit) -> unit) with get, set
//         abstract closest: (HTMLElement -> ResizeArray<obj option> -> HTMLElement -> U2<HTMLElement, unit>) with get, set
//         abstract closestDown: (HTMLElement -> ResizeArray<obj option> -> HTMLElement -> U2<HTMLElement, unit>) with get, set
//         abstract empty: (HTMLElement -> unit) with get, set
//         abstract fastInnerHTML: (HTMLElement -> string -> unit) with get, set
//         abstract fastInnerText: (HTMLElement -> string -> unit) with get, set
//         abstract getCaretPosition: (HTMLElement -> float) with get, set
//         abstract getComputedStyle: (HTMLElement -> U2<CSSStyleDeclaration, obj>) with get, set
//         abstract getCssTransform: (HTMLElement -> U2<float, unit>) with get, set
//         abstract getParent: (HTMLElement -> float -> U2<HTMLElement, unit>) with get, set
//         abstract getScrollLeft: (HTMLElement -> float) with get, set
//         abstract getScrollTop: (HTMLElement -> float) with get, set
//         abstract getScrollableElement: (HTMLElement -> HTMLElement) with get, set
//         abstract getScrollbarWidth: (unit -> float) with get, set
//         abstract getSelectionEndPosition: (HTMLElement -> float) with get, set
//         abstract getSelectionText: (unit -> string) with get, set
//         abstract getStyle: (HTMLElement -> string -> string) with get, set
//         abstract getTrimmingContainer: (HTMLElement -> HTMLElement) with get, set
//         abstract getWindowScrollLeft: (unit -> float) with get, set
//         abstract getWindowScrollTop: (unit -> float) with get, set
//         abstract hasClass: (HTMLElement -> string -> bool) with get, set
//         abstract hasHorizontalScrollbar: (HTMLElement -> bool) with get, set
//         abstract hasVerticalScrollbar: (HTMLElement -> bool) with get, set
//         abstract index: (Element -> float) with get, set
//         abstract innerHeight: (HTMLElement -> float) with get, set
//         abstract innerWidth: (HTMLElement -> float) with get, set
//         abstract isChildOf: (HTMLElement -> U2<obj, string> -> bool) with get, set
//         abstract isChildOfWebComponentTable: (Element -> bool) with get, set
//         abstract isImmediatePropagationStopped: (Event -> bool) with get, set
//         abstract isInput: (HTMLElement -> bool) with get, set
//         abstract isLeftClick: (Event -> bool) with get, set
//         abstract isOutsideInput: (HTMLElement -> bool) with get, set
//         abstract isRightClick: (Event -> bool) with get, set
//         abstract isVisible: (HTMLElement -> bool) with get, set
//         abstract offset: (HTMLElement -> obj) with get, set
//         abstract outerHeight: (HTMLElement -> float) with get, set
//         abstract outerWidth: (HTMLElement -> float) with get, set
//         abstract overlayContainsElement: (string -> HTMLElement -> bool) with get, set
//         abstract pageX: (Event -> float) with get, set
//         abstract pageY: (Event -> float) with get, set
//         abstract polymerUnwrap: (HTMLElement -> U2<obj option, unit>) with get, set
//         abstract polymerWrap: (HTMLElement -> U2<obj option, unit>) with get, set
//         abstract removeClass: (HTMLElement -> U2<string, ResizeArray<obj option>> -> unit) with get, set
//         abstract removeEvent: (HTMLElement -> string -> (unit -> unit) -> unit) with get, set
//         abstract removeTextNodes: (HTMLElement -> HTMLElement -> unit) with get, set
//         abstract resetCssTransform: (HTMLElement -> unit) with get, set
//         abstract setCaretPosition: (HTMLElement -> float -> float -> unit) with get, set
//         abstract setOverlayPosition: (HTMLElement -> float -> float -> unit) with get, set
//         abstract stopImmediatePropagation: (Event -> unit) with get, set
//         abstract stopPropagation: (Event -> unit) with get, set

//     type [<AllowNullLiteral>] Plugins =
//         abstract AutoColumnSize: Plugins.AutoColumnSize with get, set
//         abstract AutoRowSize: Plugins.AutoRowSize with get, set
//         abstract Autofill: Plugins.Autofill with get, set
//         abstract BasePlugin: Plugins.Base with get, set
//         abstract BindRowsWithHeaders: Plugins.BindRowsWithHeaders with get, set
//         abstract CollapsibleColumns: Plugins.CollapsibleColumns with get, set
//         abstract ColumnSorting: Plugins.ColumnSorting with get, set
//         abstract ColumnSummary: Plugins.ColumnSummary with get, set
//         abstract Comments: Plugins.Comments with get, set
//         abstract ContextMenu: Plugins.ContextMenu with get, set
//         abstract CopyPaste: Plugins.CopyPaste with get, set
//         abstract DragToScroll: Plugins.DragToScroll with get, set
//         abstract DropdownMenu: Plugins.DropdownMenu with get, set
//         abstract ExportFile: Plugins.ExportFile with get, set
//         abstract Filters: Plugins.Filters with get, set
//         abstract Formulas: Plugins.Formulas with get, set
//         abstract GanttChart: Plugins.GanttChart with get, set
//         abstract HeaderTooltips: Plugins.HeaderTooltips with get, set
//         abstract HiddenColumns: Plugins.HiddenColumns with get, set
//         abstract HiddenRows: Plugins.HiddenRows with get, set
//         abstract ManualColumnFreeze: Plugins.ManualColumnFreeze with get, set
//         abstract ManualColumnMove: Plugins.ManualColumnMove with get, set
//         abstract ManualColumnResize: Plugins.ManualColumnResize with get, set
//         abstract ManualRowMove: Plugins.ManualRowMove with get, set
//         abstract ManualRowResize: Plugins.ManualRowResize with get, set
//         abstract MergeCells: Plugins.MergeCells with get, set
//         abstract MultipleSelectionHandles: Plugins.MultipleSelectionHandles with get, set
//         abstract NestedHeaders: Plugins.NestedHeaders with get, set
//         abstract NestedRows: Plugins.NestedRows with get, set
//         abstract ObserveChanges: Plugins.ObserveChanges with get, set
//         abstract TouchScroll: Plugins.TouchScroll with get, set
//         abstract TrimRows: Plugins.TrimRows with get, set
//         abstract registerPlugin: (unit -> unit) with get, set

//     type [<AllowNullLiteral>] CommentObject =
//         abstract row: float with get, set
//         abstract col: float with get, set
//         abstract comment: obj option with get, set

//     module ContextMenu =

//         type [<AllowNullLiteral>] Options =
//             abstract start: Wot.CellCoords with get, set
//             abstract ``end``: Wot.CellCoords with get, set

//         type [<AllowNullLiteral>] Settings =
//             abstract callback: (string -> ContextMenu.Options -> unit) with get, set
//             abstract items: obj option with get, set

type [<AllowNullLiteral>] Handsontable =
    // inherit _Handsontable.Core
//     abstract baseVersion: string with get, set
//     abstract buildDate: string with get, set
//     abstract cellTypes: Handsontable.CellTypes with get, set
//     abstract dom: Handsontable.Dom with get, set
//     abstract editors: Handsontable.Editors with get, set
//     abstract helper: Handsontable.Helper with get, set
//     abstract hooks: Handsontable.Hooks with get, set
//     abstract plugins: Handsontable.Plugins with get, set
    abstract renderers: Handsontable.Renderers with get, set
//     abstract version: string with get, set

type [<AllowNullLiteral>] HandsontableStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Handsontable
