// <auto-generated />
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using Microsoft.EntityFrameworkCore.Storage;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    internal partial class PrincipalBasePrincipalDerivedDependentBasebyteEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "PrincipalBasePrincipalDerived<DependentBase<byte?>>",
                typeof(Dictionary<string, object>),
                baseEntityType,
                sharedClrType: true,
                indexerPropertyInfo: RuntimeEntityType.FindIndexerProperty(typeof(Dictionary<string, object>)),
                propertyBag: true,
                propertyCount: 5,
                foreignKeyCount: 2,
                unnamedIndexCount: 1,
                keyCount: 1);

            var derivedsId = runtimeEntityType.AddProperty(
                "DerivedsId",
                typeof(long),
                propertyInfo: runtimeEntityType.FindIndexerPropertyInfo(),
                afterSaveBehavior: PropertySaveBehavior.Throw);
            derivedsId.TypeMapping = SqlServerLongTypeMapping.Default.Clone(
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
                    (long v) => v));
            derivedsId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var derivedsAlternateId = runtimeEntityType.AddProperty(
                "DerivedsAlternateId",
                typeof(Guid),
                propertyInfo: runtimeEntityType.FindIndexerPropertyInfo(),
                afterSaveBehavior: PropertySaveBehavior.Throw);
            derivedsAlternateId.TypeMapping = GuidTypeMapping.Default.Clone(
                comparer: new ValueComparer<Guid>(
                    (Guid v1, Guid v2) => v1 == v2,
                    (Guid v) => v.GetHashCode(),
                    (Guid v) => v),
                keyComparer: new ValueComparer<Guid>(
                    (Guid v1, Guid v2) => v1 == v2,
                    (Guid v) => v.GetHashCode(),
                    (Guid v) => v),
                providerValueComparer: new ValueComparer<Guid>(
                    (Guid v1, Guid v2) => v1 == v2,
                    (Guid v) => v.GetHashCode(),
                    (Guid v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "uniqueidentifier"));
            derivedsAlternateId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var principalsId = runtimeEntityType.AddProperty(
                "PrincipalsId",
                typeof(long),
                propertyInfo: runtimeEntityType.FindIndexerPropertyInfo(),
                afterSaveBehavior: PropertySaveBehavior.Throw);
            principalsId.TypeMapping = SqlServerLongTypeMapping.Default.Clone(
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
                    (long v) => v));
            principalsId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var principalsAlternateId = runtimeEntityType.AddProperty(
                "PrincipalsAlternateId",
                typeof(Guid),
                propertyInfo: runtimeEntityType.FindIndexerPropertyInfo(),
                afterSaveBehavior: PropertySaveBehavior.Throw);
            principalsAlternateId.TypeMapping = GuidTypeMapping.Default.Clone(
                comparer: new ValueComparer<Guid>(
                    (Guid v1, Guid v2) => v1 == v2,
                    (Guid v) => v.GetHashCode(),
                    (Guid v) => v),
                keyComparer: new ValueComparer<Guid>(
                    (Guid v1, Guid v2) => v1 == v2,
                    (Guid v) => v.GetHashCode(),
                    (Guid v) => v),
                providerValueComparer: new ValueComparer<Guid>(
                    (Guid v1, Guid v2) => v1 == v2,
                    (Guid v) => v.GetHashCode(),
                    (Guid v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "uniqueidentifier"));
            principalsAlternateId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var rowid = runtimeEntityType.AddProperty(
                "rowid",
                typeof(byte[]),
                propertyInfo: runtimeEntityType.FindIndexerPropertyInfo(),
                nullable: true,
                concurrencyToken: true,
                valueGenerated: ValueGenerated.OnAddOrUpdate,
                beforeSaveBehavior: PropertySaveBehavior.Ignore,
                afterSaveBehavior: PropertySaveBehavior.Ignore);
            rowid.TypeMapping = SqlServerByteArrayTypeMapping.Default.Clone(
                comparer: new ValueComparer<byte[]>(
                    (Byte[] v1, Byte[] v2) => StructuralComparisons.StructuralEqualityComparer.Equals(v1, v2),
                    (Byte[] v) => StructuralComparisons.StructuralEqualityComparer.GetHashCode(v),
                    (Byte[] v) => v.ToArray()),
                keyComparer: new ValueComparer<byte[]>(
                    (Byte[] v1, Byte[] v2) => StructuralComparisons.StructuralEqualityComparer.Equals((object)v1, (object)v2),
                    (Byte[] v) => StructuralComparisons.StructuralEqualityComparer.GetHashCode((object)v),
                    (Byte[] source) => source.ToArray()),
                providerValueComparer: new ValueComparer<byte[]>(
                    (Byte[] v1, Byte[] v2) => StructuralComparisons.StructuralEqualityComparer.Equals((object)v1, (object)v2),
                    (Byte[] v) => StructuralComparisons.StructuralEqualityComparer.GetHashCode((object)v),
                    (Byte[] source) => source.ToArray()),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "rowversion",
                    size: 8),
                storeTypePostfix: StoreTypePostfix.None);
            rowid.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { derivedsId, derivedsAlternateId, principalsId, principalsAlternateId });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { principalsId, principalsAlternateId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("DerivedsId"), declaringEntityType.FindProperty("DerivedsAlternateId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id"), principalEntityType.FindProperty("AlternateId") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                required: true);

            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PrincipalsId"), declaringEntityType.FindProperty("PrincipalsAlternateId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id"), principalEntityType.FindProperty("AlternateId") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.ClientCascade,
                required: true);

            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "PrincipalBasePrincipalDerived<DependentBase<byte?>>");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
