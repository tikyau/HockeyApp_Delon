using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Xml;

[assembly: global::System.Reflection.AssemblyVersion("4.0.0.0")]



namespace System.Runtime.Serialization.Generated
{
    [global::System.Runtime.CompilerServices.__BlockReflection]
    public static partial class DataContractSerializerHelper
    {
        public static void InitDataContracts()
        {
            global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Runtime.Serialization.DataContract> dataContracts = global::System.Runtime.Serialization.DataContract.GetDataContracts();
            PopulateContractDictionary(dataContracts);
            global::System.Collections.Generic.Dictionary<global::System.Runtime.Serialization.DataContract, global::System.Runtime.Serialization.Json.JsonReadWriteDelegates> jsonDelegates = global::System.Runtime.Serialization.Json.JsonReadWriteDelegates.GetJsonDelegates();
            PopulateJsonDelegateDictionary(
                                dataContracts, 
                                jsonDelegates
                            );
        }
        static int[] s_knownContractsLists = new int[] {
              -1, }
        ;
        // Count = 192
        static int[] s_xmlDictionaryStrings = new int[] {
                0, // array length: 0
                11, // array length: 11
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                11, // array length: 11
                566, // index: 566, string: "app_id"
                573, // index: 573, string: "appsize"
                581, // index: 581, string: "device_family"
                595, // index: 595, string: "id"
                598, // index: 598, string: "mandatory"
                608, // index: 608, string: "minimum_os_version"
                627, // index: 627, string: "notes"
                633, // index: 633, string: "shortversion"
                646, // index: 646, string: "timestamp"
                656, // index: 656, string: "title"
                662, // index: 662, string: "version"
                11, // array length: 11
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                3, // array length: 3
                670, // index: 670, string: "auid"
                675, // index: 675, string: "iuid"
                680, // index: 680, string: "status"
                3, // array length: 3
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                6, // array length: 6
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                6, // array length: 6
                687, // index: 687, string: "contact"
                695, // index: 695, string: "description"
                707, // index: 707, string: "log"
                711, // index: 711, string: "sdk"
                715, // index: 715, string: "sdk_version"
                727, // index: 727, string: "userID"
                6, // array length: 6
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                3, // array length: 3
                734, // index: 734, string: "feedback"
                680, // index: 680, string: "status"
                743, // index: 743, string: "token"
                3, // array length: 3
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                7, // array length: 7
                749, // index: 749, string: "created_at"
                760, // index: 760, string: "email"
                595, // index: 595, string: "id"
                766, // index: 766, string: "messages"
                775, // index: 775, string: "name"
                680, // index: 680, string: "status"
                743, // index: 743, string: "token"
                7, // array length: 7
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                18, // array length: 18
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                18, // array length: 18
                780, // index: 780, string: "Model"
                786, // index: 786, string: "Text"
                566, // index: 566, string: "app_id"
                791, // index: 791, string: "app_verson_id"
                805, // index: 805, string: "attachments"
                817, // index: 817, string: "clean_text"
                749, // index: 749, string: "created_at"
                760, // index: 760, string: "email"
                828, // index: 828, string: "gravatar_hash"
                595, // index: 595, string: "id"
                842, // index: 842, string: "internal"
                775, // index: 775, string: "name"
                851, // index: 851, string: "oem"
                855, // index: 855, string: "os_version"
                866, // index: 866, string: "subject"
                743, // index: 743, string: "token"
                874, // index: 874, string: "user_string"
                886, // index: 886, string: "via"
                18, // array length: 18
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                4, // array length: 4
                749, // index: 749, string: "created_at"
                890, // index: 890, string: "file_name"
                595, // index: 595, string: "id"
                900, // index: 900, string: "url"
                4, // array length: 4
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
                273  // index: 273, string: "http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model"
        };
        // Count = 0
        static global::MemberEntry[] s_dataMemberLists = new global::MemberEntry[0];
        static readonly byte[] s_dataContractMap_Hashtable = null;
        // Count=48
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractMapEntry[] s_dataContractMap = new global::DataContractMapEntry[] {
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 16, // 0x10
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 160, // 0xa0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                "11d50a3a")),
                    TableIndex = 176, // 0xb0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 224, // 0xe0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 320, // 0x140
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.HockeyApp.Model.AppVersion, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 2, // 0x2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.HockeyApp.Model.AppVersion, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, PublicKey" +
                                "Token=b03f5f7f11d50a3a")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.HockeyApp.Model.AuthStatus, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, PublicKey" +
                                "Token=b03f5f7f11d50a3a")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.HockeyApp.Model.CrashData, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, PublicKeyT" +
                                "oken=b03f5f7f11d50a3a")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.HockeyApp.Model.FeedbackResponseSingle, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutra" +
                                "l, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.HockeyApp.Model.FeedbackThread, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, Publi" +
                                "cKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.HockeyApp.Model.FeedbackMessage, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 18, // 0x12
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.HockeyApp.Model.FeedbackMessage, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, Publ" +
                                "icKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.HockeyApp.Model.FeedbackAttachment, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 34, // 0x22
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.HockeyApp.Model.FeedbackAttachment, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, P" +
                                "ublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 50, // 0x32
                }
        };
        static readonly byte[] s_dataContracts_Hashtable = null;
        // Count=21
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractEntry[] s_dataContracts = new global::DataContractEntry[] {
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 0, // boolean
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 0, // boolean
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 0, // boolean
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.BooleanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 93, // base64Binary
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 93, // base64Binary
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 93, // base64Binary
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ByteArrayDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 106, // char
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 106, // char
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 106, // char
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.CharDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 111, // dateTime
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 111, // dateTime
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 111, // dateTime
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DateTimeDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 120, // decimal
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 120, // decimal
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 120, // decimal
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DecimalDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 128, // double
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 128, // double
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 128, // double
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DoubleDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 135, // float
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 135, // float
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 135, // float
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.FloatDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 141, // guid
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 141, // guid
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 141, // guid
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.GuidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 146, // int
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 146, // int
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 146, // int
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.IntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 150, // long
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 150, // long
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 150, // long
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.LongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 155, // anyType
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 155, // anyType
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 155, // anyType
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.ObjectDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 163, // QName
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 163, // QName
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 163, // QName
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                    },
                    Kind = global::DataContractKind.QNameDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 169, // short
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 169, // short
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 169, // short
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 175, // byte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 175, // byte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 175, // byte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.SignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 180, // string
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 180, // string
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 180, // string
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.StringDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 187, // duration
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 187, // duration
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 187, // duration
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.TimeSpanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 196, // unsignedByte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 196, // unsignedByte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 196, // unsignedByte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 209, // unsignedInt
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 209, // unsignedInt
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 209, // unsignedInt
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedIntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 221, // unsignedLong
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 221, // unsignedLong
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 221, // unsignedLong
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedLongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 234, // unsignedShort
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 234, // unsignedShort
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 234, // unsignedShort
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 248, // anyURI
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 248, // anyURI
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 248, // anyURI
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.UriDataContract,
                }
        };
        static readonly byte[] s_classDataContracts_Hashtable = null;
        // Count=7
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::ClassDataContractEntry[] s_classDataContracts = new global::ClassDataContractEntry[] {
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 339, // AppVersion
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        StableNameIndex = 339, // AppVersion
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        TopLevelElementNameIndex = 339, // AppVersion
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.HockeyApp.Model.AppVersion, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, PublicKey" +
                                    "Token=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.HockeyApp.Model.AppVersion, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, PublicKey" +
                                    "Token=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 1,
                    ContractNamespacesListIndex = 13,
                    MemberNamesListIndex = 15,
                    MemberNamespacesListIndex = 27,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 350, // AuthStatus
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        StableNameIndex = 350, // AuthStatus
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        TopLevelElementNameIndex = 350, // AuthStatus
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.HockeyApp.Model.AuthStatus, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, PublicKey" +
                                    "Token=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.HockeyApp.Model.AuthStatus, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, PublicKey" +
                                    "Token=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 39,
                    ContractNamespacesListIndex = 43,
                    MemberNamesListIndex = 45,
                    MemberNamespacesListIndex = 49,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 361, // CrashData
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        StableNameIndex = 361, // CrashData
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        TopLevelElementNameIndex = 361, // CrashData
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.HockeyApp.Model.CrashData, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, PublicKeyT" +
                                    "oken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.HockeyApp.Model.CrashData, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, PublicKeyT" +
                                    "oken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 53,
                    ContractNamespacesListIndex = 60,
                    MemberNamesListIndex = 62,
                    MemberNamespacesListIndex = 69,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 371, // FeedbackResponseSingle
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        StableNameIndex = 371, // FeedbackResponseSingle
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        TopLevelElementNameIndex = 371, // FeedbackResponseSingle
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.HockeyApp.Model.FeedbackResponseSingle, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutra" +
                                    "l, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.HockeyApp.Model.FeedbackResponseSingle, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutra" +
                                    "l, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 76,
                    ContractNamespacesListIndex = 80,
                    MemberNamesListIndex = 82,
                    MemberNamespacesListIndex = 86,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 394, // FeedbackThread
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        StableNameIndex = 394, // FeedbackThread
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        TopLevelElementNameIndex = 394, // FeedbackThread
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.HockeyApp.Model.FeedbackThread, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, Publi" +
                                    "cKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.HockeyApp.Model.FeedbackThread, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, Publi" +
                                    "cKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 90,
                    ContractNamespacesListIndex = 98,
                    MemberNamesListIndex = 100,
                    MemberNamespacesListIndex = 108,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 432, // FeedbackMessage
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        StableNameIndex = 432, // FeedbackMessage
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        TopLevelElementNameIndex = 432, // FeedbackMessage
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.HockeyApp.Model.FeedbackMessage, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.HockeyApp.Model.FeedbackMessage, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 116,
                    ContractNamespacesListIndex = 135,
                    MemberNamesListIndex = 137,
                    MemberNamespacesListIndex = 156,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 474, // FeedbackAttachment
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        StableNameIndex = 474, // FeedbackAttachment
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        TopLevelElementNameIndex = 474, // FeedbackAttachment
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.HockeyApp.Model.FeedbackAttachment, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, P" +
                                    "ublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.HockeyApp.Model.FeedbackAttachment, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, P" +
                                    "ublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 175,
                    ContractNamespacesListIndex = 180,
                    MemberNamesListIndex = 182,
                    MemberNamespacesListIndex = 187,
                }
        };
        static readonly byte[] s_collectionDataContracts_Hashtable = null;
        // Count=4
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::CollectionDataContractEntry[] s_collectionDataContracts = new global::CollectionDataContractEntry[] {
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 255, // ArrayOfAppVersion
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        StableNameIndex = 255, // ArrayOfAppVersion
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        TopLevelElementNameIndex = 255, // ArrayOfAppVersion
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.HockeyApp.Model.AppVersion, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.HockeyApp.Model.AppVersion, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 339, // AppVersion
                    KeyNameIndex = -1,
                    ItemNameIndex = 339, // AppVersion
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.HockeyApp.Model.AppVersion, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, PublicKey" +
                                "Token=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 409, // ArrayOfFeedbackMessage
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        StableNameIndex = 409, // ArrayOfFeedbackMessage
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        TopLevelElementNameIndex = 409, // ArrayOfFeedbackMessage
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.HockeyApp.Model.FeedbackMessage, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.HockeyApp.Model.FeedbackMessage, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 432, // FeedbackMessage
                    KeyNameIndex = -1,
                    ItemNameIndex = 432, // FeedbackMessage
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.HockeyApp.Model.FeedbackMessage, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, Publ" +
                                "icKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 448, // ArrayOfFeedbackAttachment
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        StableNameIndex = 448, // ArrayOfFeedbackAttachment
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        TopLevelElementNameIndex = 448, // ArrayOfFeedbackAttachment
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/Microsoft.HockeyApp.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.HockeyApp.Model.FeedbackAttachment, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.HockeyApp.Model.FeedbackAttachment, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 474, // FeedbackAttachment
                    KeyNameIndex = -1,
                    ItemNameIndex = 474, // FeedbackAttachment
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.HockeyApp.Model.FeedbackAttachment, Microsoft.HockeyApp.Core45, Version=4.1.5.1043, Culture=neutral, P" +
                                "ublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 493, // ArrayOfanyType
                        NamespaceIndex = 508, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 493, // ArrayOfanyType
                        StableNameNamespaceIndex = 508, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 493, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 508, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 155, // anyType
                    KeyNameIndex = -1,
                    ItemNameIndex = 155, // anyType
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }
        };
        static readonly byte[] s_enumDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::EnumDataContractEntry[] s_enumDataContracts = new global::EnumDataContractEntry[0];
        static readonly byte[] s_xmlDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::XmlDataContractEntry[] s_xmlDataContracts = new global::XmlDataContractEntry[0];
        static readonly byte[] s_jsonDelegatesList_Hashtable = null;
        // Count=11
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::JsonDelegateEntry[] s_jsonDelegatesList = new global::JsonDelegateEntry[] {
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 37,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type4.WriteArrayOfAppVersionToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type3.ReadArrayOfAppVersionFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type5.ReadArrayOfAppVersionFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 38,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type9.WriteAppVersionToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type8.ReadAppVersionFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 39,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type13.WriteAuthStatusToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type12.ReadAuthStatusFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 40,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type17.WriteCrashDataToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type16.ReadCrashDataFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 41,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type21.WriteFeedbackResponseSingleToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type20.ReadFeedbackResponseSingleFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 42,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type25.WriteFeedbackThreadToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type24.ReadFeedbackThreadFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 43,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type30.WriteArrayOfFeedbackMessageToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type29.ReadArrayOfFeedbackMessageFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type31.ReadArrayOfFeedbackMessageFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 44,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type35.WriteFeedbackMessageToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type34.ReadFeedbackMessageFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 45,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type40.WriteArrayOfFeedbackAttachmentToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type39.ReadArrayOfFeedbackAttachmentFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type41.ReadArrayOfFeedbackAttachmentFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 46,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type45.WriteFeedbackAttachmentToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type44.ReadFeedbackAttachmentFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 47,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type50.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type49.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type51.ReadArrayOfanyTypeFromJsonIsGetOnly),
                }
        };
        static char[] s_stringPool = new char[] {
            'b','o','o','l','e','a','n','\0','h','t','t','p',':','/','/','w','w','w','.','w','3','.','o','r','g','/','2','0','0','1',
            '/','X','M','L','S','c','h','e','m','a','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r',
            'o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o',
            'n','/','\0','b','a','s','e','6','4','B','i','n','a','r','y','\0','c','h','a','r','\0','d','a','t','e','T','i','m','e','\0',
            'd','e','c','i','m','a','l','\0','d','o','u','b','l','e','\0','f','l','o','a','t','\0','g','u','i','d','\0','i','n','t','\0',
            'l','o','n','g','\0','a','n','y','T','y','p','e','\0','Q','N','a','m','e','\0','s','h','o','r','t','\0','b','y','t','e','\0',
            's','t','r','i','n','g','\0','d','u','r','a','t','i','o','n','\0','u','n','s','i','g','n','e','d','B','y','t','e','\0','u',
            'n','s','i','g','n','e','d','I','n','t','\0','u','n','s','i','g','n','e','d','L','o','n','g','\0','u','n','s','i','g','n',
            'e','d','S','h','o','r','t','\0','a','n','y','U','R','I','\0','A','r','r','a','y','O','f','A','p','p','V','e','r','s','i',
            'o','n','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t',
            '.','o','r','g','/','2','0','0','4','/','0','7','/','M','i','c','r','o','s','o','f','t','.','H','o','c','k','e','y','A',
            'p','p','.','M','o','d','e','l','\0','A','p','p','V','e','r','s','i','o','n','\0','A','u','t','h','S','t','a','t','u','s',
            '\0','C','r','a','s','h','D','a','t','a','\0','F','e','e','d','b','a','c','k','R','e','s','p','o','n','s','e','S','i','n',
            'g','l','e','\0','F','e','e','d','b','a','c','k','T','h','r','e','a','d','\0','A','r','r','a','y','O','f','F','e','e','d',
            'b','a','c','k','M','e','s','s','a','g','e','\0','F','e','e','d','b','a','c','k','M','e','s','s','a','g','e','\0','A','r',
            'r','a','y','O','f','F','e','e','d','b','a','c','k','A','t','t','a','c','h','m','e','n','t','\0','F','e','e','d','b','a',
            'c','k','A','t','t','a','c','h','m','e','n','t','\0','A','r','r','a','y','O','f','a','n','y','T','y','p','e','\0','h','t',
            't','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r','o','s','o','f','t','.','c','o','m','/','2','0','0',
            '3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o','n','/','A','r','r','a','y','s','\0','a','p','p','_',
            'i','d','\0','a','p','p','s','i','z','e','\0','d','e','v','i','c','e','_','f','a','m','i','l','y','\0','i','d','\0','m','a',
            'n','d','a','t','o','r','y','\0','m','i','n','i','m','u','m','_','o','s','_','v','e','r','s','i','o','n','\0','n','o','t',
            'e','s','\0','s','h','o','r','t','v','e','r','s','i','o','n','\0','t','i','m','e','s','t','a','m','p','\0','t','i','t','l',
            'e','\0','v','e','r','s','i','o','n','\0','a','u','i','d','\0','i','u','i','d','\0','s','t','a','t','u','s','\0','c','o','n',
            't','a','c','t','\0','d','e','s','c','r','i','p','t','i','o','n','\0','l','o','g','\0','s','d','k','\0','s','d','k','_','v',
            'e','r','s','i','o','n','\0','u','s','e','r','I','D','\0','f','e','e','d','b','a','c','k','\0','t','o','k','e','n','\0','c',
            'r','e','a','t','e','d','_','a','t','\0','e','m','a','i','l','\0','m','e','s','s','a','g','e','s','\0','n','a','m','e','\0',
            'M','o','d','e','l','\0','T','e','x','t','\0','a','p','p','_','v','e','r','s','o','n','_','i','d','\0','a','t','t','a','c',
            'h','m','e','n','t','s','\0','c','l','e','a','n','_','t','e','x','t','\0','g','r','a','v','a','t','a','r','_','h','a','s',
            'h','\0','i','n','t','e','r','n','a','l','\0','o','e','m','\0','o','s','_','v','e','r','s','i','o','n','\0','s','u','b','j',
            'e','c','t','\0','u','s','e','r','_','s','t','r','i','n','g','\0','v','i','a','\0','f','i','l','e','_','n','a','m','e','\0',
            'u','r','l','\0'};
    }
}
