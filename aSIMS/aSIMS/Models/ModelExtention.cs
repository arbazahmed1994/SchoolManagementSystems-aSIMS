using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aSIMS.Models
{
    public static class ModelExtention
    {

        public static IEnumerable<SelectListItem> ToRoleSelectListItems(
            this IEnumerable<BasicModel> RoleID, int selectedCode)
        {
            return
                RoleID.OrderBy(role => role.RoleName)
                      .Select(role =>
                          new SelectListItem
                          {
                              Selected = (role.RoleID == selectedCode),
                              Text = role.RoleName,
                              Value = role.RoleID.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToCitySelectListItems(
            this IEnumerable<BasicModel> CityID, int selectedCode)
        {
            return
                CityID.OrderBy(city => city.CityName)
                      .Select(city =>
                          new SelectListItem
                          {
                              Selected = (city.CityID == selectedCode),
                              Text = city.CityName,
                              Value = city.CityID.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToGenderSelectListItems(
            this IEnumerable<BasicModel> GenderID, int selectedCode)
        {
            return
                GenderID.OrderBy(gender => gender.GenderName)
                      .Select(gender =>
                          new SelectListItem
                          {
                              Selected = (gender.GenderID == selectedCode),
                              Text = gender.GenderName,
                              Value = gender.GenderID.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToUserTypeSelectListItems(
            this IEnumerable<BasicModel> UserTypeID, int selectedCode)
        {
            return
                UserTypeID.OrderBy(userType => userType.UserTypeName)
                      .Select(userType =>
                          new SelectListItem
                          {
                              Selected = (userType.UserTypeID == selectedCode),
                              Text = userType.UserTypeName,
                              Value = userType.UserTypeID.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToDesignationSelectListItems(
            this IEnumerable<BasicModel> DesignationID, int selectedCode)
        {
            return
                DesignationID.OrderBy(designation => designation.DesignationName)
                      .Select(designation =>
                          new SelectListItem
                          {
                              Selected = (designation.DesignationID == selectedCode),
                              Text = designation.DesignationName,
                              Value = designation.DesignationID.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToGroupSectionSelectListItems(
            this IEnumerable<BasicModel> GroupSectionID, int selectedCode)
        {
            return
                GroupSectionID.OrderBy(groupSection => groupSection.GroupSectionName)
                      .Select(groupSection =>
                          new SelectListItem
                          {
                              Selected = (groupSection.GroupSectionID == selectedCode),
                              Text = groupSection.GroupSectionName,
                              Value = groupSection.GroupSectionID.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToTeacherSelectListItems(
            this IEnumerable<TeacherModel> TeacherID, int selectedCode)
        {
            return
                TeacherID.OrderBy(teacher => teacher.TeacherName)
                      .Select(teacher =>
                          new SelectListItem
                          {
                              Selected = (teacher.TeacherID == selectedCode),
                              Text = teacher.TeacherName,
                              Value = teacher.TeacherID.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToClassSelectListItems(
            this IEnumerable<ClassesModel> ClassID, int selectedCode)
        {
            return
                ClassID.OrderBy(classes => classes.ClassName)
                      .Select(classes =>
                          new SelectListItem
                          {
                              Selected = (classes.ClassID == selectedCode),
                              Text = classes.ClassName,
                              Value = classes.ClassID.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToSectionSelectListItems(
            this IEnumerable<SectionsModel> SectionID, int selectedCode)
        {
            return
                SectionID.OrderBy(section => section.SectionName)
                      .Select(section =>
                          new SelectListItem
                          {
                              Selected = (section.SectionID == selectedCode),
                              Text = section.SectionName,
                              Value = section.SectionID.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToParentSelectListItems(
            this IEnumerable<ParentModel> ParentID, int selectedCode)
        {
            return
                ParentID.OrderBy(parent => parent.ParentName)
                      .Select(parent =>
                          new SelectListItem
                          {
                              Selected = (parent.ParentID == selectedCode),
                              Text = parent.ParentName,
                              Value = parent.ParentID.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToTransportSelectListItems(
            this IEnumerable<TransportModel> TransportID, int selectedCode)
        {
            return
                TransportID.OrderBy(transport => transport.TransportName)
                      .Select(transport =>
                          new SelectListItem
                          {
                              Selected = (transport.TransportID == selectedCode),
                              Text = transport.TransportName,
                              Value = transport.TransportID.ToString()
                          });
        }

    }
}