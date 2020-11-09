﻿using System;

namespace Il2CppDumper
{
    /*public class Il2CppGlobalMetadataHeader
    {
        public uint sanity;
        public int version;
        public uint stringLiteralOffset; // string data for managed code
        public int stringLiteralCount;
        public uint stringLiteralDataOffset;
        public int stringLiteralDataCount;
        public uint stringOffset; // string data for metadata
        public int stringCount;
        public uint eventsOffset; // Il2CppEventDefinition
        public int eventsCount;
        public uint propertiesOffset; // Il2CppPropertyDefinition
        public int propertiesCount;
        public uint methodsOffset; // Il2CppMethodDefinition
        public int methodsCount;
        public uint parameterDefaultValuesOffset; // Il2CppParameterDefaultValue
        public int parameterDefaultValuesCount;
        public uint fieldDefaultValuesOffset; // Il2CppFieldDefaultValue
        public int fieldDefaultValuesCount;
        public uint fieldAndParameterDefaultValueDataOffset; // uint8_t
        public int fieldAndParameterDefaultValueDataCount;
        public int fieldMarshaledSizesOffset; // Il2CppFieldMarshaledSize
        public int fieldMarshaledSizesCount;
        public uint parametersOffset; // Il2CppParameterDefinition
        public int parametersCount;
        public uint fieldsOffset; // Il2CppFieldDefinition
        public int fieldsCount;
        public uint genericParametersOffset; // Il2CppGenericParameter
        public int genericParametersCount;
        public uint genericParameterConstraintsOffset; // TypeIndex
        public int genericParameterConstraintsCount;
        public uint genericContainersOffset; // Il2CppGenericContainer
        public int genericContainersCount;
        public uint nestedTypesOffset; // TypeDefinitionIndex
        public int nestedTypesCount;
        public uint interfacesOffset; // TypeIndex
        public int interfacesCount;
        public uint vtableMethodsOffset; // EncodedMethodIndex
        public int vtableMethodsCount;
        public int interfaceOffsetsOffset; // Il2CppInterfaceOffsetPair
        public int interfaceOffsetsCount;
        public uint typeDefinitionsOffset; // Il2CppTypeDefinition
        public int typeDefinitionsCount;
        [Version(Max = 24.1f)]
        public uint rgctxEntriesOffset; // Il2CppRGCTXDefinition
        [Version(Max = 24.1f)]
        public int rgctxEntriesCount;
        public uint imagesOffset; // Il2CppImageDefinition
        public int imagesCount;
        public int assembliesOffset; // Il2CppAssemblyDefinition
        public int assembliesCount;
        [Version(Min = 19, Max = 24.3f)]
        public uint metadataUsageListsOffset; // Il2CppMetadataUsageList
        [Version(Min = 19, Max = 24.3f)]
        public int metadataUsageListsCount;
        [Version(Min = 19, Max = 24.3f)]
        public uint metadataUsagePairsOffset; // Il2CppMetadataUsagePair
        [Version(Min = 19, Max = 24.3f)]
        public int metadataUsagePairsCount;
        [Version(Min = 19)]
        public uint fieldRefsOffset; // Il2CppFieldRef
        [Version(Min = 19)]
        public int fieldRefsCount;
        [Version(Min = 20)]
        public int referencedAssembliesOffset; // int32_t
        [Version(Min = 20)]
        public int referencedAssembliesCount;
        [Version(Min = 21)]
        public uint attributesInfoOffset; // Il2CppCustomAttributeTypeRange
        [Version(Min = 21)]
        public int attributesInfoCount;
        [Version(Min = 21)]
        public uint attributeTypesOffset; // TypeIndex
        [Version(Min = 21)]
        public int attributeTypesCount;
        [Version(Min = 22)]
        public int unresolvedVirtualCallParameterTypesOffset; // TypeIndex
        [Version(Min = 22)]
        public int unresolvedVirtualCallParameterTypesCount;
        [Version(Min = 22)]
        public int unresolvedVirtualCallParameterRangesOffset; // Il2CppRange
        [Version(Min = 22)]
        public int unresolvedVirtualCallParameterRangesCount;
        [Version(Min = 23)]
        public int windowsRuntimeTypeNamesOffset; // Il2CppWindowsRuntimeTypeNamePair
        [Version(Min = 23)]
        public int windowsRuntimeTypeNamesSize;
        [Version(Min = 27)]
        public int windowsRuntimeStringsOffset; // const char*
        [Version(Min = 27)]
        public int windowsRuntimeStringsSize;
        [Version(Min = 24)]
        public int exportedTypeDefinitionsOffset; // TypeDefinitionIndex
        [Version(Min = 24)]
        public int exportedTypeDefinitionsCount;
    }*/

