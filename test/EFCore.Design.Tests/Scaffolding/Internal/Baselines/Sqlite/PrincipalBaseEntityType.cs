// <auto-generated />
using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Scaffolding.Internal;
using Microsoft.EntityFrameworkCore.Sqlite.Storage.Internal;
using Microsoft.EntityFrameworkCore.Sqlite.Storage.Json.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;

#pragma warning disable 219, 612, 618
#nullable disable

namespace Microsoft.EntityFrameworkCore.Metadata
{
    internal partial class PrincipalBaseEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.Internal.CSharpRuntimeModelCodeGeneratorTest+PrincipalBase",
                typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase),
                baseEntityType,
                discriminatorValue: "PrincipalBase",
                derivedTypesCount: 1,
                propertyCount: 15,
                navigationCount: 1,
                skipNavigationCount: 1,
                unnamedIndexCount: 1,
                keyCount: 2);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(long?),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw);
            id.TypeMapping = LongTypeMapping.Default.Clone(
                comparer: new ValueComparer<long?>(
                    (Nullable<long> v1, Nullable<long> v2) => v1.HasValue && v2.HasValue && (long)v1 == (long)v2 || !v1.HasValue && !v2.HasValue,
                    (Nullable<long> v) => v.HasValue ? ((long)v).GetHashCode() : 0,
                    (Nullable<long> v) => v.HasValue ? (Nullable<long>)(long)v : default(Nullable<long>)),
                keyComparer: new ValueComparer<long?>(
                    (Nullable<long> v1, Nullable<long> v2) => v1.HasValue && v2.HasValue && (long)v1 == (long)v2 || !v1.HasValue && !v2.HasValue,
                    (Nullable<long> v) => v.HasValue ? ((long)v).GetHashCode() : 0,
                    (Nullable<long> v) => v.HasValue ? (Nullable<long>)(long)v : default(Nullable<long>)),
                providerValueComparer: new ValueComparer<long?>(
                    (Nullable<long> v1, Nullable<long> v2) => v1.HasValue && v2.HasValue && (long)v1 == (long)v2 || !v1.HasValue && !v2.HasValue,
                    (Nullable<long> v) => v.HasValue ? ((long)v).GetHashCode() : 0,
                    (Nullable<long> v) => v.HasValue ? (Nullable<long>)(long)v : default(Nullable<long>)),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "INTEGER"));

            var overrides = new StoreObjectDictionary<RuntimeRelationalPropertyOverrides>();
            var idPrincipalDerived = new RuntimeRelationalPropertyOverrides(
                id,
                StoreObjectIdentifier.Table("PrincipalDerived", null),
                true,
                "DerivedId");
            overrides.Add(StoreObjectIdentifier.Table("PrincipalDerived", null), idPrincipalDerived);
            id.AddAnnotation("Relational:RelationalOverrides", overrides);


            var alternateId = runtimeEntityType.AddProperty(
                "AlternateId",
                typeof(Guid),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetField("AlternateId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                propertyAccessMode: PropertyAccessMode.FieldDuringConstruction,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"),
                jsonValueReaderWriter: JsonGuidReaderWriter.Instance);
            alternateId.TypeMapping = SqliteGuidTypeMapping.Default;

            var enum1 = runtimeEntityType.AddProperty(
                "Enum1",
                typeof(CSharpRuntimeModelCodeGeneratorTest.AnEnum),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetProperty("Enum1", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetField("<Enum1>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            enum1.TypeMapping = IntTypeMapping.Default.Clone(
                comparer: new ValueComparer<CSharpRuntimeModelCodeGeneratorTest.AnEnum>(
                    (CSharpRuntimeModelCodeGeneratorTest.AnEnum v1, CSharpRuntimeModelCodeGeneratorTest.AnEnum v2) => object.Equals((object)v1, (object)v2),
                    (CSharpRuntimeModelCodeGeneratorTest.AnEnum v) => v.GetHashCode(),
                    (CSharpRuntimeModelCodeGeneratorTest.AnEnum v) => v),
                keyComparer: new ValueComparer<CSharpRuntimeModelCodeGeneratorTest.AnEnum>(
                    (CSharpRuntimeModelCodeGeneratorTest.AnEnum v1, CSharpRuntimeModelCodeGeneratorTest.AnEnum v2) => object.Equals((object)v1, (object)v2),
                    (CSharpRuntimeModelCodeGeneratorTest.AnEnum v) => v.GetHashCode(),
                    (CSharpRuntimeModelCodeGeneratorTest.AnEnum v) => v),
                providerValueComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "INTEGER"),
                converter: new ValueConverter<CSharpRuntimeModelCodeGeneratorTest.AnEnum, int>(
                    (CSharpRuntimeModelCodeGeneratorTest.AnEnum value) => (int)value,
                    (int value) => (CSharpRuntimeModelCodeGeneratorTest.AnEnum)value),
                jsonValueReaderWriter: new JsonConvertedValueReaderWriter<CSharpRuntimeModelCodeGeneratorTest.AnEnum, int>(
                    JsonInt32ReaderWriter.Instance,
                    new ValueConverter<CSharpRuntimeModelCodeGeneratorTest.AnEnum, int>(
                        (CSharpRuntimeModelCodeGeneratorTest.AnEnum value) => (int)value,
                        (int value) => (CSharpRuntimeModelCodeGeneratorTest.AnEnum)value)));
            enum1.SetSentinelFromProviderValue(0);

            var enum2 = runtimeEntityType.AddProperty(
                "Enum2",
                typeof(CSharpRuntimeModelCodeGeneratorTest.AnEnum?),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetProperty("Enum2", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetField("<Enum2>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            enum2.TypeMapping = IntTypeMapping.Default.Clone(
                comparer: new ValueComparer<CSharpRuntimeModelCodeGeneratorTest.AnEnum?>(
                    (Nullable<CSharpRuntimeModelCodeGeneratorTest.AnEnum> v1, Nullable<CSharpRuntimeModelCodeGeneratorTest.AnEnum> v2) => v1.HasValue && v2.HasValue && object.Equals((object)(CSharpRuntimeModelCodeGeneratorTest.AnEnum)v1, (object)(CSharpRuntimeModelCodeGeneratorTest.AnEnum)v2) || !v1.HasValue && !v2.HasValue,
                    (Nullable<CSharpRuntimeModelCodeGeneratorTest.AnEnum> v) => v.HasValue ? ((CSharpRuntimeModelCodeGeneratorTest.AnEnum)v).GetHashCode() : 0,
                    (Nullable<CSharpRuntimeModelCodeGeneratorTest.AnEnum> v) => v.HasValue ? (Nullable<CSharpRuntimeModelCodeGeneratorTest.AnEnum>)(CSharpRuntimeModelCodeGeneratorTest.AnEnum)v : default(Nullable<CSharpRuntimeModelCodeGeneratorTest.AnEnum>)),
                keyComparer: new ValueComparer<CSharpRuntimeModelCodeGeneratorTest.AnEnum?>(
                    (Nullable<CSharpRuntimeModelCodeGeneratorTest.AnEnum> v1, Nullable<CSharpRuntimeModelCodeGeneratorTest.AnEnum> v2) => v1.HasValue && v2.HasValue && object.Equals((object)(CSharpRuntimeModelCodeGeneratorTest.AnEnum)v1, (object)(CSharpRuntimeModelCodeGeneratorTest.AnEnum)v2) || !v1.HasValue && !v2.HasValue,
                    (Nullable<CSharpRuntimeModelCodeGeneratorTest.AnEnum> v) => v.HasValue ? ((CSharpRuntimeModelCodeGeneratorTest.AnEnum)v).GetHashCode() : 0,
                    (Nullable<CSharpRuntimeModelCodeGeneratorTest.AnEnum> v) => v.HasValue ? (Nullable<CSharpRuntimeModelCodeGeneratorTest.AnEnum>)(CSharpRuntimeModelCodeGeneratorTest.AnEnum)v : default(Nullable<CSharpRuntimeModelCodeGeneratorTest.AnEnum>)),
                providerValueComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "INTEGER"),
                converter: new ValueConverter<CSharpRuntimeModelCodeGeneratorTest.AnEnum, int>(
                    (CSharpRuntimeModelCodeGeneratorTest.AnEnum value) => (int)value,
                    (int value) => (CSharpRuntimeModelCodeGeneratorTest.AnEnum)value),
                jsonValueReaderWriter: new JsonConvertedValueReaderWriter<CSharpRuntimeModelCodeGeneratorTest.AnEnum, int>(
                    JsonInt32ReaderWriter.Instance,
                    new ValueConverter<CSharpRuntimeModelCodeGeneratorTest.AnEnum, int>(
                        (CSharpRuntimeModelCodeGeneratorTest.AnEnum value) => (int)value,
                        (int value) => (CSharpRuntimeModelCodeGeneratorTest.AnEnum)value)));

            var flagsEnum1 = runtimeEntityType.AddProperty(
                "FlagsEnum1",
                typeof(CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetProperty("FlagsEnum1", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetField("<FlagsEnum1>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            flagsEnum1.TypeMapping = IntTypeMapping.Default.Clone(
                comparer: new ValueComparer<CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum>(
                    (CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum v1, CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum v2) => object.Equals((object)v1, (object)v2),
                    (CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum v) => v.GetHashCode(),
                    (CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum v) => v),
                keyComparer: new ValueComparer<CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum>(
                    (CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum v1, CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum v2) => object.Equals((object)v1, (object)v2),
                    (CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum v) => v.GetHashCode(),
                    (CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum v) => v),
                providerValueComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "INTEGER"),
                converter: new ValueConverter<CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum, int>(
                    (CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum value) => (int)value,
                    (int value) => (CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum)value),
                jsonValueReaderWriter: new JsonConvertedValueReaderWriter<CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum, int>(
                    JsonInt32ReaderWriter.Instance,
                    new ValueConverter<CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum, int>(
                        (CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum value) => (int)value,
                        (int value) => (CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum)value)));
            flagsEnum1.SetSentinelFromProviderValue(0);

            var flagsEnum2 = runtimeEntityType.AddProperty(
                "FlagsEnum2",
                typeof(CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetProperty("FlagsEnum2", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetField("<FlagsEnum2>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            flagsEnum2.TypeMapping = IntTypeMapping.Default.Clone(
                comparer: new ValueComparer<CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum>(
                    (CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum v1, CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum v2) => object.Equals((object)v1, (object)v2),
                    (CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum v) => v.GetHashCode(),
                    (CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum v) => v),
                keyComparer: new ValueComparer<CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum>(
                    (CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum v1, CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum v2) => object.Equals((object)v1, (object)v2),
                    (CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum v) => v.GetHashCode(),
                    (CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum v) => v),
                providerValueComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "INTEGER"),
                converter: new ValueConverter<CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum, int>(
                    (CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum value) => (int)value,
                    (int value) => (CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum)value),
                jsonValueReaderWriter: new JsonConvertedValueReaderWriter<CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum, int>(
                    JsonInt32ReaderWriter.Instance,
                    new ValueConverter<CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum, int>(
                        (CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum value) => (int)value,
                        (int value) => (CSharpRuntimeModelCodeGeneratorTest.AFlagsEnum)value)));
            flagsEnum2.SetSentinelFromProviderValue(6);

            var point = runtimeEntityType.AddProperty(
                "Point",
                typeof(Point),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd,
                valueConverter: new CastingConverter<Point, Point>(),
                valueComparer: new CSharpRuntimeModelCodeGeneratorTest.CustomValueComparer<Point>(),
                providerValueComparer: new CSharpRuntimeModelCodeGeneratorTest.CustomValueComparer<Point>());
            point.TypeMapping = null;
            point.AddAnnotation("Relational:ColumnType", "geometry");
            point.AddAnnotation("Relational:DefaultValue", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT Z(0 0 0)"));

            var refTypeArray = runtimeEntityType.AddProperty(
                "RefTypeArray",
                typeof(IPAddress[]),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetProperty("RefTypeArray", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetField("<RefTypeArray>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            refTypeArray.TypeMapping = SqliteStringTypeMapping.Default.Clone(
                comparer: new ListComparer<IPAddress>(new ValueComparer<IPAddress>(
                    (IPAddress v1, IPAddress v2) => v1 == null && v2 == null || v1 != null && v2 != null && v1.Equals(v2),
                    (IPAddress v) => v.GetHashCode(),
                    (IPAddress v) => v)),
                keyComparer: new ListComparer<IPAddress>(new ValueComparer<IPAddress>(
                    (IPAddress v1, IPAddress v2) => v1 == null && v2 == null || v1 != null && v2 != null && v1.Equals(v2),
                    (IPAddress v) => v.GetHashCode(),
                    (IPAddress v) => v)),
                providerValueComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                converter: new CollectionToJsonStringConverter<IPAddress>(new JsonCollectionReaderWriter<IPAddress[], IPAddress[], IPAddress>(
                    new JsonConvertedValueReaderWriter<IPAddress, string>(
                        JsonStringReaderWriter.Instance,
                        new ValueConverter<IPAddress, string>(
                            (IPAddress v) => v.ToString(),
                            (string v) => IPAddress.Parse(v))))),
                jsonValueReaderWriter: new JsonCollectionReaderWriter<IPAddress[], IPAddress[], IPAddress>(
                    new JsonConvertedValueReaderWriter<IPAddress, string>(
                        JsonStringReaderWriter.Instance,
                        new ValueConverter<IPAddress, string>(
                            (IPAddress v) => v.ToString(),
                            (string v) => IPAddress.Parse(v)))),
                elementMapping: SqliteStringTypeMapping.Default.Clone(
                    comparer: new ValueComparer<IPAddress>(
                        (IPAddress v1, IPAddress v2) => v1 == null && v2 == null || v1 != null && v2 != null && v1.Equals(v2),
                        (IPAddress v) => v.GetHashCode(),
                        (IPAddress v) => v),
                    keyComparer: new ValueComparer<IPAddress>(
                        (IPAddress v1, IPAddress v2) => v1 == null && v2 == null || v1 != null && v2 != null && v1.Equals(v2),
                        (IPAddress v) => v.GetHashCode(),
                        (IPAddress v) => v),
                    providerValueComparer: new ValueComparer<string>(
                        (string v1, string v2) => v1 == v2,
                        (string v) => v.GetHashCode(),
                        (string v) => v),
                    mappingInfo: new RelationalTypeMappingInfo(
                        size: 45),
                    converter: new ValueConverter<IPAddress, string>(
                        (IPAddress v) => v.ToString(),
                        (string v) => IPAddress.Parse(v)),
                    jsonValueReaderWriter: new JsonConvertedValueReaderWriter<IPAddress, string>(
                        JsonStringReaderWriter.Instance,
                        new ValueConverter<IPAddress, string>(
                            (IPAddress v) => v.ToString(),
                            (string v) => IPAddress.Parse(v)))));

            var refTypeEnumerable = runtimeEntityType.AddProperty(
                "RefTypeEnumerable",
                typeof(IEnumerable<string>),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetProperty("RefTypeEnumerable", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetField("<RefTypeEnumerable>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            refTypeEnumerable.TypeMapping = SqliteStringTypeMapping.Default.Clone(
                comparer: new ListComparer<string>(new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v)),
                keyComparer: new ListComparer<string>(new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v)),
                providerValueComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                converter: new CollectionToJsonStringConverter<string>(new JsonCollectionReaderWriter<IEnumerable<string>, List<string>, string>(
                    JsonStringReaderWriter.Instance)),
                jsonValueReaderWriter: new JsonCollectionReaderWriter<IEnumerable<string>, List<string>, string>(
                    JsonStringReaderWriter.Instance),
                elementMapping: SqliteStringTypeMapping.Default);

            var refTypeIList = runtimeEntityType.AddProperty(
                "RefTypeIList",
                typeof(IList<string>),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetProperty("RefTypeIList", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetField("<RefTypeIList>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            refTypeIList.TypeMapping = SqliteStringTypeMapping.Default.Clone(
                comparer: new ListComparer<string>(new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v)),
                keyComparer: new ListComparer<string>(new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v)),
                providerValueComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                converter: new CollectionToJsonStringConverter<string>(new JsonCollectionReaderWriter<IList<string>, List<string>, string>(
                    JsonStringReaderWriter.Instance)),
                jsonValueReaderWriter: new JsonCollectionReaderWriter<IList<string>, List<string>, string>(
                    JsonStringReaderWriter.Instance),
                elementMapping: SqliteStringTypeMapping.Default);

            var refTypeList = runtimeEntityType.AddProperty(
                "RefTypeList",
                typeof(List<IPAddress>),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetProperty("RefTypeList", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetField("<RefTypeList>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            refTypeList.TypeMapping = SqliteStringTypeMapping.Default.Clone(
                comparer: new ListComparer<IPAddress>(new ValueComparer<IPAddress>(
                    (IPAddress v1, IPAddress v2) => v1 == null && v2 == null || v1 != null && v2 != null && v1.Equals(v2),
                    (IPAddress v) => v.GetHashCode(),
                    (IPAddress v) => v)),
                keyComparer: new ListComparer<IPAddress>(new ValueComparer<IPAddress>(
                    (IPAddress v1, IPAddress v2) => v1 == null && v2 == null || v1 != null && v2 != null && v1.Equals(v2),
                    (IPAddress v) => v.GetHashCode(),
                    (IPAddress v) => v)),
                providerValueComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                converter: new CollectionToJsonStringConverter<IPAddress>(new JsonCollectionReaderWriter<List<IPAddress>, List<IPAddress>, IPAddress>(
                    new JsonConvertedValueReaderWriter<IPAddress, string>(
                        JsonStringReaderWriter.Instance,
                        new ValueConverter<IPAddress, string>(
                            (IPAddress v) => v.ToString(),
                            (string v) => IPAddress.Parse(v))))),
                jsonValueReaderWriter: new JsonCollectionReaderWriter<List<IPAddress>, List<IPAddress>, IPAddress>(
                    new JsonConvertedValueReaderWriter<IPAddress, string>(
                        JsonStringReaderWriter.Instance,
                        new ValueConverter<IPAddress, string>(
                            (IPAddress v) => v.ToString(),
                            (string v) => IPAddress.Parse(v)))),
                elementMapping: SqliteStringTypeMapping.Default.Clone(
                    comparer: new ValueComparer<IPAddress>(
                        (IPAddress v1, IPAddress v2) => v1 == null && v2 == null || v1 != null && v2 != null && v1.Equals(v2),
                        (IPAddress v) => v.GetHashCode(),
                        (IPAddress v) => v),
                    keyComparer: new ValueComparer<IPAddress>(
                        (IPAddress v1, IPAddress v2) => v1 == null && v2 == null || v1 != null && v2 != null && v1.Equals(v2),
                        (IPAddress v) => v.GetHashCode(),
                        (IPAddress v) => v),
                    providerValueComparer: new ValueComparer<string>(
                        (string v1, string v2) => v1 == v2,
                        (string v) => v.GetHashCode(),
                        (string v) => v),
                    mappingInfo: new RelationalTypeMappingInfo(
                        size: 45),
                    converter: new ValueConverter<IPAddress, string>(
                        (IPAddress v) => v.ToString(),
                        (string v) => IPAddress.Parse(v)),
                    jsonValueReaderWriter: new JsonConvertedValueReaderWriter<IPAddress, string>(
                        JsonStringReaderWriter.Instance,
                        new ValueConverter<IPAddress, string>(
                            (IPAddress v) => v.ToString(),
                            (string v) => IPAddress.Parse(v)))));

            var valueTypeArray = runtimeEntityType.AddProperty(
                "ValueTypeArray",
                typeof(DateTime[]),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetProperty("ValueTypeArray", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetField("<ValueTypeArray>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            valueTypeArray.TypeMapping = SqliteStringTypeMapping.Default.Clone(
                comparer: new ListComparer<DateTime>(new ValueComparer<DateTime>(
                    (DateTime v1, DateTime v2) => v1.Equals(v2),
                    (DateTime v) => v.GetHashCode(),
                    (DateTime v) => v)),
                keyComparer: new ListComparer<DateTime>(new ValueComparer<DateTime>(
                    (DateTime v1, DateTime v2) => v1.Equals(v2),
                    (DateTime v) => v.GetHashCode(),
                    (DateTime v) => v)),
                providerValueComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                converter: new CollectionToJsonStringConverter<DateTime>(new JsonCollectionReaderWriter<DateTime[], DateTime[], DateTime>(
                    SqliteJsonDateTimeReaderWriter.Instance)),
                jsonValueReaderWriter: new JsonCollectionReaderWriter<DateTime[], DateTime[], DateTime>(
                    SqliteJsonDateTimeReaderWriter.Instance),
                elementMapping: SqliteDateTimeTypeMapping.Default);

            var valueTypeEnumerable = runtimeEntityType.AddProperty(
                "ValueTypeEnumerable",
                typeof(IEnumerable<byte>),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetProperty("ValueTypeEnumerable", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetField("<ValueTypeEnumerable>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            valueTypeEnumerable.TypeMapping = SqliteStringTypeMapping.Default.Clone(
                comparer: new ListComparer<byte>(new ValueComparer<byte>(
                    (byte v1, byte v2) => v1 == v2,
                    (byte v) => (int)v,
                    (byte v) => v)),
                keyComparer: new ListComparer<byte>(new ValueComparer<byte>(
                    (byte v1, byte v2) => v1 == v2,
                    (byte v) => (int)v,
                    (byte v) => v)),
                providerValueComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                converter: new CollectionToJsonStringConverter<byte>(new JsonCollectionReaderWriter<IEnumerable<byte>, List<byte>, byte>(
                    JsonByteReaderWriter.Instance)),
                jsonValueReaderWriter: new JsonCollectionReaderWriter<IEnumerable<byte>, List<byte>, byte>(
                    JsonByteReaderWriter.Instance),
                elementMapping: ByteTypeMapping.Default.Clone(
                    comparer: new ValueComparer<byte>(
                        (byte v1, byte v2) => v1 == v2,
                        (byte v) => (int)v,
                        (byte v) => v),
                    keyComparer: new ValueComparer<byte>(
                        (byte v1, byte v2) => v1 == v2,
                        (byte v) => (int)v,
                        (byte v) => v),
                    providerValueComparer: new ValueComparer<byte>(
                        (byte v1, byte v2) => v1 == v2,
                        (byte v) => (int)v,
                        (byte v) => v),
                    mappingInfo: new RelationalTypeMappingInfo(
                        storeTypeName: "INTEGER")));

            var valueTypeIList = runtimeEntityType.AddProperty(
                "ValueTypeIList",
                typeof(IList<byte>),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetProperty("ValueTypeIList", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetField("<ValueTypeIList>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            valueTypeIList.TypeMapping = SqliteStringTypeMapping.Default.Clone(
                comparer: new ListComparer<byte>(new ValueComparer<byte>(
                    (byte v1, byte v2) => v1 == v2,
                    (byte v) => (int)v,
                    (byte v) => v)),
                keyComparer: new ListComparer<byte>(new ValueComparer<byte>(
                    (byte v1, byte v2) => v1 == v2,
                    (byte v) => (int)v,
                    (byte v) => v)),
                providerValueComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                converter: new CollectionToJsonStringConverter<byte>(new JsonCollectionReaderWriter<IList<byte>, List<byte>, byte>(
                    JsonByteReaderWriter.Instance)),
                jsonValueReaderWriter: new JsonCollectionReaderWriter<IList<byte>, List<byte>, byte>(
                    JsonByteReaderWriter.Instance),
                elementMapping: ByteTypeMapping.Default.Clone(
                    comparer: new ValueComparer<byte>(
                        (byte v1, byte v2) => v1 == v2,
                        (byte v) => (int)v,
                        (byte v) => v),
                    keyComparer: new ValueComparer<byte>(
                        (byte v1, byte v2) => v1 == v2,
                        (byte v) => (int)v,
                        (byte v) => v),
                    providerValueComparer: new ValueComparer<byte>(
                        (byte v1, byte v2) => v1 == v2,
                        (byte v) => (int)v,
                        (byte v) => v),
                    mappingInfo: new RelationalTypeMappingInfo(
                        storeTypeName: "INTEGER")));

            var valueTypeList = runtimeEntityType.AddProperty(
                "ValueTypeList",
                typeof(List<short>),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetProperty("ValueTypeList", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetField("<ValueTypeList>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            valueTypeList.TypeMapping = SqliteStringTypeMapping.Default.Clone(
                comparer: new ListComparer<short>(new ValueComparer<short>(
                    (short v1, short v2) => v1 == v2,
                    (short v) => (int)v,
                    (short v) => v)),
                keyComparer: new ListComparer<short>(new ValueComparer<short>(
                    (short v1, short v2) => v1 == v2,
                    (short v) => (int)v,
                    (short v) => v)),
                providerValueComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                converter: new CollectionToJsonStringConverter<short>(new JsonCollectionReaderWriter<List<short>, List<short>, short>(
                    JsonInt16ReaderWriter.Instance)),
                jsonValueReaderWriter: new JsonCollectionReaderWriter<List<short>, List<short>, short>(
                    JsonInt16ReaderWriter.Instance),
                elementMapping: ShortTypeMapping.Default.Clone(
                    comparer: new ValueComparer<short>(
                        (short v1, short v2) => v1 == v2,
                        (short v) => (int)v,
                        (short v) => v),
                    keyComparer: new ValueComparer<short>(
                        (short v1, short v2) => v1 == v2,
                        (short v) => (int)v,
                        (short v) => v),
                    providerValueComparer: new ValueComparer<short>(
                        (short v1, short v2) => v1 == v2,
                        (short v) => (int)v,
                        (short v) => v),
                    mappingInfo: new RelationalTypeMappingInfo(
                        storeTypeName: "INTEGER")));

            var key = runtimeEntityType.AddKey(
                new[] { id });

            var key0 = runtimeEntityType.AddKey(
                new[] { id, alternateId });
            runtimeEntityType.SetPrimaryKey(key0);
            key0.AddAnnotation("Relational:Name", "PK");

            var index = runtimeEntityType.AddIndex(
                new[] { alternateId, id });

            return runtimeEntityType;
        }

        public static RuntimeSkipNavigation CreateSkipNavigation1(RuntimeEntityType declaringEntityType, RuntimeEntityType targetEntityType, RuntimeEntityType joinEntityType)
        {
            var skipNavigation = declaringEntityType.AddSkipNavigation(
                "Deriveds",
                targetEntityType,
                joinEntityType.FindForeignKey(
                    new[] { joinEntityType.FindProperty("PrincipalsId"), joinEntityType.FindProperty("PrincipalsAlternateId") },
                    declaringEntityType.FindKey(new[] { declaringEntityType.FindProperty("Id"), declaringEntityType.FindProperty("AlternateId") }),
                    declaringEntityType),
                true,
                false,
                typeof(ICollection<CSharpRuntimeModelCodeGeneratorTest.PrincipalBase>),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetProperty("Deriveds", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalBase).GetField("<Deriveds>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var inverse = targetEntityType.FindSkipNavigation("Principals");
            if (inverse != null)
            {
                skipNavigation.Inverse = inverse;
                inverse.Inverse = skipNavigation;
            }

            return skipNavigation;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:MappingStrategy", "TPT");
            runtimeEntityType.AddAnnotation("Relational:Schema", "mySchema");
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "PrincipalBase");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
