﻿// <auto-generated />
using System;
using IoTGateway.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IoTGateway.DataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240719011950_CommentAndIndex")]
    partial class CommentAndIndex
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("IoTGateway.Model.Device", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("AutoStart")
                        .HasColumnType("INTEGER")
                        .HasComment("启动");

                    b.Property<bool>("CgUpload")
                        .HasColumnType("INTEGER")
                        .HasComment("变化上传");

                    b.Property<uint>("CmdPeriod")
                        .HasColumnType("INTEGER")
                        .HasComment("指令间隔ms");

                    b.Property<string>("CreateBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasComment("描述");

                    b.Property<string>("DeviceName")
                        .HasColumnType("TEXT")
                        .HasComment("名称");

                    b.Property<int>("DeviceTypeEnum")
                        .HasColumnType("INTEGER")
                        .HasComment("类型(组或设备)");

                    b.Property<Guid?>("DriverId")
                        .HasColumnType("TEXT")
                        .HasComment("驱动");

                    b.Property<uint>("EnforcePeriod")
                        .HasColumnType("INTEGER")
                        .HasComment("归档周期ms");

                    b.Property<uint>("Index")
                        .HasColumnType("INTEGER")
                        .HasComment("排序");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("AutoStart");

                    b.HasIndex("DeviceName");

                    b.HasIndex("DeviceTypeEnum");

                    b.HasIndex("DriverId");

                    b.HasIndex("ParentId");

                    b.ToTable("Devices");

                    b.HasComment("设备维护");
                });

            modelBuilder.Entity("IoTGateway.Model.DeviceConfig", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("DataSide")
                        .HasColumnType("INTEGER")
                        .HasComment("属性侧");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasComment("描述");

                    b.Property<string>("DeviceConfigName")
                        .HasColumnType("TEXT")
                        .HasComment("名称");

                    b.Property<Guid?>("DeviceId")
                        .HasColumnType("TEXT")
                        .HasComment("所属设备");

                    b.Property<string>("EnumInfo")
                        .HasColumnType("TEXT")
                        .HasComment("备注");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT")
                        .HasComment("值");

                    b.HasKey("ID");

                    b.HasIndex("DeviceConfigName");

                    b.HasIndex("DeviceId");

                    b.HasIndex("Value");

                    b.ToTable("DeviceConfigs");

                    b.HasComment("通讯配置");
                });

            modelBuilder.Entity("IoTGateway.Model.DeviceVariable", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Alias")
                        .HasColumnType("TEXT")
                        .HasComment("别名");

                    b.Property<int>("DataType")
                        .HasColumnType("INTEGER")
                        .HasComment("数据类型");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasComment("描述");

                    b.Property<string>("DeviceAddress")
                        .HasColumnType("TEXT")
                        .HasComment("地址");

                    b.Property<Guid?>("DeviceId")
                        .HasColumnType("TEXT")
                        .HasComment("所属设备");

                    b.Property<int>("EndianType")
                        .HasColumnType("INTEGER")
                        .HasComment("大小端");

                    b.Property<string>("Expressions")
                        .HasColumnType("TEXT")
                        .HasComment("表达式");

                    b.Property<uint>("Index")
                        .HasColumnType("INTEGER")
                        .HasComment("排序");

                    b.Property<bool>("IsTrigger")
                        .HasColumnType("INTEGER")
                        .HasComment("触发");

                    b.Property<bool>("IsUpload")
                        .HasColumnType("INTEGER")
                        .HasComment("上传");

                    b.Property<string>("Method")
                        .HasColumnType("TEXT")
                        .HasComment("方法");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasComment("变量名");

                    b.Property<int>("ProtectType")
                        .HasColumnType("INTEGER")
                        .HasComment("权限");

                    b.HasKey("ID");

                    b.HasIndex("DataType");

                    b.HasIndex("DeviceAddress");

                    b.HasIndex("DeviceId");

                    b.HasIndex("Method");

                    b.HasIndex("Name");

                    b.ToTable("DeviceVariables");

                    b.HasComment("变量配置");
                });

            modelBuilder.Entity("IoTGateway.Model.Driver", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AssembleName")
                        .HasColumnType("TEXT")
                        .HasComment("程序集名");

                    b.Property<int>("AuthorizesNum")
                        .HasColumnType("INTEGER")
                        .HasComment("剩余授权数");

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("DriverName")
                        .HasColumnType("TEXT")
                        .HasComment("驱动名");

                    b.Property<string>("FileName")
                        .HasColumnType("TEXT")
                        .HasComment("文件名");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Drivers");

                    b.HasComment("驱动管理");
                });

            modelBuilder.Entity("IoTGateway.Model.RpcLog", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasComment("描述");

                    b.Property<Guid?>("DeviceId")
                        .HasColumnType("TEXT")
                        .HasComment("所属设备");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("TEXT")
                        .HasComment("结束时间");

                    b.Property<bool>("IsSuccess")
                        .HasColumnType("INTEGER")
                        .HasComment("是否成功");

                    b.Property<string>("Method")
                        .HasColumnType("TEXT")
                        .HasComment("方法");

                    b.Property<string>("Params")
                        .HasColumnType("TEXT")
                        .HasComment("请求参数");

                    b.Property<int>("RpcSide")
                        .HasColumnType("INTEGER")
                        .HasComment("发起方");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TEXT")
                        .HasComment("开始时间");

                    b.HasKey("ID");

                    b.HasIndex("DeviceId");

                    b.ToTable("RpcLogs");

                    b.HasComment("RPC日志");
                });

            modelBuilder.Entity("IoTGateway.Model.SystemConfig", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientId")
                        .HasColumnType("TEXT")
                        .HasComment("ClientId");

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("GatewayName")
                        .HasColumnType("TEXT")
                        .HasComment("网关名称");

                    b.Property<int>("IoTPlatformType")
                        .HasColumnType("INTEGER")
                        .HasComment("输出平台");

                    b.Property<string>("MqttIp")
                        .HasColumnType("TEXT")
                        .HasComment("Mqtt服务器");

                    b.Property<int>("MqttPort")
                        .HasColumnType("INTEGER")
                        .HasComment("Mqtt端口");

                    b.Property<string>("MqttUName")
                        .HasColumnType("TEXT")
                        .HasComment("Mqtt用户名");

                    b.Property<string>("MqttUPwd")
                        .HasColumnType("TEXT")
                        .HasComment("Mqtt密码");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("SystemConfig");

                    b.HasComment("传输配置");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.ActionLog", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ActionName")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ActionTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ActionUrl")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<double>("Duration")
                        .HasColumnType("REAL");

                    b.Property<string>("IP")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("ITCode")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("LogType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ModuleName")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Remark")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("ActionLogs");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.DataPrivilege", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Domain")
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("RelateId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TableName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserCode")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("DataPrivileges");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FileAttachment", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ExtraInfo")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("FileData")
                        .HasColumnType("BLOB");

                    b.Property<string>("FileExt")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HandlerInfo")
                        .HasColumnType("TEXT");

                    b.Property<long>("Length")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Path")
                        .HasColumnType("TEXT");

                    b.Property<string>("SaveMode")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UploadTime")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("FileAttachments");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkGroup", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupCode")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupRemark")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenantCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("FrameworkGroups");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkMenu", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ActionName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClassName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("DisplayOrder")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Domain")
                        .HasColumnType("TEXT");

                    b.Property<bool>("FolderOnly")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Icon")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsInherit")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("IsInside")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MethodName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModuleName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PageName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("ShowOnMenu")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("ParentId");

                    b.ToTable("FrameworkMenus");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkRole", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleCode")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleRemark")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenantCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("FrameworkRoles");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkUser", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("CellPhone")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int?>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("HomePhone")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("ITCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsValid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("PhotoId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenantCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ZipCode")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("PhotoId");

                    b.ToTable("FrameworkUsers");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkUserGroup", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("FrameworkUserGroups");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkUserRole", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("FrameworkUserRoles");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FunctionPrivilege", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool?>("Allowed")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreateBy")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("MenuItemId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("MenuItemId");

                    b.ToTable("FunctionPrivileges");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.PersistedGrant", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Expiration")
                        .HasColumnType("TEXT");

                    b.Property<string>("RefreshToken")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("UserCode")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("PersistedGrants");
                });

            modelBuilder.Entity("IoTGateway.Model.Device", b =>
                {
                    b.HasOne("IoTGateway.Model.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId");

                    b.HasOne("IoTGateway.Model.Device", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");

                    b.Navigation("Driver");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("IoTGateway.Model.DeviceConfig", b =>
                {
                    b.HasOne("IoTGateway.Model.Device", "Device")
                        .WithMany("DeviceConfigs")
                        .HasForeignKey("DeviceId");

                    b.Navigation("Device");
                });

            modelBuilder.Entity("IoTGateway.Model.DeviceVariable", b =>
                {
                    b.HasOne("IoTGateway.Model.Device", "Device")
                        .WithMany("DeviceVariables")
                        .HasForeignKey("DeviceId");

                    b.Navigation("Device");
                });

            modelBuilder.Entity("IoTGateway.Model.RpcLog", b =>
                {
                    b.HasOne("IoTGateway.Model.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId");

                    b.Navigation("Device");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkMenu", b =>
                {
                    b.HasOne("WalkingTec.Mvvm.Core.FrameworkMenu", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkUser", b =>
                {
                    b.HasOne("WalkingTec.Mvvm.Core.FileAttachment", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Photo");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FunctionPrivilege", b =>
                {
                    b.HasOne("WalkingTec.Mvvm.Core.FrameworkMenu", "MenuItem")
                        .WithMany("Privileges")
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuItem");
                });

            modelBuilder.Entity("IoTGateway.Model.Device", b =>
                {
                    b.Navigation("Children");

                    b.Navigation("DeviceConfigs");

                    b.Navigation("DeviceVariables");
                });

            modelBuilder.Entity("WalkingTec.Mvvm.Core.FrameworkMenu", b =>
                {
                    b.Navigation("Children");

                    b.Navigation("Privileges");
                });
#pragma warning restore 612, 618
        }
    }
}