    public class Il2CppGlobalMetadataHeader
    {
        public uint sanity; //0x0000
        public int version; //0x0004

        public uint KeyPart5_1; //0x0008
        public uint KeyPart5_2; //0x000C
        public uint KeyPart5_3; //0x0010
        public uint KeyPart5_4; //0x0014

        public uint stringLiteralDataOffset; //0x0018
        public uint stringLiteralDataCount; //0x001C

        public uint stringLiteralOffset; //0x0020
        public uint stringLiteralCount; //0x0024

        public uint genericContainersOffset; //0x0028
        public int genericContainersCount; //0x002C

        public uint nestedTypesOffset; //0x0030
        public int nestedTypesCount; //0x0034

        public uint interfacesOffset; //0x0038
        public int interfacesCount; //0x003C

        public uint vtableMethodsOffset; //0x0040
        public int vtableMethodsCount; //0x0044

        public uint interfaceOffsetsOffset; //0x0048
        public uint interfaceOffsetsCount; //0x004C

        public uint typeDefinitionsOffset; //0x0050
        public int typeDefinitionsCount; //0x0054
        public uint rgctxEntriesOffset; //0x0058
        public int rgctxEntriesCount; //0x005C

        public uint KeyPart1_1; //0x0060
        public uint KeyPart1_2; //0x0064
        public uint KeyPart1_3; //0x0068
        public uint KeyPart1_4; //0x006C

        public uint imagesOffset; //0x0070
        public int imagesCount; //0x0074

        public uint assembliesOffset; //0x0078
        public uint assembliesSize; //0x007C

        public uint fieldsOffset; //0x0080
        public int fieldsCount; //0x0084

        public uint genericParametersOffset; //0x0088
        public int genericParametersCount; //0x008C

        public uint fieldAndParameterDefaultValueDataOffset; //0x0090
        public int fieldAndParameterDefaultValueDataCount;  //0x0094


        public uint padding17; //0x0098
        public uint padding18; //0x009C

        public uint refrencedAssembliesOffset; //0x00A0
        public uint refrencedAssembliesCount; //0x00A4

        public uint attributesInfoOffset; //0x00A8
        public int attributesInfoCount; //0x00AC

        public uint attributeTypesOffset; //0x00B0
        public int attributeTypesCount; //0x00B4

        public uint unresolvedVirtualCallParameterTypesOffset; //0x00B8
        public uint unresolvedVirtualCallParameterTypesCount; //0x00BC

        public uint unresolvedVirtualCallParameterRangesOffset; //0x00C0
        public uint unresolvedVirtualCallParameterRangesCount; //0x00C4

        public uint windowsRuntimeTypeNamesOffset; //0x00C8
        public uint windowsRuntimeTypeNamesCount; //0x00CC

        public uint exportedTypeDefinitionsOffset; //0x00D0
        public uint exportedTypeDefinitionsCount; //0x00D4

        public uint stringsOffset; //0x00D8
        public uint stringsCount; //0x00DC

        public uint parametersOffset; //0x00E0
        public int parametersCount; //0x00E4

        public uint genericParameterConstraintsOffset; //0x00E8
        public int genericParameterConstraintsCount; //0x00EC

        public uint KeyPart4_1; //0x00F0
        public uint KeyPart4_2; //0x00F4

        public uint metadataUsagePairsOffset; //0x00F8
        public int metadataUsagePairsCount; //0x00FC

        public uint KeyPart3_1; //0x0100
        public uint KeyPart3_2; //0x0104
        public uint KeyPart3_3; //0x0108
        public uint KeyPart3_4; //0x010C

        public uint fieldRefsOffset; //0x0110
        public int fieldRefsCount; //0x0114

        public uint eventsOffset; //0x0118
        public int eventsCount; //0x011C

        public uint propertiesOffset; //0x0120
        public int propertiesCount; //0x0124

        public uint methodsOffset; //0x0128
        public int methodsCount; //0x012C

        public uint parameterDefaultValuesOffset; //0x0130
        public int parameterDefaultValuesCount; //0x0134

        public uint fieldDefaultValuesOffset; //0x0138
        public int fieldDefaultValuesCount; //0x013C

        public uint KeyPart2_1; //0x0140
        public uint KeyPart2_2; //0x0144
        public uint KeyPart2_3; //0x0148
        public uint KeyPart2_4; //0x014C

        public uint metadataUsageListsOffset; //0x0150
        public int metadataUsageListsCount; //0x0154
    }

