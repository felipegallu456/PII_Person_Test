//-----------------------------------------------------------------------------
// <copyright file="PersonTests.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.IO;
using NUnit.Framework;


namespace Ucu.Poo.Persons.Tests
{
    [TestFixture]
    public class PersonTests
    {
        

        [Test]
        public void Id_WhenSet_UpdatesValue()
        {
            // Arrange
            const string name = "Felipe Galluzzo";
            const string initialId = "1234567-9"; // Cédula base válida
            Person person = new Person(name, initialId);
            const string anotherId = "5714478-4"; // Cédula nueva válida

            // Act
            person.Id = anotherId;

            // Assert
            Assert.That(person.Id, Is.EqualTo(anotherId));
        }

        [Test]
        public void Id_WhenInvalid_DoesNotUpdateValue()
        {
            // Arrange
            const string name = "Felipe Galluzzo";
            const string initialId = "1234567-9";
            Person person = new Person(name, initialId);
            const string invalidId = "1234567-0"; // Cédula inválida

            // Act
            person.Id = invalidId;

            // Assert
            Assert.That(person.Id, Is.EqualTo(initialId));
        }
    } 
} 
