﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace addressbook_tests_autoit
{
    public class GroupRemovingTests : TestBase
    {
        [Test]
        public void TestGroupRemoving() 
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            if (oldGroups.Count == 1)
            {
                GroupData groupToAdd = new GroupData
                {
                    Name = "test"
                };
                app.Groups.Add(groupToAdd);
                oldGroups.Add(groupToAdd);
            }

            GroupData toBeRemoved = oldGroups[0];
            app.Groups.Remove();
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.Remove(toBeRemoved);
            oldGroups.Sort();
            newGroups.Sort();

            Assert.AreEqual(oldGroups, newGroups);
        }
     }
}

