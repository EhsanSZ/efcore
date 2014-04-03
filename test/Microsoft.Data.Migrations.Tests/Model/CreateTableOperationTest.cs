﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Globalization;
using Microsoft.Data.Entity.Utilities;
using Microsoft.Data.Migrations.Model;
using Microsoft.Data.Relational.Model;
using Moq;
using Xunit;

namespace Microsoft.Data.Migrations.Tests.Model
{
    public class CreateTableOperationTest
    {
        [Fact]
        public void Create_and_initialize_operation()
        {
            var table = new Table("dbo.MyTable", new[] { new Column("Id", "int") });
            var createTableOperation = new CreateTableOperation(table);

            Assert.Same(table, createTableOperation.Table);
            Assert.False(createTableOperation.IsDestructiveChange);
        }

        [Fact]
        public void Dispatches_visitor()
        {
            var table = new Table("dbo.MyTable", new[] { new Column("Id", "int") });
            var createTableOperation = new CreateTableOperation(table);
            var mockVisitor = new Mock<MigrationOperationSqlGenerator>();
            var builder = new Mock<IndentedStringBuilder>();
            createTableOperation.GenerateSql(mockVisitor.Object, builder.Object, false);

            mockVisitor.Verify(g => g.Generate(createTableOperation, builder.Object, false), Times.Once());
        }
    }
}
