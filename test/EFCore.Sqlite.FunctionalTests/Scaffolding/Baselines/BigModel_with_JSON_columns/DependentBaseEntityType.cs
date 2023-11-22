// <auto-generated />
using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.Sqlite.Storage.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore.ValueGeneration;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    internal partial class DependentBaseEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+DependentBase<byte?>",
                typeof(CompiledModelTestBase.DependentBase<byte?>),
                baseEntityType,
                discriminatorProperty: "EnumDiscriminator",
                discriminatorValue: CompiledModelTestBase.Enum1.One,
                derivedTypesCount: 1,
                propertyCount: 4,
                navigationCount: 1,
                foreignKeyCount: 2,
                unnamedIndexCount: 1,
                keyCount: 1);

            var principalId = runtimeEntityType.AddProperty(
                "PrincipalId",
                typeof(long),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            principalId.TypeMapping = LongTypeMapping.Default.Clone(
                comparer: new ValueComparer<long>(
                    (long v1, long v2) => v1 == v2,
                    (long v) => v.GetHashCode(),
                    (long v) => v),
                keyComparer: new ValueComparer<long>(
                    (long v1, long v2) => v1 == v2,
                    (long v) => v.GetHashCode(),
                    (long v) => v),
                providerValueComparer: new ValueComparer<long>(
                    (long v1, long v2) => v1 == v2,
                    (long v) => v.GetHashCode(),
                    (long v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "INTEGER"));

            var principalAlternateId = runtimeEntityType.AddProperty(
                "PrincipalAlternateId",
                typeof(Guid),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            principalAlternateId.TypeMapping = SqliteGuidTypeMapping.Default;

            var enumDiscriminator = runtimeEntityType.AddProperty(
                "EnumDiscriminator",
                typeof(CompiledModelTestBase.Enum1),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                valueGeneratorFactory: new DiscriminatorValueGeneratorFactory().Create);
            enumDiscriminator.TypeMapping = IntTypeMapping.Default.Clone(
                comparer: new ValueComparer<CompiledModelTestBase.Enum1>(
                    (CompiledModelTestBase.Enum1 v1, CompiledModelTestBase.Enum1 v2) => object.Equals((object)v1, (object)v2),
                    (CompiledModelTestBase.Enum1 v) => v.GetHashCode(),
                    (CompiledModelTestBase.Enum1 v) => v),
                keyComparer: new ValueComparer<CompiledModelTestBase.Enum1>(
                    (CompiledModelTestBase.Enum1 v1, CompiledModelTestBase.Enum1 v2) => object.Equals((object)v1, (object)v2),
                    (CompiledModelTestBase.Enum1 v) => v.GetHashCode(),
                    (CompiledModelTestBase.Enum1 v) => v),
                providerValueComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "INTEGER"),
                converter: new ValueConverter<CompiledModelTestBase.Enum1, int>(
                    (CompiledModelTestBase.Enum1 value) => (int)value,
                    (int value) => (CompiledModelTestBase.Enum1)value),
                jsonValueReaderWriter: new JsonConvertedValueReaderWriter<CompiledModelTestBase.Enum1, int>(
                    JsonInt32ReaderWriter.Instance,
                    new ValueConverter<CompiledModelTestBase.Enum1, int>(
                        (CompiledModelTestBase.Enum1 value) => (int)value,
                        (int value) => (CompiledModelTestBase.Enum1)value)));
            enumDiscriminator.SetSentinelFromProviderValue(0);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(byte?),
                propertyInfo: typeof(CompiledModelTestBase.DependentBase<byte?>).GetProperty("Id", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.DependentBase<byte?>).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            id.TypeMapping = ByteTypeMapping.Default.Clone(
                comparer: new ValueComparer<byte?>(
                    (Nullable<byte> v1, Nullable<byte> v2) => v1.HasValue && v2.HasValue && (byte)v1 == (byte)v2 || !v1.HasValue && !v2.HasValue,
                    (Nullable<byte> v) => v.HasValue ? (int)(byte)v : 0,
                    (Nullable<byte> v) => v.HasValue ? (Nullable<byte>)(byte)v : default(Nullable<byte>)),
                keyComparer: new ValueComparer<byte?>(
                    (Nullable<byte> v1, Nullable<byte> v2) => v1.HasValue && v2.HasValue && (byte)v1 == (byte)v2 || !v1.HasValue && !v2.HasValue,
                    (Nullable<byte> v) => v.HasValue ? (int)(byte)v : 0,
                    (Nullable<byte> v) => v.HasValue ? (Nullable<byte>)(byte)v : default(Nullable<byte>)),
                providerValueComparer: new ValueComparer<byte?>(
                    (Nullable<byte> v1, Nullable<byte> v2) => v1.HasValue && v2.HasValue && (byte)v1 == (byte)v2 || !v1.HasValue && !v2.HasValue,
                    (Nullable<byte> v) => v.HasValue ? (int)(byte)v : 0,
                    (Nullable<byte> v) => v.HasValue ? (Nullable<byte>)(byte)v : default(Nullable<byte>)),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "INTEGER"));

            var key = runtimeEntityType.AddKey(
                new[] { principalId, principalAlternateId });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { principalId },
                unique: true);

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PrincipalId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                unique: true,
                required: true);

            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PrincipalId"), declaringEntityType.FindProperty("PrincipalAlternateId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id"), principalEntityType.FindProperty("AlternateId") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.ClientNoAction,
                unique: true,
                required: true);

            var principal = declaringEntityType.AddNavigation("Principal",
                runtimeForeignKey,
                onDependent: true,
                typeof(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>),
                propertyInfo: typeof(CompiledModelTestBase.DependentBase<byte?>).GetProperty("Principal", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.DependentBase<byte?>).GetField("<Principal>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var dependent = principalEntityType.AddNavigation("Dependent",
                runtimeForeignKey,
                onDependent: false,
                typeof(CompiledModelTestBase.DependentBase<byte?>),
                propertyInfo: typeof(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>).GetProperty("Dependent", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>).GetField("<Dependent>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                eagerLoaded: true,
                lazyLoadingEnabled: false);

            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("DiscriminatorMappingComplete", false);
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:MappingStrategy", "TPH");
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "DependentBase<byte?>");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}