    public class Il2CppImageDefinition
    {
        public uint nameIndex;
        public int assemblyIndex;

        public int typeStart;
        public uint typeCount;

        public int exportedTypeStart;
        public uint exportedTypeCount;

        public int entryPointIndex;
        public uint token;

        /*[Version(Min = 24.1f)]
        public int customAttributeStart;
        [Version(Min = 24.1f)]
        public uint customAttributeCount;*/
    }

    /*public class Il2CppTypeDefinition
    {
        public uint nameIndex;
        public uint namespaceIndex;
        [Version(Max = 24)]
        public int customAttributeIndex;
        public int byvalTypeIndex;
        [Version(Max = 24.3f)]
        public int byrefTypeIndex;

        public int declaringTypeIndex;
        public int parentIndex;
        public int elementTypeIndex; // we can probably remove this one. Only used for enums

        [Version(Max = 24.1f)]
        public int rgctxStartIndex;
        [Version(Max = 24.1f)]
        public int rgctxCount;

        public int genericContainerIndex;

        [Version(Max = 22)]
        public int delegateWrapperFromManagedToNativeIndex;
        [Version(Max = 22)]
        public int marshalingFunctionsIndex;
        [Version(Min = 21, Max = 22)]
        public int ccwFunctionIndex;
        [Version(Min = 21, Max = 22)]
        public int guidIndex;

        public uint flags;

        public int fieldStart;
        public int methodStart;
        public int eventStart;
        public int propertyStart;
        public int nestedTypesStart;
        public int interfacesStart;
        public int vtableStart;
        public int interfaceOffsetsStart;

        public ushort method_count;
        public ushort property_count;
        public ushort field_count;
        public ushort event_count;
        public ushort nested_type_count;
        public ushort vtable_count;
        public ushort interfaces_count;
        public ushort interface_offsets_count;

        // bitfield to portably encode boolean values as single bits
        // 01 - valuetype;
        // 02 - enumtype;
        // 03 - has_finalize;
        // 04 - has_cctor;
        // 05 - is_blittable;
        // 06 - is_import_or_windows_runtime;
        // 07-10 - One of nine possible PackingSize values (0, 1, 2, 4, 8, 16, 32, 64, or 128)
        // 11 - PackingSize is default
        // 12 - ClassSize is default
        // 13-16 - One of nine possible PackingSize values (0, 1, 2, 4, 8, 16, 32, 64, or 128) - the specified packing size (even for explicit layouts)
        public uint bitfield;
        [Version(Min = 19)]
        public uint token;

        public bool IsValueType => (bitfield & 0x1) == 1;
        public bool IsEnum => ((bitfield >> 1) & 0x1) == 1;
    }*/
    public class Il2CppTypeDefinition
    {
        public uint nameIndex;
        public uint namespaceIndex;

        public int customAttributeIndex;
        public int byvalTypeIndex;
        public int byrefTypeIndex;

        public int declaringTypeIndex;
        public int parentIndex;
        public int elementTypeIndex;

        public int rgctxStartIndex;
        public int rgctxCount;

        public int genericContainerIndex;
        public uint flags;

        public int fieldStart;
        public int propertyStart;
        public int methodStart;
        public int eventStart;
        public int nestedTypesStart;
        public int interfacesStart;
        public int interfaceOffsetsStart;
        public int vtableStart;

        public ushort event_count;
        public ushort method_count;
        public ushort property_count;
        public ushort field_count;
        public ushort vtable_count;
        public ushort interfaces_count;
        public ushort interface_offsets_count;
        public ushort nested_type_count;
        // bitfield to portably encode boolean values as single bits
        // 01 - valuetype;
        // 02 - enumtype;
        // 03 - has_finalize;
        // 04 - has_cctor;
        // 05 - is_blittable;
        // 06 - is_import_or_windows_runtime;
        // 07-10 - One of nine possible PackingSize values (0, 1, 2, 4, 8, 16, 32, 64, or 128)
        // 11 - PackingSize is default
        // 12 - ClassSize is default
        // 13-16 - One of nine possible PackingSize values (0, 1, 2, 4, 8, 16, 32, 64, or 128) - the specified packing size (even for explicit layouts)
        public uint bitfield;
        public uint token;

        public bool IsValueType => (bitfield & 0x1) == 1;
        public bool IsEnum => ((bitfield >> 1) & 0x1) == 1;
    }

