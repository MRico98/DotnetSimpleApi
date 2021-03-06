﻿using DotnetSimpleApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;

namespace DotnetSimpleApi.Controllers
{
    public class WMprojectController : ApiController
    {
        public IHttpActionResult GetAllProjects()
        {
            IList<WMprojectViewModel> projects = null;
            using (var context = new WManagerEntities())
            {
                projects = queryGet(context).ToList<WMprojectViewModel>();
            }
            if (projects.Count == 0)
            {
                return NotFound();
            }
            return Ok(projects);
        }

        public IHttpActionResult GetProjectById(string id)
        {
            WMprojectViewModel project = null;
            using (var context = new WManagerEntities())
            {
                project = queryGet(context).Where(s => s.id == id).FirstOrDefault();
            }
            if (project == null)
            {
                return NotFound();
            }
            return Ok(project);
        }

        public IHttpActionResult PostNewProject(WMprojectViewModel project)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid Data");
            }
            using (var context = new WManagerEntities())
            {
                context.wmprojects.Add(new wmproject() 
                {
                    id = project.id,
                    name = project.name,
                    descr = project.descr,
                    acr = project.acr
                });
                context.SaveChanges();
            }
            return Ok("Todo bien");
        }

        public IHttpActionResult PutProject(WMprojectViewModel project)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid Data");
            }
            using(var context = new WManagerEntities())
            {
                wmproject existingproject = context.wmprojects.Where(s => s.id == project.id).FirstOrDefault<wmproject>();
                if(existingproject != null)
                {
                    existingproject.id = project.id;
                    existingproject.name = project.name;
                    existingproject.descr = project.descr;
                    existingproject.acr = project.acr;
                    context.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }
            return Ok();
        }

        public IHttpActionResult DeleteProject(String id)
        {
            using (var context = new WManagerEntities())
            {
                wmproject existingproject = context.wmprojects.Where(s => s.id == id).FirstOrDefault();
                context.Entry(existingproject).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
            return Ok();
        }

        private IQueryable<WMprojectViewModel> queryGet(WManagerEntities context)
        {
            return context.wmprojects
                    .Select(s => new WMprojectViewModel()
                    {
                        id = s.id,
                        name = s.name,
                        descr = s.descr,
                        acr = s.acr,
                        wmprojectaccesses = s.wmprojectaccesses.Select(z => new WMprojectaccesViewModel()
                        {
                            id = z.id,
                            project_id = z.project_id,
                            users_id = z.users_id,
                            wmuser = new WMuserViewModel()
                            {
                                id = z.wmuser.id,
                                username = z.wmuser.username,
                                email = z.wmuser.email,
                                pwd = z.wmuser.pwd,
                                route_img = z.wmuser.route_img,
                                reset_password_token = z.wmuser.reset_password_token,
                                reset_password_expires = z.wmuser.reset_password_expires,
                                status = z.wmuser.status,
                                role_id = z.wmuser.role_id,
                                name = z.wmuser.name,
                                wmrole = new WMroleViewModel()
                                {
                                    id = z.wmuser.wmrole.id,
                                    name = z.wmuser.wmrole.name,
                                    description = z.wmuser.wmrole.description
                                },
                                wmtokens = z.wmuser.wmtokens.Select(x => new WMtokenViewModel()
                                {
                                    id = x.id,
                                    token = x.token,
                                    expiration_date = x.expiration_date,
                                    id_user = x.id_user
                                }).ToList<WMtokenViewModel>()
                            }
                        }).ToList<WMprojectaccesViewModel>(),
                        wmsprints = s.wmsprints.Select(y => new WMsprintViewModel()
                        {
                            id = y.id,
                            id_project = y.id_project,
                            date_init = y.date_init,
                            date_end = y.date_end,
                            status = y.status,
                            is_completed = y.is_completed,
                            namesprint = y.namesprint,
                            wmtasks = y.wmtasks.Select(b => new WMtaskViewModel()
                            {
                                id = b.id,
                                id_sprint = b.id_sprint,
                                name = b.name,
                                type = b.type,
                                time_estimate = b.time_estimate,
                                time_worked = b.time_worked,
                                time_remaining = b.time_remaining,
                                status = b.status,
                                is_req = b.is_req,

                            }).ToList<WMtaskViewModel>()
                        }).ToList<WMsprintViewModel>()
                    });
        }
    }
}
