﻿using APAssignmentClient.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClientUnitTest.Mocs.ModelMocs
{
    public class CourseMoc : ICourseModel
    {
        public int CourseID { set; get; }
        public String CourseName { set; get; }
        public String CourseDescription { set; get; }
        public Double CoursePrice { set; get; }
        public String CourseType { set; get; }
        public int CourseDuration { set; get; }
        public bool Deleted { get; set; } = false;
        public bool Dropped { get; set; } = false;

        public void AddNewCourse(string _courseName, string _courseDescription, double _coursePrice, string _courseType, int _courseDuration)
        {
            CourseName = _courseName;
            CourseDescription = _courseDescription;
            CoursePrice = _coursePrice;
            CourseType = _courseType;
            CourseDuration = _courseDuration;
        }

        public void DeleteCourse()
        {
            Deleted = true;
        }

        public void DropSelectedCourse(int clientID, int courseID)
        {
            Dropped = true;
        }

        void ICourseModel.EditCourse(int _courseID, string _courseName, string _courseDescription, double _coursePrice, string _courseType, int _courseDuration)
        {
            throw new NotImplementedException();
        }

        public void EnrolSelectedCourse(int clientID, int courseID)
        {
            
        }

        public DataTable RetrieveAllCourses()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            dt.Columns.Add("type");
            return dt;
        }

        public String[] RetrieveCourseInformation()
        {
            return new string[]{ "1", "Test", "Test Desc", "Video Course", "0", "0.00"};
        }

        string ICourseModel.RetrieveCourseStartDate(int ClientID, int CourseID)
        {
            throw new NotImplementedException();
        }

        string ICourseModel.RetrieveCourseStatus(int ClientID, int _courseID)
        {
            throw new NotImplementedException();
        }

        DataTable ICourseModel.RetrieveEnrollableCourses(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable RetrieveEnrolledCourses(int id)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            dt.Columns.Add("type");
            dt.Columns.Add("duration");
            dt.Columns.Add("price");
            return dt;
        }

        void ICourseModel.ReturnToCourseWaitingList(int ClientID, int CourseID)
        {
            throw new NotImplementedException();
        }
    }
}
