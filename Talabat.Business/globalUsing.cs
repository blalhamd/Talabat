﻿
global using Talabat.Core.IServices;
global using Talabat.Core.IUnit;
global using AutoMapper;
global using Talabat.Entities.entities;
global using Talabat.Shared.Exceptions;
global using Talabat.Core.Specifications;
global using Talabat.Core.DTos.Product.Requests;
global using Talabat.Core.DTos.Product.Responses;
global using Talabat.Core.DTos.ProductType.Responses;
global using Talabat.Core.DTos.Brand.Responses;
global using Talabat.Core.IRepositories.NonGeneric;
global using Talabat.Core.DTos.Authentication;
global using Talabat.Core.IServices.Authentication;
global using Microsoft.AspNetCore.Identity;
global using Talabat.Core.DTos.Authentication.Requests;
global using Talabat.Core.DTos.Authentication.Responses;
global using Talabat.DataAccess.Identity.IdentityEntities;
global using Microsoft.Extensions.Options;
global using Microsoft.IdentityModel.Tokens;
global using System.IdentityModel.Tokens.Jwt;
global using System.Security.Claims;
global using System.Text;
global using Talabat.Core.DTos.Address.Responses;
global using Microsoft.EntityFrameworkCore;
global using Talabat.Core.DTos.Basket.Requests;
global using Talabat.Entities.entities.Order;
global using Order = Talabat.Entities.entities.Order.Order;
global using Talabat.Core.DTos.Order.Responses;
global using Talabat.Core.DTos.Order.Requests;
global using Talabat.Core.DTos.DeliveryMethod.Responses;
global using Microsoft.Extensions.Configuration;
global using Stripe;
global using Talabat.Core.DTos.Basket.Responses;
global using Product = Talabat.Entities.entities.Product;
global using StackExchange.Redis;
global using System.Text.Json;
global using Talabat.Core.IServices.Cache;
global using System.ComponentModel.DataAnnotations;
global using Talabat.Core.DTos.Role.Responses;
global using Talabat.Core.IServices.Role;
global using Talabat.Core.DTos.Role.Requests;
global using Talabat.DataAccess.constants;
global using Talabat.Core.DTos.User.Requests;
global using Talabat.Core.DTos.User.Responses;
global using Talabat.Core.IServices.User;
global using Talabat.DataAccess.Identity.context;
global using Microsoft.AspNetCore.Identity.UI.Services;
global using Microsoft.AspNetCore.Hosting;
global using Talabat.Core.IServices.Email;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.WebUtilities;
global using System.Security.Cryptography;
global using Microsoft.Extensions.Logging;
global using MailKit.Net.Smtp;
global using MailKit.Security;
global using MimeKit;