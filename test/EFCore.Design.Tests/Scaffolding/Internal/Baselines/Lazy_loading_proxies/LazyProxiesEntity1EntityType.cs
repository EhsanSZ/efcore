// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.InMemory.Storage.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Proxies.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding.Internal;
using Microsoft.EntityFrameworkCore.Storage.Json;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    internal partial class LazyProxiesEntity1EntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.Internal.CSharpRuntimeModelCodeGeneratorTest+LazyProxiesEntity1",
                typeof(CSharpRuntimeModelCodeGeneratorTest.LazyProxiesEntity1),
                baseEntityType,
                propertyCount: 2,
                navigationCount: 1,
                servicePropertyCount: 1,
                foreignKeyCount: 1,
                unnamedIndexCount: 1,
                keyCount: 1);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(int),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.LazyProxiesEntity1).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.LazyProxiesEntity1).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            id.TypeMapping = InMemoryTypeMapping.Default.Clone(
                comparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                keyComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                providerValueComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                clrType: typeof(int),
                jsonValueReaderWriter: JsonInt32ReaderWriter.Instance);

            var referenceNavigationId = runtimeEntityType.AddProperty(
                "ReferenceNavigationId",
                typeof(int?),
                nullable: true);
            referenceNavigationId.TypeMapping = InMemoryTypeMapping.Default.Clone(
                comparer: new ValueComparer<int?>(
                    (Nullable<int> v1, Nullable<int> v2) => v1.HasValue && v2.HasValue && (int)v1 == (int)v2 || !v1.HasValue && !v2.HasValue,
                    (Nullable<int> v) => v.HasValue ? (int)v : 0,
                    (Nullable<int> v) => v.HasValue ? (Nullable<int>)(int)v : default(Nullable<int>)),
                keyComparer: new ValueComparer<int?>(
                    (Nullable<int> v1, Nullable<int> v2) => v1.HasValue && v2.HasValue && (int)v1 == (int)v2 || !v1.HasValue && !v2.HasValue,
                    (Nullable<int> v) => v.HasValue ? (int)v : 0,
                    (Nullable<int> v) => v.HasValue ? (Nullable<int>)(int)v : default(Nullable<int>)),
                providerValueComparer: new ValueComparer<int?>(
                    (Nullable<int> v1, Nullable<int> v2) => v1.HasValue && v2.HasValue && (int)v1 == (int)v2 || !v1.HasValue && !v2.HasValue,
                    (Nullable<int> v) => v.HasValue ? (int)v : 0,
                    (Nullable<int> v) => v.HasValue ? (Nullable<int>)(int)v : default(Nullable<int>)),
                clrType: typeof(int),
                jsonValueReaderWriter: JsonInt32ReaderWriter.Instance);

            var lazyLoader = runtimeEntityType.AddServiceProperty(
                "LazyLoader",
                propertyInfo: typeof(IProxyLazyLoader).GetProperty("LazyLoader", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                serviceType: typeof(ILazyLoader));

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { referenceNavigationId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ReferenceNavigationId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType);

            var referenceNavigation = declaringEntityType.AddNavigation("ReferenceNavigation",
                runtimeForeignKey,
                onDependent: true,
                typeof(CSharpRuntimeModelCodeGeneratorTest.LazyProxiesEntity2),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.LazyProxiesEntity1).GetProperty("ReferenceNavigation", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.LazyProxiesEntity1).GetField("<ReferenceNavigation>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                propertyAccessMode: PropertyAccessMode.Field);

            var collectionNavigation = principalEntityType.AddNavigation("CollectionNavigation",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<CSharpRuntimeModelCodeGeneratorTest.LazyProxiesEntity1>),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.LazyProxiesEntity2).GetProperty("CollectionNavigation", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.LazyProxiesEntity2).GetField("<CollectionNavigation>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                propertyAccessMode: PropertyAccessMode.Field);

            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