    /*public class Il2CppMethodDefinition
    {
        public uint nameIndex;
        public int declaringType;
        public int returnType;
        public int parameterStart;
        [Version(Max = 24)]
        public int customAttributeIndex;
        public int genericContainerIndex;
        [Version(Max = 24.1f)]
        public int methodIndex;
        [Version(Max = 24.1f)]
        public int invokerIndex;
        [Version(Max = 24.1f)]
        public int delegateWrapperIndex;
        [Version(Max = 24.1f)]
        public int rgctxStartIndex;
        [Version(Max = 24.1f)]
        public int rgctxCount;
        public uint token;
        public ushort flags;
        public ushort iflags;
        public ushort slot;
        public ushort parameterCount;
    }*/
    public class Il2CppMethodDefinition
    {
        public int returnType;
        public int declaringType;

        public uint Padding1;

        public uint nameIndex;
        public int parameterStart;

        public int genericContainerIndex;
        public int customAttributeIndex;

        public uint Padding2;
        public uint Padding3;

        public int methodIndex;
        public int invokerIndex;

        public int rgctxCount;
        public int rgctxStartIndex;

        public ushort parameterCount;
        public ushort flags;
        public ushort slot;
        public ushort iflags;

        public uint token;
    }

    public class Il2CppParameterDefinition
    {
        public uint nameIndex;
        public uint token;
        //[Version(Max = 24)]
        public int customAttributeIndex;
        public int typeIndex;
    }

    /*public class Il2CppFieldDefinition
    {
        public uint nameIndex;
        public int typeIndex;
        public int customAttributeIndex;
        public uint token;
    }*/

    public class Il2CppFieldDefinition
    {
        public int customAttributeIndex;
        public int typeIndex;
        public uint nameIndex;
        public uint token;
    }

    public class Il2CppFieldDefaultValue
    {
        public int fieldIndex;
        public int typeIndex;
        public int dataIndex;
    }

    /*public class Il2CppPropertyDefinition
    {
        public uint nameIndex;
        public int get;
        public int set;
        public uint attrs;
        [Version(Max = 24)]
        public int customAttributeIndex;
        [Version(Min = 19)]
        public uint token;
    }*/

    public class Il2CppPropertyDefinition
    {
        public int customAttributeIndex;
        public uint nameIndex;
        public uint Padding1;
        public uint token;
        public uint attrs;
        public uint Padding2;
        public int set;
        public int get;
    }

    public class Il2CppCustomAttributeTypeRange
    {
        //[Version(Min = 24.1f)]
        //public uint token;
        public int start;
        public int count;
    }

    public class Il2CppMetadataUsageList
    {
        public uint start;
        public uint count;
    }

    public class Il2CppMetadataUsagePair
    {
        public uint destinationIndex;
        public uint encodedSourceIndex;
    }

    public class Il2CppStringLiteral
    {
        public int dataIndex;
        public uint length;
    }

    public class Il2CppParameterDefaultValue
    {
        public int parameterIndex;
        public int typeIndex;
        public int dataIndex;
    }

    public class Il2CppEventDefinition
    {
        public uint nameIndex;
        public int typeIndex;
        public int add;
        public int remove;
        public int raise;
        [Version(Max = 24)]
        public int customAttributeIndex;
        [Version(Min = 19)]
        public uint token;
    }

    public class Il2CppGenericContainer
    {
        /* index of the generic type definition or the generic method definition corresponding to this container */
        public int ownerIndex; // either index into Il2CppClass metadata array or Il2CppMethodDefinition array
        public int type_argc;
        /* If true, we're a generic method, otherwise a generic type definition. */
        public int is_method;
        /* Our type parameters. */
        public int genericParameterStart;
    }

    public class Il2CppFieldRef
    {
        public int typeIndex;
        public int fieldIndex; // local offset into type fields
    }

    public class Il2CppGenericParameter
    {
        public int ownerIndex;  /* Type or method this parameter was defined in. */
        public uint nameIndex;
        public short constraintsStart;
        public short constraintsCount;
        public ushort num;
        public ushort flags;
    }

    public enum Il2CppRGCTXDataType
    {
        IL2CPP_RGCTX_DATA_INVALID,
        IL2CPP_RGCTX_DATA_TYPE,
        IL2CPP_RGCTX_DATA_CLASS,
        IL2CPP_RGCTX_DATA_METHOD,
        IL2CPP_RGCTX_DATA_ARRAY,
    }

    public class Il2CppRGCTXDefinitionData
    {
        public int rgctxDataDummy;
        public int methodIndex => rgctxDataDummy;
        public int typeIndex => rgctxDataDummy;
    }

    public class Il2CppRGCTXDefinition
    {
        public Il2CppRGCTXDataType type;
        public Il2CppRGCTXDefinitionData data;
    }
}
