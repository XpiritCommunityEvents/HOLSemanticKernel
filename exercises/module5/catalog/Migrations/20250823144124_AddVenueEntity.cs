using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GloboTicket.Catalog.Migrations
{
    /// <inheritdoc />
    public partial class AddVenueEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0020fc11-753d-4888-9db8-e4fa21e773e1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("00373f9a-3b48-4319-b0d9-aed4d1440383"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0087204e-410d-432c-8191-6a79195f7f4c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("00f38e8d-315d-4231-8e34-cc864c5d80e0"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("00f91d21-7577-49a5-9883-a99d4ddbaabc"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("01ce86ac-f1af-4533-bd6f-a06be542adf2"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("02076f8d-6426-4f41-a057-41edecde37b6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0224e603-0f19-45ee-8aee-874c9aa846f1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("02c736a8-59dd-4b69-b41d-5f566683086e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("03cadeb0-e294-407b-9214-4f33709eee7a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("03ff1661-c9e7-4b15-ba78-5e0360ab884a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("04941cee-061a-49f6-ab6d-a1632d9ce5ec"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("04d7110a-fd59-4bcc-94c0-647755f560c6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("04ef7caa-34ba-4b7f-a415-bda43c20bcda"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("050d23b4-d4f4-4356-acfb-2051f775ee5a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("06665687-c6cd-4778-a3ae-0a5255513fac"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("067ce0cc-3439-4d20-82cc-23bfa4568358"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("07d10000-5443-4c95-83a3-398f575b5719"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("07f70730-afbf-418e-9acb-53058d2554cf"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("08d713de-06af-48a0-b9c0-69d1d5a1e900"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("09216e8a-16d8-4b20-a951-3592fa111d21"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("094a3af6-1608-4403-862b-55f76ff5ed5a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("09b1180f-e5c7-4f0b-8bf6-0f1412fef83c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("09cf9290-9dfe-419c-a843-10757cfb20ba"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0ae2b7f1-8f46-4bcb-a1be-aa960b0f42b1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0b4c4a35-60b1-4539-8b32-71b6486c28d4"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0b6a6e70-f04e-49a8-bf76-b4f812990757"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0c300edd-7583-4bd4-863f-04c91fe943b7"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0c356008-66c0-4dc6-a5c4-476f8da1fc74"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0c8ef135-97b4-48ca-8265-3dd01da88be3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0cf5b1b8-e378-4f80-bba0-c85877958f5c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0e0ce6cc-a690-4dba-af23-5bfd5ae6aa28"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0eb02058-9252-4345-acbc-ebd5fbfdd8f5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0f31db2e-ecef-4127-a8ad-e3ddaaf8a0dc"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0f3e8edf-f3bf-4db5-b707-64661a547401"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("11185bf4-164e-4f24-bd03-b20291d2d376"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("111b86d7-ecb5-43a7-8bb8-2540ec0fbcf7"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("11507585-9a36-46a8-8e7b-45d76bdab29c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("119f45e9-a57f-4fe1-bf8d-4728af4f9649"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1288b94f-0ff2-404e-a429-eca37d4624b8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("12fa4815-6101-4374-a86d-6ff1d3573938"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("14b5428b-d347-46c4-8182-f628d6c6ed09"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("14ec505d-ea2e-4c58-800e-3ebd84fd0dfc"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("158c45b8-fa86-4a46-a4db-b5ad62d5f2d2"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("15fa36c7-3326-4818-83d7-dbf546b584cc"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1629130a-ac63-4e98-9d5d-56e56c0fde6e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("16a4b8d7-d80c-480b-82ba-62fc88ebe823"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("182616ff-5b2d-43ad-b151-b1ee84567c81"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("18299109-f70c-491b-9385-a9a68a7a0e24"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("19654cba-70eb-497f-90e7-f40a09fe3ed7"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("19884de4-fedc-4707-9e14-1253f01653fe"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("19f79db9-ae23-42b2-83e1-f6d57aa6801a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1b371b07-27a0-4c2b-84b3-8c7c6ef72bc1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1cbbb01c-b936-4a22-96bb-deb9e21bd866"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1d16439a-7426-484c-90f7-be36ec2d39d9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1d60e7c4-55a6-4a66-9453-221249e15b27"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1dd5e4ac-24f9-4344-ab02-c801d7f462e5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1e756dfe-4c0f-46dc-9dab-6e4e0d1d1db2"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1ea9a18a-75d1-48e8-9153-007a45cf4378"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1ff53ad9-ab38-495b-a04a-e58394655d0e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("20b92233-b622-455c-bdbb-0c3893fa5142"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("20bc484c-ef01-413b-ac6e-75861cf1e1be"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("20c8cc38-2989-41cd-b1ed-415cbd2fd1eb"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("20d9ea22-8014-40bd-b942-06c0dab16544"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("21612706-9d6d-40b7-9f0c-0041d07a15c9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("22631533-7aff-46a5-9a01-505f3b96fb3d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("22994573-7bf0-4edd-b747-607682231479"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2303af90-a10b-4b62-92af-28a4d0ae32b8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("237f0f60-0e3b-4017-88a3-ea719f522a84"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("23e183ba-cfc1-4a08-ab3a-a41ea9c41a98"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("23f6fd61-b0d5-4a0d-83b5-6811a0314236"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("242a0cb1-42c7-419b-9db8-e6a4610fe749"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("244f6870-1dd3-412e-8488-1baf643e16cf"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("245b7ed5-1d25-4406-a696-235024030747"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2480b99a-5334-4761-b6e0-77535b7798d3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("25743468-5e02-4b41-ad13-6a02af8d4a38"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2580e505-7f21-4ea4-a350-a71792c1ceb8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("25a494b6-24c6-4e28-a803-e839f3e896ff"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("25ab0895-8a7a-4ac6-973f-7b7b4eb664a6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("25d79850-a581-4b5e-b221-bb46ecb32417"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("260ed405-b83e-438c-83bf-4e3139f09aba"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2618631d-0531-45ce-a87e-7e44bc401b1b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("26872b8d-ec5f-46e3-b748-5ae507beb996"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("26f623a8-324c-4cdd-ab6b-2d447bdd9fb4"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("276f8383-a334-48a9-a7e6-87e7725be161"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2a4022ed-a403-49f6-8dab-47ec446f1e2c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2c2a8546-3eee-4f79-8270-cefe7b7af0d8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2c35aabd-eae0-4054-b9fc-5f47646bbc7e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2c477f81-a225-4a62-8c5c-4eb0c4afe6c0"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2cc892bc-9100-488c-bde2-850ea4ab35c8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2d4db6ca-1d76-46a0-aa4a-d1ec1a2bb923"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2d634a99-5bbd-4bb9-9aba-9b5d08c7364b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2e3909cf-fe1a-4613-bd28-5beab2ec3ef3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2e3ae5b7-1146-4a1e-8bea-ccc090a685ce"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2e4836f9-dee1-4357-8716-5ce7e534f31a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2e9a8458-91b0-4922-89c9-5b1774ec226b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2eb6d517-0c77-4c19-80b9-5f6320fa861f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2f2e617a-32cb-43f2-8b67-1b1b539bedf6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("304447b5-3c2c-45ed-86de-a724c5adef88"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("308ebbb8-c6ec-40e5-9cda-acba1a8431da"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("30fd0bd7-91ea-45da-a0a0-ec89b8903486"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("311c82d1-2cc1-47cc-9d8a-4c60d6ac35e4"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("31ff03e0-b0fc-40c4-a800-be3a4beee81d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("322d2a2e-4144-4e6a-94e1-aa510971c842"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("331bfd43-a438-48e6-a0ff-112b8da154e6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("33717686-c6ad-4aa8-b270-f1dbd348bc1a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("33b938b7-ccaf-423e-8454-dde7b628892d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("343428fd-3552-44f6-8961-c8e842556779"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("365416b3-034f-4ea4-8a75-a62bd5b2c020"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("367ec36c-0938-4527-8b3b-c01b7112a9ac"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3867fd11-a509-47c9-9c55-fbeb1dc8cc27"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("38983fb1-07bd-40ed-b39b-42bc631c85c3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("38fb3f52-15a1-4994-85dd-c4066d9cfe83"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("39d69e08-4a1d-4eb9-8271-c4ad640cf921"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3a2038d4-c7a1-400f-88b8-67ae7dad0a9f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3a6465be-c993-49c4-9589-9aff82690abe"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3b76f92e-73be-467e-9ea2-394840d8fa46"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3c4a0d47-6ba0-478e-8a62-863ed0e925bb"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3c54402d-9861-4e42-90a1-1409595253ce"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3cc2afbb-a7dd-4c07-b3ce-a46c74dfddb3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3ce4f7a6-a4c3-4bd1-b787-e6d20c4d3821"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3d46a779-822a-44e7-84e3-d6da9f37fcbf"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3d737566-9c33-43a2-964d-652d41f9b745"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3dbd6f46-7d63-4b41-8862-9debe9beefba"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3ddc8433-32f7-4d3f-86f2-7188bf9c0122"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3f1d58a5-fb84-47a2-b0fe-f5181c381ce0"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3f35ce2b-24f8-49de-b663-da1a82951bcc"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3f9a6bf4-7173-42e5-9d97-2d7a4ac5e335"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3fb9a6d3-da9b-4132-893d-6e7e954fd412"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("416b5648-2478-48cc-bedc-627a53014a2b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4218d8b0-7b94-4582-9795-e0bc8307792f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4220f8bc-ee6d-4568-b092-cb94b9db2b00"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("42b8ecb4-d1e4-4416-b537-bb07ae0cbc79"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("43248ccb-85dc-4203-b91c-6341c5646464"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4379e8ac-d487-4173-84fb-448cee5257ac"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("439773ac-9d12-4c5b-9294-6cc7975bc077"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4397d272-827c-4d79-8aba-5c9788eca5c5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("44c3cf12-8152-41c6-a357-2dbb940bfec5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4503423a-e6e9-4a50-9882-930b9ee5663a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4576cd89-1b78-4530-b48f-b78fd806236f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("477a1c52-ae93-42fa-9d6b-3d566fdd117b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("49d86956-6d93-4c75-91aa-253cade68c7f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4a71c91e-2171-41cb-94ce-377d5ba0fd40"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4b6fe349-e9f5-4659-9cd0-dd6bbb121c1c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4b95141f-90bd-4630-90bf-aab053e2bb8d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4b95de1c-bb34-4459-b253-65f033cb5102"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4c76ad0f-62c8-42ef-b459-70f444424edb"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4d16287e-d209-4bc1-97fd-9aa843d089c7"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4d4bf6d4-0d5f-49a5-9d1b-f226fab24c18"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4da78141-d978-4a90-b79c-57d93a20ee0a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4e10f08b-c0c1-434b-80b9-0102c6afe525"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4e36bf23-5738-4dfa-aefc-a5de494ff09e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4e444149-bd57-4173-9c56-4fabd349c837"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4ea26c15-6df9-4c91-9a87-9e8941720e32"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4f0a232a-2c64-4183-bd97-6401cccd4cb2"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4f377302-71b1-41e9-979e-f42ae724fd00"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4f3c9c29-65d4-496c-8ae4-f9673f1e0777"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4fd44eb9-3b2f-4eb9-b2c1-26fb54a82a6e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("50f16bb3-e002-470f-869d-0ec4ee3eb55d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("513625ff-75d2-41a1-8e09-b56d41da4a29"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5167c2db-50a2-4ee2-808b-ae9b28af39cc"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("51b9e8df-ad25-4aef-9d70-d38b37dc2aad"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("522b9462-9033-4183-b076-153bcec52d8e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5269c1c1-ae99-405e-a2c0-1fe3c0e17a42"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("52aaec0e-140a-48fb-8045-562fe9651e40"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("52d449ee-255b-4fe7-9f14-d421bd0a4fec"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5321e747-d096-4344-ad0e-03e5d74632ac"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("544a1512-0e26-4fa0-9550-b4213b01b374"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5525638e-24ec-4203-8aa0-941f2e04c77c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5588dd39-8f60-4015-b01d-34f75036be80"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("56a29570-91aa-4ce1-8670-2a41fe683446"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("56a865da-d0b4-4215-9374-d3520d52a4d5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("57a02302-0c36-4a90-ae17-4a2ca692fbe3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5887c9f9-0d38-4734-b920-f19b2cc8b6ee"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("58a49bd2-ddf1-477b-87be-a5995f5af29d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("58ef4467-e322-4f3a-b2d2-3001c1207555"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("596fbc7f-1b63-44a5-9494-b19db5e88ffb"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5a64ae9a-0b02-40a7-b93b-4615305c9b4f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5b145460-204f-48e1-adc4-0754ead45026"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5b6fb50e-c170-4ba6-aa4a-e4ddb5703c35"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5bc66044-5440-4ca8-8922-e6c02a2a1673"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5bf4acdb-05ff-4ec3-860d-5ef8cd019ba8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5cad066b-1b97-4397-b5e8-1c28fd305266"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5d774431-7464-428f-beb4-fd7bdaa92994"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5ed021c4-9029-47e0-aa25-6090efc02d18"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5ee075ec-7a8d-4d23-8fdb-09f49b32de7a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5f84a2f3-1ca1-46a4-b5c1-26218b724f83"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5fc3ca71-d2ee-4d74-a5c5-519eb5bfb62b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5fce1582-cbd2-43b9-9bce-6b1e4df714c4"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5fef34c1-992c-4d24-a8d5-ec4044aa133c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("60880711-b993-4fe6-93db-d515d9049b38"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("60eed1df-1e18-4706-a6b3-55ffc5f61243"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("62a47ca3-5a5c-4419-87f4-7923a1f9e313"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("62b993f5-476e-4a85-9d0d-1f6953407347"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("63944325-a563-4a0d-885e-c12e6806f7f1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6444a912-7824-4118-b60c-182209d0e962"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6446a763-2875-469f-bb6b-117f98891e10"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("649f1d57-7cff-45e7-8105-c5bd175e6924"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6531282a-0652-4540-bdd8-a8f5ba404291"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("65f47a51-35c1-4d47-b0a6-650d3f72cd94"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("66232a6b-a66f-4170-bedf-f7532c760b5c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6665c92f-5708-4f40-9dc2-cf242d779165"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("67027da6-3d0c-4bc3-9793-05872d9fa8d6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("67140273-0d17-46f5-9841-cc304fa32262"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("67c907ac-fe4c-4d30-ae68-b9f11475768b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("68d2f51e-c712-4920-b410-539877ae1efe"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("696eb979-6608-4abe-a221-1b225fc4f783"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("699c87e6-2081-42e2-8edc-9a5b9cf7d4e9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("69bad7ec-adee-45da-b69d-c696593d6cac"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("69e211f1-15b6-4cdf-bb79-c73702be5d14"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6a2ab17e-56c8-4454-a91e-02129445a752"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6a3b87fd-4e7c-4d88-8a05-6bc0e37993f6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6ae7d192-cfd4-4379-8c56-e2435d81d8d4"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6bfb1957-9859-4c2d-97f4-8203c3710175"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6c4d4dc0-1917-4677-9689-898742c1260c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6c8c4183-6ad0-4bff-917c-8cdf7b4816d9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6da0e172-4020-4192-add2-9555b0483771"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6dbe3815-b16c-4cb8-9aa8-edb3eec82484"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6de1db8f-f421-431a-8b84-5167eb4464f9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6f0c0882-c528-49be-b8f8-ff4c103189ac"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6fbfee98-200d-42e8-a605-5256fb692ae2"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("70273272-0f3b-4d53-8757-f99bfb42e7d4"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("70b69969-081b-4992-adbe-520da62f5c64"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("70cb1b59-6a2a-4e39-9135-75aeec4f0581"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("711bc706-c902-4777-9810-71952df4d70e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7171f6c0-4f39-4f92-9799-85ca96839725"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("71783ff9-7877-4899-93bb-834ba5beb908"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7204d1f2-c681-45b0-8657-7643a7e45be5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("747ae6a8-8cdd-4274-9147-14fb5cd7f28f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("748f1579-5149-4c69-8195-6788373141f5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("74b528c0-5b03-43b4-9216-e06cc9cfd104"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("74b6d9fa-fa99-4310-842d-354e8c2753d7"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("753e6a15-641f-44ce-8fe9-78da8a37c09f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("756b79e8-51a2-4949-9e06-a11e40b1d898"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7596d18e-2b90-4ba5-9a03-3d77ea34d790"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("75c8aacb-ed4e-4c93-b971-c76acf191855"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7601a4eb-7f98-4e64-b4aa-ebe4d4d830fb"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("76146ee4-c46f-4f01-852f-941cde949f21"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7629c32d-a289-4096-aee9-8e2f31522de2"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("77130c6b-fce7-4d57-b9c0-162be24995e0"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("77f73100-3a60-4fef-abbb-8b973cba27f5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("79169e79-49c7-4998-a7c7-216026af4fba"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("79f59bcb-922a-464d-9161-988c07335b3b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7a801b92-e4c4-430e-aa42-37e8ff5ba870"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7b316ccb-222d-4a60-ad1c-97ac02ac9735"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7de8f470-e03c-41c5-8102-5676330563a1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7e73b207-16b3-42a8-90d7-69c17c7870d2"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7e7d6547-cebb-46f4-80c2-ddd4268857d2"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7f16ea30-b447-4eda-90e6-14afc4ba3c5d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7f1ded22-965f-4ca0-a2b4-229006e30951"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7f49729e-b4ea-4b1f-a34d-851d5e0d5f20"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7f7b56a5-0f40-4ca0-abeb-4e8e9be25215"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7f8521b4-0d48-4e93-abb9-f1348e60ab6d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7fe1259d-be30-43ae-9b9c-e29e0d047bbd"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("801e2be3-dd1d-4ddd-8d79-9c52586ad8b2"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("80916bc8-bcb9-4a6d-b5af-3cc9f8ac4a92"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8192e64d-49c7-4a29-ba01-0c1c282b04e7"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("81b4e51e-b4c6-498b-9dd5-914c90c7b67f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("82550119-6afd-41a4-87a3-584a453ac0f0"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("82f3e4d9-4431-4302-8c4d-744cea0b9170"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8464c67a-a245-499b-a0ca-95adc371d632"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("848e20e1-6607-4594-ab20-73b27d909671"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("85351872-3172-4054-b432-7cafed6b96d8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("853b80d0-f15d-4703-85f7-5f2bae8e8dad"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("85a46e30-c3c9-4727-8d36-389c4ab1b573"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("86d519ea-eebe-458f-8d9f-a64cea9035f6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("88174415-0ee1-4a73-8829-1547d1a03753"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("881c2e7a-268f-436e-8310-1dd0aaa67099"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("88b2549d-5e44-46d8-9e36-886b2da1bb4c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8b2cf93a-3076-4da6-aa3f-bdf0b6eb3173"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8b2fedbd-27d9-47db-a53d-d33ddb5cae50"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8bd165f6-031b-4950-a248-34f5ac424515"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8be47cdc-43f1-48d6-b07a-347ead4408c9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8e37250c-ffcc-41ca-9ccb-ae062e198c8d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("90f72e20-1458-41ed-8834-d6da14ac2f4c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9126c2da-52b6-4012-9afb-bb8d02173fef"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("92214b97-6801-4863-8f86-635fb3758bed"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9221c2a1-4e6e-417e-810c-c2d4dd05587e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9228b689-0ff1-4515-9636-a63d7cedc2e0"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("925b6c49-4bd2-402a-b29f-1a964ff95814"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("925f2acc-fff1-493f-9c14-d7295319cbda"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("92840db6-ee55-4bb2-8e2b-99dcb9bb9c3a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9333d294-bb8c-4ccf-8be6-4bac505c37e6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9340b9df-3bda-4f8a-9ab0-5020afaeb6ad"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("93fa4cfa-706c-4703-96b4-a0112d6bc259"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9423dbd9-0446-405f-88f5-75fa95de793a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9521e066-42a8-49c3-8264-5135de1dea97"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("95f0065c-baac-4f7a-8720-771b9d5ff7fb"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("97577af2-afff-4ca3-9e72-76df0d283443"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("985ecc25-d366-46db-b763-03e9a5b1b856"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("99a8a7db-a3a7-4dce-89c3-7d897ad11509"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9b3f738f-4dd1-47e7-a8e8-341c527e40c9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9b6c99f7-bc5a-4f74-bd79-09e89678ff89"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9c3bba5e-8f3e-4778-a903-bf55994f8afc"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9c75e58c-ac98-4235-a9f8-479f068fc690"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9c9b4d62-c153-458e-bffe-2b6c9afa4c0f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9d04ec85-b14c-4217-b4b4-33397891d299"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9d4505b9-f728-40b6-8368-efa59a6554ee"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9d894930-9f48-4f56-9e88-fab403d28185"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9db56131-3562-44e2-b91d-bb54f4249ac1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9e18871d-b88e-4923-8c4f-ff2d326bc888"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9e7ca4db-c9ee-4aa5-aa02-2961497c4645"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9f829696-72be-4355-aaae-a7aecada6a61"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a00fd1b1-9e92-4a28-8fb4-326c36d2fafa"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a053b7ce-91c3-436c-8479-24bef7254641"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a064b179-0d23-4050-91c1-01dfea8a712d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a16746cf-de38-4d95-b5f0-50dae62421f5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a28d8b02-48e3-4363-9112-14921df50126"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a33b165f-d6ea-4d73-b899-7911a5b65ca6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a3fd9d0f-3421-473a-897e-880e29966abd"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a405785f-6123-46b1-bfdc-09dce3cbe863"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a661a632-8aa2-40d8-96cd-8943191ad0be"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a6c75b9c-7b47-4f21-a91d-e1c43e8f777f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a818355a-a3d6-4407-944f-84df5be56407"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a81d5d54-7b7a-4889-b463-41eae8a1c40d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a92aefc1-f835-41c1-86c0-b46456b27c8a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a9dd68fb-fa2c-4529-97e7-a328433f203c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("aaabd613-3bef-488b-b777-d7ca894b432e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("aabcd256-c407-4fea-8024-f8a6c7a8f6f1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("aac789ae-c519-48dc-b299-487d41a0ddc3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("aad4f2d8-94d4-4aba-9823-8ec000df8534"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ab337a81-3455-4b83-8c5e-83103eaa8e25"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ab4c1e9e-228f-4677-8b48-4094556246f3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ac77b06a-c723-4864-af06-bd07bea97997"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("aca0b815-1983-4fa0-a0f9-747871edd03f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ada95914-e51a-43e3-95f0-3b8f88dc1d20"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("adfedcfb-19f7-49b5-b305-ce87edf9ad22"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("aea373ff-3bdb-4317-bd6e-2399ac0dcb18"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("af4a647c-44fa-4d89-8717-4c3b85f502dc"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b130e551-026f-49a6-8631-ca77358d196e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b16f2b44-0b24-412d-a057-045af62ef83f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b17c69ad-04a8-4125-af43-8eb4f298e83d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b1f17cd1-d916-49a6-af35-acd7c2adda3a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b26c265c-2234-4a00-9377-510aa51a85f6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b35da37d-5dfa-46f0-88db-b67d8a92dbb8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b365d380-162e-48f4-932c-03eec8638b27"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b38155eb-04ed-4ac1-832b-ab14b5ff0491"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b510267c-9e61-44d4-99b1-bcc08e0c5326"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b539aa30-4634-4d7f-a8ed-49ab6163d5f8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b56890a5-eb79-446a-adf7-962567d94647"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b5877e39-758a-4028-9a27-b3d886b1f6b6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b5dcc107-213f-41b6-bccb-099cc8ca8be9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b63f557f-37f0-493d-9cd6-941447320b6b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b6f2cd98-b8f7-4e4b-a882-28863be59251"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b7d232de-3e0c-405f-9baf-f7c6fd708002"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b9068a09-6635-47b8-b4d6-b1998ac94ba9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b93a563d-0d74-47f6-bdb2-82ad22d7bd8e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b95723b8-9f75-4ba3-bb68-629ac21380ff"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b9ab382b-6363-4987-94b8-38d49a72df15"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b9e807f2-47e8-4118-8d6f-08cfec9f9319"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ba313f8a-fcff-48cd-9f92-f696a0477019"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ba5371e6-bf03-4178-9f65-74f84654fdeb"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ba5fb1e1-7d2c-4abc-af88-c2bfb5400999"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ba8db4f2-d6b0-4be9-9294-b64222c38709"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("bb126abc-22ff-4170-a618-a9992da6b839"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("bc08acd0-a20f-4c75-bf9b-bcbe0cd84e95"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("bc13d639-6fad-49e1-9738-0acf668a2e6f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("bc2dd774-afe5-4614-9ce4-84f1d5e84117"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("bc468210-b887-4a0f-87e0-c66caa49d572"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("bd838b2b-d820-40e9-9b68-60eaef46daad"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("be5321d2-47b6-47a4-b151-beb09222dde3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("be7bf81c-103a-4d47-8c89-bb1d6450ad1f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("be9e8daa-4a67-4914-8ef0-d1d6202c454c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("beb76f89-1093-45cf-83e2-6dd7f66893aa"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("bf305b31-7bce-4c42-9bd2-5a3a0f378f05"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c01d13a1-b17e-49cd-9a37-d83360ef6fbc"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c0644c18-2338-4a47-9fde-1186a50e14ae"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c15f369d-fab0-42ef-a4a8-14cf781063a9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c1738e76-3906-4670-9b4b-8ea10efb7e52"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c1af6b47-f778-4ace-b806-6b613959fb17"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c27f9865-bea8-47d1-a136-0f991daa8604"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c297369f-b4af-4c54-a803-4d135556297c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c2dd055b-8cca-465d-bc59-a51e925721f7"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c3567330-1f4c-4094-9b72-eab213bcacbf"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c494bba3-3f60-449a-b64d-b92ecb280a01"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c6592853-74b8-45df-a844-2b02f2c7b341"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c7018f4f-be0f-4e69-8288-01a5461c482b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c7523161-18ba-4046-a606-3e806fa93822"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c8195177-0095-4e49-8061-e0d0112d11ee"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c927ea42-a37f-4bbe-a88a-f8c9e6941b0a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c962865e-fd5e-4fe3-be64-1093fee2e40d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ca2f63e0-6546-4439-8604-7b4e9a680a0c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cae3835c-5e78-4df3-9ea8-ccc0c26cdd6f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cb992983-5d86-4839-a61d-8e41380dd806"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cc19591b-a5f2-44b9-b5a4-94c8829ded05"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cc27653c-27e6-41f1-8b21-0c7fad3471d1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cd2ecb64-7ba0-49f5-a48e-fafe4f92bb4c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cd36973e-2ac5-4002-b6f3-ea9d173177e3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cd5480c3-a17d-492b-a9ac-e58009f39cbc"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cdd7656e-4965-4575-9fa8-f7313cfcd509"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cefadec6-58fc-494a-ad84-014e6a18ce9e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cf2b0c85-ef3f-4a58-8e74-ca2b4a8285e4"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d034edb0-3c86-4e9e-b281-6f15708ccc7d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d083d7b0-6ad3-428b-8080-4ef1e4e2964c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d0ce860b-0bb9-4ac8-9200-153937b64794"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d0f84b1d-fb24-49be-982a-01cc43842586"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d2062943-753e-4005-afec-9479038e5625"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d334d566-dca6-40a6-99cc-a36526e5c49b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d424fa97-96d6-4e88-9685-5aedc0c07016"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d4535c0b-d0fc-44b9-b2b8-9afc97f29c20"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d49ed9be-56fa-4492-9b29-a1ec31c05a23"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d5686553-3e12-4d3e-8443-8d559501a989"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d6512eaf-08a7-4bb7-8613-7246dd76a9f5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d69e8e68-0073-4709-ac94-2ca778aed9fb"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d7051755-3ec3-49f3-a2e9-1a1cfa0ff4b5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d723c3b3-dfc8-4a36-b322-854bcdbd63f8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d72885f3-a37c-4ba9-9c70-75cf2e411a91"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d7a186d2-dcf5-4ef5-92f3-fc7c2f2b08e3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d85029f4-b16c-4dd4-8a44-f768cb2eae2c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d8f52509-2cb2-4111-9b57-510f632d5d55"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d9229e25-01fd-47a0-b891-2fd385fb581b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d934b968-b935-4414-a955-6b5afd77c281"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d9707293-9d92-49d1-8570-bb98ef832b4d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d980eea6-5739-4b84-b103-6a55593076ab"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d9a20a30-c5ee-4687-9df5-d840ad97a5b3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("da2356df-fbdf-4c50-80c0-bc47118bb854"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("da6c24b8-4f15-42bb-ac40-20abe82ccb17"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("da85e6f1-a53b-4183-b475-5742d37dc926"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("db0e4f26-2fc3-4261-b345-0f062dc3a1e5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("dba4d6d4-4950-4f74-a0e1-43f5a978c2f8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("dbdf2266-248a-48b4-9e27-97d715c53472"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("dc1f6b03-fa87-41f6-bbe4-588d851af74c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("dc55fe1c-8356-4a68-a013-0477ba996542"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("dc9c291d-965d-4072-becb-65f6efcf1128"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("dcb0bafc-684a-482a-ae8a-dcb5f197caaa"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("de3b3f9a-85c9-4366-959d-ed127fc0aaa4"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("df032ab9-bce9-4769-8514-13722a5b190f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("df2b1a84-829f-47bd-9139-029bff95746d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("df6938bf-c039-4f64-a056-f0900d6da41c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("df7826de-4b30-4519-82db-76be57f170f9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("dfdab141-0386-4e6f-a41d-964289c44f1b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("dffcf564-d6a2-4408-b67f-17656a80c7fd"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e02f87b4-badc-4629-82dd-6b44a360b5b1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e152ef7a-dd09-4630-82c3-748acb516f7a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e1638cf0-5711-4533-bcf3-2c3a0d43ba2e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e21dc632-4231-4cd9-83aa-2ed38aeff6f2"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e241832c-65c1-4182-bcff-9bf3ad410e73"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e263d78c-52d8-4a82-a3c1-020bfdba676c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e2a6df74-436b-4add-b752-6f0526800f34"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e34b1326-f051-4291-a48f-0634435d5770"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e40b4d1a-bff2-4f59-87de-52a1dee238c5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e4f816cd-7423-4692-a8d5-a0a25de354e8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e51c6da9-d976-4550-ac43-74a65a6542f5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e5aca64d-c800-4996-acda-bf987a25e7af"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e5ca2693-284a-47d2-ae08-8637ec50a161"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e654c146-0e73-44ce-9ff2-9827e5a1d35b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e68fcf89-f63b-4d91-b499-2dbefc0f46ab"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e6f92ea8-5ff4-4046-bda8-9e769c6902eb"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e72def9c-c065-46f0-8816-1c89872be31d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e73c1b9e-0ebb-4d30-809e-736875710e9f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e76293ea-ad2d-4375-8d18-e5a59e6d6906"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e76da7a9-6bdc-44b6-87c7-cbed8d50d668"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e7ab10d0-7305-4e3b-924e-da37ed0f3ea4"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e938607d-fcc7-4f8b-ae8c-e60eae7cc8b5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e9496cfe-f477-4caa-a278-edb268ca888b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e9733f25-a566-4bf5-9461-ec3303c26a9e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e9df1d80-edee-4e4e-be52-fb8bbeeb330d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("eac9a326-0bc3-4c0d-83cc-5d277451ae1c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ec691ee7-b335-4f47-b4a8-d8d815d41f64"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ecd49f5f-20d3-4a45-8953-b98fd83a5998"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ed567ef1-6816-45dd-b4e2-074e7afc7a62"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("edc55a47-e31c-49a8-aa64-4397d4b93f87"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("eddbd83f-5090-4262-8b8f-abe37f24b0bf"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ee1e589e-8b5a-44e4-85be-8b8ce1aa8a28"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ee2a51c6-0568-4854-867b-09ffd7c25012"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ef744f4f-3519-4fa1-8c6c-d5397ccd0be3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ef7fe1e7-54fc-4b30-b2b8-5127d23bf38e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ef823f34-204c-4667-8272-f36fbce5f248"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f021aeca-5e8f-4fd1-8ce4-eef4f288bb61"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f0238df9-1dac-4391-8e89-6a4057343a07"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f0f53aba-cd31-4c35-ac95-56d718bc8b5f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f12a9681-4158-4e35-b7ab-10b8dd2f4e5a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f1f538db-01d0-4199-aff6-615a0fcd96cd"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f246f740-d359-4ca1-9507-ed2c876902d4"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f2fe8968-ed37-459a-bf30-25ee94f54367"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f335aaab-c5d2-424c-b94a-d0582e10006b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f36899bc-929e-476e-9b69-5f14ba2ca7c8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f4e5edd8-12af-4064-a374-8cacd25484a9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f543b26a-afb8-4bf2-ba39-e2ddd674c947"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f57b1a79-92d9-4869-977c-72468838cd78"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f684b15d-90d1-4078-8c97-e5bd0408e126"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f8052128-7dbe-43fc-b7d2-7e624b5dc238"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f8c63b36-3965-4a1c-bb80-5919968a19e7"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f94dffdc-4f62-4a39-9620-107e4e938c9f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f9e952a5-fa8f-4f59-9221-497a03b99493"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("fa5c1ebc-054a-49e5-82ec-c1a0de6689ee"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("fa7b7e20-bbc1-4b98-bae4-3185b4a77704"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("fadc78da-564e-456f-8a34-ec57dd43ed72"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("fbfad259-b640-4a66-896a-2ff6b034b2a5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("fc5eeded-eb25-496a-a091-f54b7ba1383e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("fc655f0d-ed3a-4772-9778-cd336fbb2cc1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("fca2d609-3871-4b0f-afda-5e107be2f3eb"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("fdaf4d9f-ce89-4d44-a551-6a345810dbfe"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("fdc0ce3c-fad0-4232-812f-30c295a5944c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("fe90a9aa-9813-4210-82c4-e8e2a1d26946"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("fea090eb-773f-44e8-85c3-a2ead453b6ae"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("febbf035-5443-4def-aa89-bdf3400bd7fd"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ff1b10e2-f718-4159-8a8a-b45aec088906"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ff9a7d73-d8d0-4a80-ae75-dce6088150fe"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("fff88098-f7ab-4491-98bf-6b8fe8d2b6e0"));

            migrationBuilder.AddColumn<Guid>(
                name: "VenueId",
                table: "Events",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Venues",
                columns: table => new
                {
                    VenueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatsAvailable = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venues", x => x.VenueId);
                });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                columns: new[] { "Date", "VenueId" },
                values: new object[] { new DateTime(2026, 5, 23, 16, 41, 23, 395, DateTimeKind.Local).AddTicks(9534), new Guid("11111111-1111-1111-1111-111111111112") });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                columns: new[] { "Date", "VenueId" },
                values: new object[] { new DateTime(2025, 12, 23, 16, 41, 23, 395, DateTimeKind.Local).AddTicks(9592), new Guid("11111111-1111-1111-1111-111111111114") });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                columns: new[] { "Date", "VenueId" },
                values: new object[] { new DateTime(2026, 4, 23, 16, 41, 23, 395, DateTimeKind.Local).AddTicks(9621), new Guid("11111111-1111-1111-1111-111111111115") });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                columns: new[] { "Date", "VenueId" },
                values: new object[] { new DateTime(2025, 12, 23, 16, 41, 23, 395, DateTimeKind.Local).AddTicks(9564), new Guid("11111111-1111-1111-1111-111111111113") });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                columns: new[] { "Date", "VenueId" },
                values: new object[] { new DateTime(2026, 2, 23, 16, 41, 23, 395, DateTimeKind.Local).AddTicks(9404), new Guid("11111111-1111-1111-1111-111111111111") });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Artist", "Date", "Description", "ImageUrl", "IsOnSpecialOffer", "Name", "OriginalPrice", "Price", "VenueId" },
                values: new object[,]
                {
                    { new Guid("04713fca-7c28-4106-9167-f99fabeafb0c"), "Anne-Marie", new DateTime(2026, 7, 16, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(2534), "The electrifying Anne-Marie brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Anne-Marie: Acoustic Night", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111210") },
                    { new Guid("04c70f9e-c00f-4ca6-a7e6-f8f7ed5ade62"), "Luke Combs & Drake", new DateTime(2029, 10, 4, 16, 41, 23, 405, DateTimeKind.Local).AddTicks(1238), "Experience the magic of Luke Combs & Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Luke Combs & Drake: Farewell Tour", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111202") },
                    { new Guid("051d5ce2-3f7a-4c26-b6a9-52e3e30d0c64"), "Nicki Minaj & Beyoncé", new DateTime(2028, 2, 18, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(9342), "Nicki Minaj & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Nicki Minaj & Beyoncé: The Sessions", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111204") },
                    { new Guid("06a6162d-b0ed-41d3-acad-9766a5872dce"), "Tiësto & Beyoncé", new DateTime(2028, 2, 9, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(9157), "An unforgettable night with Tiësto & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Tiësto & Beyoncé: Summer Festival", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111201") },
                    { new Guid("078f9972-c8aa-4e6e-8172-4ec50cdd551d"), "Troye Sivan & Ed Sheeran", new DateTime(2027, 4, 30, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(5247), "An unforgettable night with Troye Sivan & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Troye Sivan & Ed Sheeran: World Tour", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111206") },
                    { new Guid("0d6d839d-7dbe-47cb-b8f5-1888fb94e775"), "Alan Walker & BTS", new DateTime(2028, 12, 14, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(8187), "Alan Walker & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Alan Walker & BTS: Greatest Hits Tour", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111204") },
                    { new Guid("15bbeb71-8810-4eb4-b0b9-e0b1117fce8a"), "Lil Uzi Vert & BTS", new DateTime(2028, 12, 26, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(9067), "Join Lil Uzi Vert & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Lil Uzi Vert & BTS: Live at Home", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111208") },
                    { new Guid("18a425d2-a6f1-485a-a8ff-796cef559a95"), "Anitta & Ed Sheeran", new DateTime(2027, 4, 27, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(4825), "The electrifying Anitta & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Anitta & Ed Sheeran: Legends Tour", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111205") },
                    { new Guid("226ab9f8-3f36-4033-9239-1b8de2caf0d2"), "G-Eazy & Ed Sheeran", new DateTime(2027, 5, 6, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(7018), "Join G-Eazy & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "G-Eazy & Ed Sheeran: Reunion Tour", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111208") },
                    { new Guid("260c0324-274a-40e3-90ab-c96171690d13"), "Maluma & Drake", new DateTime(2029, 10, 19, 16, 41, 23, 405, DateTimeKind.Local).AddTicks(1917), "Experience the magic of Maluma & Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Maluma & Drake: Live in Concert", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111207") },
                    { new Guid("3289175f-2a4f-477e-95c6-b7e81377d071"), "Tame Impala & Drake", new DateTime(2029, 10, 16, 16, 41, 23, 405, DateTimeKind.Local).AddTicks(1883), "An unforgettable night with Tame Impala & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Tame Impala & Drake: World Tour", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111206") },
                    { new Guid("36405785-e8d8-4c95-97fb-4c40089745b6"), "Avicii", new DateTime(2026, 6, 28, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(2128), "Avicii returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Avicii: Greatest Hits Tour", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111204") },
                    { new Guid("3a94ae2b-f03e-430b-91ba-99549cf1d061"), "Jack Harlow & Drake", new DateTime(2029, 10, 13, 16, 41, 23, 405, DateTimeKind.Local).AddTicks(1803), "The electrifying Jack Harlow & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Jack Harlow & Drake: Legends Tour", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111205") },
                    { new Guid("3de89521-af06-4b1a-b703-67ef771ff736"), "Nicky Jam & Ed Sheeran", new DateTime(2027, 4, 24, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(4575), "Nicky Jam & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Nicky Jam & Ed Sheeran: Anniversary Tour", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111204") },
                    { new Guid("41057844-82e5-4b31-9279-2203a5367bce"), "Rosalía & Drake", new DateTime(2029, 10, 22, 16, 41, 23, 405, DateTimeKind.Local).AddTicks(1954), "Join Rosalía & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Rosalía & Drake: Reunion Tour", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111208") },
                    { new Guid("4c10af3b-c82e-4ba7-ad7c-7316b009c1ee"), "Dan + Shay", new DateTime(2026, 6, 19, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(1485), "An unforgettable night with Dan + Shay showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Dan + Shay: World Tour", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111201") },
                    { new Guid("5106c3c7-fb59-437f-aad9-4c158b773b1f"), "Dan + Shay & Ed Sheeran", new DateTime(2027, 5, 9, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(7207), "Dan + Shay & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Dan + Shay & Ed Sheeran: Greatest Hits Tour", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111209") },
                    { new Guid("56f34e9d-b4a1-4606-b9ba-17b539910a5d"), "Tyler, The Creator & Beyoncé", new DateTime(2028, 3, 7, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(859), "The electrifying Tyler, The Creator & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Tyler, The Creator & Beyoncé: Legends Tour", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111210") },
                    { new Guid("69f5dfd0-5cc1-4324-b930-a739fba7a226"), "Zara Larsson & BTS", new DateTime(2028, 12, 20, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(8635), "An unforgettable night with Zara Larsson & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Zara Larsson & BTS: Summer Festival", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111206") },
                    { new Guid("7371caae-af01-46cc-a43c-73d8dd1d2bb8"), "Alicia Keys & BTS", new DateTime(2029, 1, 1, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(9414), "The electrifying Alicia Keys & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Alicia Keys & BTS: Acoustic Night", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111210") },
                    { new Guid("73759084-c0a1-4953-a3a1-4f6ff592631e"), "Glass Animals & BTS", new DateTime(2028, 12, 8, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(8009), "Experience the magic of Glass Animals & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Glass Animals & BTS: Live in Concert", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111202") },
                    { new Guid("7bdd5ab9-d272-4f39-94a6-8dfd681e18c4"), "Bastille & Ed Sheeran", new DateTime(2027, 4, 21, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(4526), "Join Bastille & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Bastille & Ed Sheeran: Comeback Tour", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111203") },
                    { new Guid("7dc8e8e8-ddc9-4f57-ba8b-fbde2ff8095d"), "Kehlani & Beyoncé", new DateTime(2028, 2, 27, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(9442), "Experience the magic of Kehlani & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Kehlani & Beyoncé: Farewell Tour", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111207") },
                    { new Guid("7e8c7984-1e93-4435-8297-a9ab6ba6a44a"), "Mabel & Ed Sheeran", new DateTime(2027, 5, 3, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(5366), "Experience the magic of Mabel & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Mabel & Ed Sheeran: Live in Concert", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111207") },
                    { new Guid("7f6116f9-969d-4916-9080-a984cc092abd"), "Alicia Keys & Beyoncé", new DateTime(2028, 2, 12, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(9265), "Experience the magic of Alicia Keys & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Alicia Keys & Beyoncé: Unplugged", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111202") },
                    { new Guid("84eb6dd1-8c45-4212-9416-035998a75408"), "Jason Derulo", new DateTime(2026, 7, 10, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(2460), "Join Jason Derulo for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Jason Derulo: Live at Home", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111208") },
                    { new Guid("8984296d-1003-4485-a7bb-181c2a854f0a"), "Machine Gun Kelly & Beyoncé", new DateTime(2028, 3, 1, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(687), "Join Machine Gun Kelly & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Machine Gun Kelly & Beyoncé: Comeback Tour", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111208") },
                    { new Guid("8c42925d-a73b-4288-a411-d04cf258bafc"), "SEVENTEEN", new DateTime(2026, 7, 4, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(2226), "An unforgettable night with SEVENTEEN showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "SEVENTEEN: Summer Festival", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111206") },
                    { new Guid("8e86bc83-125a-45a9-bb0b-cb6ce97cb6b9"), "Tones and I & Drake", new DateTime(2029, 10, 25, 16, 41, 23, 405, DateTimeKind.Local).AddTicks(1984), "Tones and I & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Tones and I & Drake: Greatest Hits Tour", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111209") },
                    { new Guid("901f8015-e9d3-4089-bb8c-57dd9f4550ef"), "Meghan Trainor", new DateTime(2026, 6, 22, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(1519), "Experience the magic of Meghan Trainor in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Meghan Trainor: Live in Concert", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111202") },
                    { new Guid("975d55df-3934-434c-b35a-6194200b970e"), "Fall Out Boy", new DateTime(2026, 7, 1, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(2184), "The electrifying Fall Out Boy brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Fall Out Boy: The Experience", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111205") },
                    { new Guid("988f596a-052d-461f-80ba-a0dabf9f40bc"), "KAROL G & BTS", new DateTime(2028, 12, 23, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(8951), "Experience the magic of KAROL G & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "KAROL G & BTS: Unplugged", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111207") },
                    { new Guid("99680a65-72d1-4817-9601-f85d531dc07c"), "Little Mix & Beyoncé", new DateTime(2028, 2, 21, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(9376), "The electrifying Little Mix & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Little Mix & Beyoncé: Acoustic Night", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111205") },
                    { new Guid("a043c6f2-83ca-45ae-9b72-f24e06d2e670"), "Panic! At The Disco & Beyoncé", new DateTime(2028, 3, 4, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(821), "Panic! At The Disco & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Panic! At The Disco & Beyoncé: Anniversary Tour", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111209") },
                    { new Guid("a11f9ab3-f274-484c-a263-c39632b6a4a4"), "Tyler, The Creator & Ed Sheeran", new DateTime(2027, 4, 18, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(4359), "Experience the magic of Tyler, The Creator & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Tyler, The Creator & Ed Sheeran: Farewell Tour", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111202") },
                    { new Guid("a3a1f725-f84d-4536-abb0-ae63f2d080d4"), "DaBaby & Drake", new DateTime(2029, 10, 7, 16, 41, 23, 405, DateTimeKind.Local).AddTicks(1393), "Join DaBaby & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "DaBaby & Drake: Comeback Tour", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111203") },
                    { new Guid("a54d2954-5bb1-408d-9efc-ec77fcaa5d3f"), "OneRepublic & BTS", new DateTime(2028, 12, 17, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(8330), "The electrifying OneRepublic & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "OneRepublic & BTS: The Experience", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111205") },
                    { new Guid("a5f2e723-3c2b-4602-94b3-605594ee3a45"), "Panic! At The Disco & Ed Sheeran", new DateTime(2027, 4, 15, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(3925), "An unforgettable night with Panic! At The Disco & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Panic! At The Disco & Ed Sheeran: Stadium Tour", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111201") },
                    { new Guid("a8288144-1aa0-4c61-b3c1-e75d6b158ba9"), "Robin Schulz", new DateTime(2026, 7, 7, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(2358), "Experience the magic of Robin Schulz in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Robin Schulz: Unplugged", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111207") },
                    { new Guid("add9b6c8-ef50-4666-9f67-7af099ec5f18"), "Demi Lovato & BTS", new DateTime(2028, 12, 11, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(8041), "Join Demi Lovato & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Demi Lovato & BTS: Reunion Tour", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111203") },
                    { new Guid("b307c1f8-f8ed-46ed-95e9-7e44193b370a"), "Tiësto & BTS", new DateTime(2028, 12, 29, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(9103), "Tiësto & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Tiësto & BTS: The Sessions", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111209") },
                    { new Guid("b89f96b2-011d-4303-986f-c013fbb3851c"), "Ava Max & Drake", new DateTime(2029, 10, 1, 16, 41, 23, 405, DateTimeKind.Local).AddTicks(470), "An unforgettable night with Ava Max & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Ava Max & Drake: Stadium Tour", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111201") },
                    { new Guid("b8b06512-b9f4-4cab-9a23-b727d90bffa2"), "Glass Animals & Drake", new DateTime(2029, 10, 28, 16, 41, 23, 405, DateTimeKind.Local).AddTicks(2016), "The electrifying Glass Animals & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Glass Animals & Drake: The Experience", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111210") },
                    { new Guid("c1f4d07b-1f73-4a03-96d9-e3118e4ec834"), "Lil Baby & Drake", new DateTime(2029, 10, 10, 16, 41, 23, 405, DateTimeKind.Local).AddTicks(1498), "Lil Baby & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Lil Baby & Drake: Anniversary Tour", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111204") },
                    { new Guid("c700f49d-2ab1-4a8d-82b7-bf6c4e0cbd7b"), "NCT 127", new DateTime(2026, 6, 25, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(2000), "Join NCT 127 for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "NCT 127: Reunion Tour", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111203") },
                    { new Guid("c95b94f8-24a8-485d-8a42-12823eabf471"), "Tones and I & BTS", new DateTime(2028, 12, 5, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7943), "An unforgettable night with Tones and I & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Tones and I & BTS: World Tour", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111201") },
                    { new Guid("ce9fbd87-5d41-430a-a601-90b90878f0a0"), "5 Seconds of Summer & Beyoncé", new DateTime(2028, 2, 15, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(9306), "Join 5 Seconds of Summer & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "5 Seconds of Summer & Beyoncé: Live at Home", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111203") },
                    { new Guid("e90f18b6-5ffc-4f83-ae68-64741f7ff690"), "Offset", new DateTime(2026, 7, 13, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(2502), "Offset returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Offset: The Sessions", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111209") },
                    { new Guid("eab73bd6-6a65-4452-8d55-753144f7cee1"), "Meghan Trainor & Ed Sheeran", new DateTime(2027, 5, 12, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(7261), "The electrifying Meghan Trainor & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Meghan Trainor & Ed Sheeran: The Experience", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111210") },
                    { new Guid("efc4751a-5670-49a9-ade6-430465899677"), "YUNGBLUD & Beyoncé", new DateTime(2028, 2, 24, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(9409), "An unforgettable night with YUNGBLUD & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "YUNGBLUD & Beyoncé: Stadium Tour", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111206") }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "VenueId", "Address", "City", "Name", "SeatsAvailable", "State", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "4 Pennsylvania Plaza", "New York", "Madison Square Garden", 20000, "NY", "10001" },
                    { new Guid("11111111-1111-1111-1111-111111111112"), "1111 S Figueroa St", "Los Angeles", "Staples Center", 21000, "CA", "90015" },
                    { new Guid("11111111-1111-1111-1111-111111111113"), "1901 W Madison St", "Chicago", "United Center", 23500, "IL", "60612" },
                    { new Guid("11111111-1111-1111-1111-111111111114"), "100 Legends Way", "Boston", "TD Garden", 19580, "MA", "02114" },
                    { new Guid("11111111-1111-1111-1111-111111111115"), "601 Biscayne Blvd", "Miami", "American Airlines Arena", 19600, "FL", "33132" },
                    { new Guid("11111111-1111-1111-1111-111111111116"), "1260 6th Ave", "New York", "Radio City Music Hall", 6015, "NY", "10020" },
                    { new Guid("11111111-1111-1111-1111-111111111117"), "2301 N Highland Ave", "Los Angeles", "Hollywood Bowl", 17500, "CA", "90068" },
                    { new Guid("11111111-1111-1111-1111-111111111118"), "18300 W Alameda Pkwy", "Morrison", "Red Rocks Amphitheatre", 9525, "CO", "80465" },
                    { new Guid("11111111-1111-1111-1111-111111111119"), "2700 N Vermont Ave", "Los Angeles", "The Greek Theatre", 5900, "CA", "90027" },
                    { new Guid("11111111-1111-1111-1111-111111111120"), "881 7th Ave", "New York", "Carnegie Hall", 2804, "NY", "10019" },
                    { new Guid("11111111-1111-1111-1111-111111111121"), "329 N Dearborn St", "Chicago", "House of Blues Chicago", 1800, "IL", "60654" },
                    { new Guid("11111111-1111-1111-1111-111111111122"), "1805 Geary Blvd", "San Francisco", "The Fillmore", 1150, "CA", "94115" },
                    { new Guid("11111111-1111-1111-1111-111111111123"), "116 5th Ave N", "Nashville", "The Ryman Auditorium", 2362, "TN", "37219" },
                    { new Guid("11111111-1111-1111-1111-111111111124"), "253 W 125th St", "New York", "The Apollo Theater", 1506, "NY", "10027" },
                    { new Guid("11111111-1111-1111-1111-111111111125"), "2124 Broadway", "New York", "The Beacon Theatre", 2894, "NY", "10023" },
                    { new Guid("11111111-1111-1111-1111-111111111126"), "1 MetLife Stadium Dr", "East Rutherford", "MetLife Stadium", 82500, "NJ", "07073" },
                    { new Guid("11111111-1111-1111-1111-111111111127"), "1 AT&T Way", "Arlington", "AT&T Stadium", 80000, "TX", "76011" },
                    { new Guid("11111111-1111-1111-1111-111111111128"), "1 AMB Dr NW", "Atlanta", "Mercedes-Benz Stadium", 71000, "GA", "30313" },
                    { new Guid("11111111-1111-1111-1111-111111111129"), "1410 Museum Campus Dr", "Chicago", "Soldier Field", 61500, "IL", "60605" },
                    { new Guid("11111111-1111-1111-1111-111111111130"), "1001 Rose Bowl Dr", "Pasadena", "Rose Bowl", 88565, "CA", "91103" },
                    { new Guid("11111111-1111-1111-1111-111111111131"), "9081 Santa Monica Blvd", "West Hollywood", "The Troubadour", 400, "CA", "90069" },
                    { new Guid("11111111-1111-1111-1111-111111111132"), "815 V St NW", "Washington", "9:30 Club", 1200, "DC", "20001" },
                    { new Guid("11111111-1111-1111-1111-111111111133"), "701 1st Ave N", "Minneapolis", "First Avenue", 1550, "MN", "55403" },
                    { new Guid("11111111-1111-1111-1111-111111111134"), "152 Luckie St NW", "Atlanta", "The Tabernacle", 2600, "GA", "30303" },
                    { new Guid("11111111-1111-1111-1111-111111111135"), "982 Market St", "San Francisco", "The Warfield", 2300, "CA", "94102" },
                    { new Guid("11111111-1111-1111-1111-111111111136"), "1000 Chopper Cir", "Denver", "Pepsi Center", 20000, "CO", "80204" },
                    { new Guid("11111111-1111-1111-1111-111111111137"), "305 Harrison St", "Seattle", "KeyArena", 17072, "WA", "98109" },
                    { new Guid("11111111-1111-1111-1111-111111111138"), "7000 Coliseum Way", "Oakland", "Oracle Arena", 19596, "CA", "94621" },
                    { new Guid("11111111-1111-1111-1111-111111111139"), "2500 Victory Ave", "Dallas", "AmericanAirlines Center", 20000, "TX", "75219" },
                    { new Guid("11111111-1111-1111-1111-111111111140"), "2645 Woodward Ave", "Detroit", "Little Caesars Arena", 20332, "MI", "48201" },
                    { new Guid("11111111-1111-1111-1111-111111111141"), "1 Amphitheatre Pkwy", "Mountain View", "Shoreline Amphitheatre", 22500, "CA", "94043" },
                    { new Guid("11111111-1111-1111-1111-111111111142"), "1000 Ocean Pkwy", "Wantagh", "Jones Beach Theater", 15000, "NY", "11793" },
                    { new Guid("11111111-1111-1111-1111-111111111143"), "707 Pavilion Blvd", "Charlotte", "PNC Music Pavilion", 20000, "NC", "28217" },
                    { new Guid("11111111-1111-1111-1111-111111111144"), "2005 Lake Robbins Dr", "The Woodlands", "Cynthia Woods Mitchell Pavilion", 16500, "TX", "77380" },
                    { new Guid("11111111-1111-1111-1111-111111111145"), "6295 Kellogg Ave", "Cincinnati", "Riverbend Music Center", 20500, "OH", "45230" },
                    { new Guid("11111111-1111-1111-1111-111111111146"), "2804 Opryland Dr", "Nashville", "Grand Ole Opry", 4372, "TN", "37214" },
                    { new Guid("11111111-1111-1111-1111-111111111147"), "175 N State St", "Chicago", "The Chicago Theatre", 3600, "IL", "60601" },
                    { new Guid("11111111-1111-1111-1111-111111111148"), "660 Peachtree St NE", "Atlanta", "Fox Theatre Atlanta", 4665, "GA", "30308" },
                    { new Guid("11111111-1111-1111-1111-111111111149"), "203 S Main St", "Memphis", "The Orpheum Theatre", 2308, "TN", "38103" },
                    { new Guid("11111111-1111-1111-1111-111111111150"), "1564 Broadway", "New York", "Palace Theatre", 1743, "NY", "10036" },
                    { new Guid("11111111-1111-1111-1111-111111111151"), "3790 Wilshire Blvd", "Los Angeles", "The Wiltern", 1850, "CA", "90010" },
                    { new Guid("11111111-1111-1111-1111-111111111152"), "610 W 56th St", "New York", "Terminal 5", 3000, "NY", "10019" },
                    { new Guid("11111111-1111-1111-1111-111111111153"), "901 Wharf St SW", "Washington", "The Anthem", 6000, "DC", "20024" },
                    { new Guid("11111111-1111-1111-1111-111111111154"), "3950 Las Vegas Blvd S", "Las Vegas", "House of Blues Las Vegas", 1800, "NV", "89119" },
                    { new Guid("11111111-1111-1111-1111-111111111155"), "1111 California St", "San Francisco", "The Masonic", 3200, "CA", "94108" },
                    { new Guid("11111111-1111-1111-1111-111111111156"), "81800 51st Ave", "Indio", "Coachella Valley Music Festival", 99000, "CA", "92201" },
                    { new Guid("11111111-1111-1111-1111-111111111157"), "4365 Bushy Branch Rd", "Manchester", "Bonnaroo Music Festival", 80000, "TN", "37355" },
                    { new Guid("11111111-1111-1111-1111-111111111158"), "337 E Randolph St", "Chicago", "Lollapalooza Grant Park", 100000, "IL", "60601" },
                    { new Guid("11111111-1111-1111-1111-111111111159"), "2100 Barton Springs Rd", "Austin", "Austin City Limits Festival", 75000, "TX", "78746" },
                    { new Guid("11111111-1111-1111-1111-111111111160"), "7000 Las Vegas Blvd N", "Las Vegas", "Electric Daisy Carnival", 400000, "NV", "89115" },
                    { new Guid("11111111-1111-1111-1111-111111111161"), "2661 State St", "Santa Ana", "The Observatory", 1500, "CA", "92706" },
                    { new Guid("11111111-1111-1111-1111-111111111162"), "2401 W Wisconsin Ave", "Milwaukee", "The Rave", 2500, "WI", "53233" },
                    { new Guid("11111111-1111-1111-1111-111111111163"), "708 E Broad St", "Richmond", "The National", 1500, "VA", "23219" },
                    { new Guid("11111111-1111-1111-1111-111111111164"), "2 S Palafox St", "Pensacola", "Vinyl Music Hall", 2000, "FL", "32502" },
                    { new Guid("11111111-1111-1111-1111-111111111165"), "101 Biltmore Ave", "Asheville", "The Orange Peel", 1050, "NC", "28801" },
                    { new Guid("11111111-1111-1111-1111-111111111166"), "8852 Sunset Blvd", "West Hollywood", "The Viper Room", 250, "CA", "90069" },
                    { new Guid("11111111-1111-1111-1111-111111111167"), "6 Delancey St", "New York", "The Bowery Ballroom", 575, "NY", "10002" },
                    { new Guid("11111111-1111-1111-1111-111111111168"), "217 E Houston St", "New York", "The Mercury Lounge", 250, "NY", "10002" },
                    { new Guid("11111111-1111-1111-1111-111111111169"), "2200 2nd Ave", "Seattle", "The Crocodile", 400, "WA", "98121" },
                    { new Guid("11111111-1111-1111-1111-111111111170"), "2130 N Cahuenga Blvd", "Los Angeles", "The Garage", 600, "CA", "90068" },
                    { new Guid("11111111-1111-1111-1111-111111111171"), "830 5th Ave", "New York", "Central Park SummerStage", 5000, "NY", "10065" },
                    { new Guid("11111111-1111-1111-1111-111111111172"), "201 E Randolph St", "Chicago", "Millennium Park", 11000, "IL", "60602" },
                    { new Guid("11111111-1111-1111-1111-111111111173"), "West 57th St & 12th Ave", "New York", "Pier 97 at Hudson River Park", 5000, "NY", "10019" },
                    { new Guid("11111111-1111-1111-1111-111111111174"), "2126 SW Halsey St", "Troutdale", "Edgefield", 4000, "OR", "97060" },
                    { new Guid("11111111-1111-1111-1111-111111111175"), "500 S McDowell St", "Raleigh", "Red Hat Amphitheater", 5500, "NC", "27601" },
                    { new Guid("11111111-1111-1111-1111-111111111176"), "1 N Center Ct St", "Portland", "Moda Center", 19980, "OR", "97227" },
                    { new Guid("11111111-1111-1111-1111-111111111177"), "301 W South Temple", "Salt Lake City", "Vivint Smart Home Arena", 18306, "UT", "84101" },
                    { new Guid("11111111-1111-1111-1111-111111111178"), "201 E Jefferson St", "Phoenix", "Talking Stick Resort Arena", 18422, "AZ", "85004" },
                    { new Guid("11111111-1111-1111-1111-111111111179"), "600 1st Ave N", "Minneapolis", "Target Center", 19356, "MN", "55403" },
                    { new Guid("11111111-1111-1111-1111-111111111180"), "3780 Las Vegas Blvd S", "Las Vegas", "T-Mobile Arena", 20000, "NV", "89158" },
                    { new Guid("11111111-1111-1111-1111-111111111181"), "1332 W Burnside St", "Portland", "The Crystal Ballroom", 1500, "OR", "97209" },
                    { new Guid("11111111-1111-1111-1111-111111111182"), "3730 N Clark St", "Chicago", "The Metro", 1100, "IL", "60613" },
                    { new Guid("11111111-1111-1111-1111-111111111183"), "1426 1st Ave", "Seattle", "The Showbox", 1200, "WA", "98101" },
                    { new Guid("11111111-1111-1111-1111-111111111184"), "935 E Colfax Ave", "Denver", "The Ogden Theatre", 1600, "CO", "80218" },
                    { new Guid("11111111-1111-1111-1111-111111111185"), "6161 Delmar Blvd", "St. Louis", "The Pageant", 2300, "MO", "63112" },
                    { new Guid("11111111-1111-1111-1111-111111111186"), "131 W 3rd St", "New York", "The Blue Note", 300, "NY", "10012" },
                    { new Guid("11111111-1111-1111-1111-111111111187"), "917 Woodland St", "Nashville", "The Basement East", 500, "TN", "37206" },
                    { new Guid("11111111-1111-1111-1111-111111111188"), "305 E 5th St", "Austin", "Antone's", 800, "TX", "78701" },
                    { new Guid("11111111-1111-1111-1111-111111111189"), "1003 Arch St", "Philadelphia", "The Trocadero", 1200, "PA", "19107" },
                    { new Guid("11111111-1111-1111-1111-111111111190"), "967 Commonwealth Ave", "Boston", "The Paradise Rock Club", 933, "MA", "02215" },
                    { new Guid("11111111-1111-1111-1111-111111111191"), "3601 S Broad St", "Philadelphia", "Wells Fargo Center", 21000, "PA", "19148" },
                    { new Guid("11111111-1111-1111-1111-111111111192"), "400 W Church St", "Orlando", "Amway Center", 18846, "FL", "32801" },
                    { new Guid("11111111-1111-1111-1111-111111111193"), "25 Lafayette St", "Newark", "Prudential Center", 17625, "NJ", "07102" },
                    { new Guid("11111111-1111-1111-1111-111111111194"), "1501 Dave Dixon Dr", "New Orleans", "Smoothie King Center", 16867, "LA", "70113" },
                    { new Guid("11111111-1111-1111-1111-111111111195"), "40 Bay St", "Toronto", "Scotiabank Arena", 19800, "ON", "M5J 2X2" },
                    { new Guid("11111111-1111-1111-1111-111111111196"), "1 Seymour H Knox III Plaza", "Buffalo", "KeyBank Center", 19070, "NY", "14203" },
                    { new Guid("11111111-1111-1111-1111-111111111197"), "1401 Clark Ave", "St. Louis", "Enterprise Center", 19150, "MO", "63103" },
                    { new Guid("11111111-1111-1111-1111-111111111198"), "191 Beale St", "Memphis", "FedExForum", 18119, "TN", "38103" },
                    { new Guid("11111111-1111-1111-1111-111111111199"), "9400 W Maryland Ave", "Glendale", "Gila River Arena", 17125, "AZ", "85305" },
                    { new Guid("11111111-1111-1111-1111-111111111200"), "200 S Denver Ave", "Tulsa", "BOK Center", 19199, "OK", "74103" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Artist", "Date", "Description", "ImageUrl", "IsOnSpecialOffer", "Name", "OriginalPrice", "Price", "VenueId" },
                values: new object[,]
                {
                    { new Guid("0028174e-6305-46f6-b173-a2d95b4ccaf0"), "Selena Gomez & BTS", new DateTime(2028, 9, 24, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7117), "Experience the magic of Selena Gomez & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Selena Gomez & BTS: Unplugged", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111177") },
                    { new Guid("00ad5387-e123-405f-b24d-3114a2fa30df"), "Katy Perry", new DateTime(2025, 11, 18, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(2322), "The electrifying Katy Perry brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Katy Perry: The Experience", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111130") },
                    { new Guid("0159656d-f1cd-4099-8b55-b4189273ea35"), "The Chainsmokers", new DateTime(2026, 1, 2, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(6165), "The electrifying The Chainsmokers brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "The Chainsmokers: The Experience", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111145") },
                    { new Guid("015f3a6c-d669-4f56-916f-0365301616d0"), "Lil Nas X & Beyoncé", new DateTime(2027, 10, 9, 16, 41, 23, 401, DateTimeKind.Local).AddTicks(8805), "The electrifying Lil Nas X & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Lil Nas X & Beyoncé: Acoustic Night", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111160") },
                    { new Guid("022904de-ee8b-4ae1-b537-f8e889f6db54"), "NCT 127 & BTS", new DateTime(2029, 2, 21, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(3308), "Experience the magic of NCT 127 & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "NCT 127 & BTS: Farewell Tour", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111127") },
                    { new Guid("022da06f-6fc9-4189-bdbc-a6759140f3ce"), "Lil Baby & Beyoncé", new DateTime(2028, 1, 1, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(7777), "Join Lil Baby & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Lil Baby & Beyoncé: Live at Home", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111188") },
                    { new Guid("03b3bba4-5aa2-4c08-8842-2c5870bcbb0c"), "Taylor Swift & Drake", new DateTime(2029, 4, 10, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(3920), "Join Taylor Swift & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Taylor Swift & Drake: Comeback Tour", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111143") },
                    { new Guid("03c893ba-c32e-4921-9558-3c599b80027a"), "LISA", new DateTime(2026, 8, 6, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(3271), "Experience the magic of LISA in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "LISA: Live in Concert", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111117") },
                    { new Guid("03cc5eae-c6c2-450b-897f-c703d18ae7c9"), "Dua Lipa & Ed Sheeran", new DateTime(2026, 9, 23, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(4648), "Join Dua Lipa & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Dua Lipa & Ed Sheeran: Reunion Tour", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111133") },
                    { new Guid("05472854-24e9-4310-9000-6291e336a3fa"), "J Balvin", new DateTime(2025, 11, 21, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(2369), "An unforgettable night with J Balvin showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "J Balvin: Summer Festival", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111131") },
                    { new Guid("05f90115-23ae-4165-aa5e-896e600c42e9"), "Shawn Mendes & Drake", new DateTime(2029, 6, 24, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(5646), "Join Shawn Mendes & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Shawn Mendes & Drake: Live at Home", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111168") },
                    { new Guid("06c22707-23a0-4855-bd80-763a18925ede"), "SZA & Ed Sheeran", new DateTime(2026, 11, 28, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(8432), "The electrifying SZA & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "SZA & Ed Sheeran: Acoustic Night", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111155") },
                    { new Guid("06c9d072-0153-4181-a1ce-a6c1f06a81e5"), "Kendrick Lamar & Beyoncé", new DateTime(2027, 8, 16, 16, 41, 23, 400, DateTimeKind.Local).AddTicks(9996), "Experience the magic of Kendrick Lamar & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Kendrick Lamar & Beyoncé: Unplugged", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111142") },
                    { new Guid("07303f77-a5b4-4191-ad75-517f867cb744"), "The Chainsmokers & BTS", new DateTime(2028, 8, 31, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(6077), "The Chainsmokers & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "The Chainsmokers & BTS: Anniversary Tour", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111169") },
                    { new Guid("094cf581-69a2-4e9c-8371-dda33e0feacf"), "BTS", new DateTime(2025, 10, 1, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(55), "BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "BTS: Greatest Hits Tour", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111114") },
                    { new Guid("09d4f4ba-353c-40ef-b680-328e2af6b99f"), "Billie Eilish & Beyoncé", new DateTime(2027, 7, 23, 16, 41, 23, 400, DateTimeKind.Local).AddTicks(9122), "Billie Eilish & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Billie Eilish & Beyoncé: Anniversary Tour", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111134") },
                    { new Guid("0ab355f7-95f8-4586-9d7d-13fb6be76419"), "Tones and I", new DateTime(2026, 4, 8, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8991), "Experience the magic of Tones and I in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Tones and I: Unplugged", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111177") },
                    { new Guid("0b217949-cd17-4141-94a5-23434c5acc28"), "Lewis Capaldi & Drake", new DateTime(2029, 7, 12, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(7136), "Lewis Capaldi & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Lewis Capaldi & Drake: Anniversary Tour", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111174") },
                    { new Guid("0b69d81c-bc41-4fa6-a57c-8801f5cebe25"), "Eminem", new DateTime(2025, 11, 30, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(3400), "Eminem returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Eminem: The Sessions", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111134") },
                    { new Guid("0b76b04f-213b-4764-9f42-a238afa31837"), "Niall Horan & Drake", new DateTime(2029, 9, 28, 16, 41, 23, 405, DateTimeKind.Local).AddTicks(426), "The electrifying Niall Horan & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Niall Horan & Drake: Acoustic Night", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111200") },
                    { new Guid("0beb5562-ef5c-43ac-8b22-ba9975de96fe"), "Selena Gomez & Drake", new DateTime(2029, 8, 14, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(9105), "The electrifying Selena Gomez & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Selena Gomez & Drake: Acoustic Night", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111185") },
                    { new Guid("0c0f9c53-8b38-4032-8a8f-c3f485f17751"), "Beyoncé & Drake", new DateTime(2029, 4, 16, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(3992), "The electrifying Beyoncé & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Beyoncé & Drake: Legends Tour", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111145") },
                    { new Guid("0f4db768-af85-441a-9d2e-2d04b0ea4d8a"), "Juice WRLD & Drake", new DateTime(2029, 8, 29, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(9409), "The electrifying Juice WRLD & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Juice WRLD & Drake: Legends Tour", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111190") },
                    { new Guid("0f5a5cc8-dc1e-4240-9773-49eed96a205d"), "Lizzo", new DateTime(2026, 1, 14, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(6635), "Lizzo returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Lizzo: The Sessions", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111149") },
                    { new Guid("0f607a40-89cc-4d52-8d5e-f30e76c72468"), "Bastille & Beyoncé", new DateTime(2028, 3, 10, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(932), "An unforgettable night with Bastille & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Bastille & Beyoncé: World Tour", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("0fa65934-349d-49de-82af-42208fc1a4c2"), "Tiësto & Ed Sheeran", new DateTime(2027, 3, 22, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(1801), "Join Tiësto & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Tiësto & Ed Sheeran: Reunion Tour", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111193") },
                    { new Guid("11f57d27-274f-4ec8-90b5-4fa0e15254ba"), "Adele & Ed Sheeran", new DateTime(2026, 8, 27, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(4020), "Adele & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Adele & Ed Sheeran: The Sessions", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111124") },
                    { new Guid("12172636-2ff3-4a5e-a69b-923a3806da64"), "5 Seconds of Summer & Ed Sheeran", new DateTime(2027, 3, 28, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(2159), "The electrifying 5 Seconds of Summer & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "5 Seconds of Summer & Ed Sheeran: The Experience", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111195") },
                    { new Guid("12f00315-797d-4b49-9479-bd51b489ad2c"), "Bruno Mars & Drake", new DateTime(2029, 5, 19, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(4375), "An unforgettable night with Bruno Mars & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Bruno Mars & Drake: Stadium Tour", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111156") },
                    { new Guid("131eb2da-231e-437b-a376-ce2504186768"), "YUNGBLUD", new DateTime(2026, 5, 17, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(9478), "The electrifying YUNGBLUD brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "YUNGBLUD: The Experience", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111190") },
                    { new Guid("143fe96a-035f-4b11-8c91-bfc89ecfbbd7"), "Niall Horan & Ed Sheeran", new DateTime(2027, 1, 30, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(951), "An unforgettable night with Niall Horan & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Niall Horan & Ed Sheeran: World Tour", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111176") },
                    { new Guid("14618079-bb43-4448-8eca-c4a2b85c77d8"), "Lizzo & Drake", new DateTime(2029, 8, 2, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(8528), "An unforgettable night with Lizzo & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Lizzo & Drake: Summer Festival", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111181") },
                    { new Guid("181de9fc-32c5-48ba-b27e-945ce4fda0f5"), "Anne-Marie & Ed Sheeran", new DateTime(2027, 6, 5, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(8711), "Join Anne-Marie & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Anne-Marie & Ed Sheeran: Comeback Tour", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111118") },
                    { new Guid("18609045-f6fc-4640-835d-0e990ba19993"), "Daddy Yankee", new DateTime(2026, 1, 20, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8004), "An unforgettable night with Daddy Yankee showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Daddy Yankee: Stadium Tour", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111151") },
                    { new Guid("1875819f-c609-4e07-a484-633b77296595"), "Sam Smith", new DateTime(2026, 3, 3, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8572), "The electrifying Sam Smith brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Sam Smith: Acoustic Night", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111165") },
                    { new Guid("18cdb2d3-8b36-4477-b795-325c2d112a0c"), "Ava Max & Ed Sheeran", new DateTime(2027, 2, 2, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(984), "Experience the magic of Ava Max & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Ava Max & Ed Sheeran: Live in Concert", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111177") },
                    { new Guid("19bb40ac-3895-40ac-9a1c-47b594305504"), "Juice WRLD", new DateTime(2026, 2, 10, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8315), "Join Juice WRLD for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Juice WRLD: Reunion Tour", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111158") },
                    { new Guid("1abc7dbb-67e1-474e-8269-e82bc2259c11"), "Niall Horan", new DateTime(2026, 3, 12, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8664), "Join Niall Horan for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Niall Horan: Comeback Tour", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111168") },
                    { new Guid("1aca8e0f-5042-4fc0-882a-c3d421962aab"), "Ava Max & BTS", new DateTime(2028, 11, 11, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7694), "Join Ava Max & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Ava Max & BTS: Live at Home", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111193") },
                    { new Guid("1ad75aeb-07f9-4db0-85e7-ac237cdfee3d"), "Young Thug", new DateTime(2026, 7, 22, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(2836), "Experience the magic of Young Thug in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Young Thug: Farewell Tour", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111112") },
                    { new Guid("1b466c2e-6837-45e4-b879-33a5d857e871"), "Zedd & Ed Sheeran", new DateTime(2027, 6, 8, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(8855), "Zedd & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Zedd & Ed Sheeran: Anniversary Tour", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111119") },
                    { new Guid("1b4b7758-dc5b-4014-bd61-436b7ca476f2"), "Twenty One Pilots", new DateTime(2025, 12, 18, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(5235), "The electrifying Twenty One Pilots brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Twenty One Pilots: Legends Tour", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111140") },
                    { new Guid("1c44c487-4a06-433a-8d6d-17404e7f1015"), "James Arthur & BTS", new DateTime(2029, 3, 26, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(3703), "Join James Arthur & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "James Arthur & BTS: Live at Home", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111138") },
                    { new Guid("1db8d8f6-ac14-49a8-896d-bab9edc1dcea"), "Khalid & Ed Sheeran", new DateTime(2027, 1, 15, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(793), "An unforgettable night with Khalid & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Khalid & Ed Sheeran: Stadium Tour", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111171") },
                    { new Guid("1e6d3efa-729a-4f72-b4e6-41ed62ecaf92"), "Zara Larsson & Beyoncé", new DateTime(2028, 1, 31, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(8388), "Join Zara Larsson & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Zara Larsson & Beyoncé: Reunion Tour", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111198") },
                    { new Guid("1f4155c4-8d9c-4225-9919-5d5ea499da96"), "Harry Styles & Ed Sheeran", new DateTime(2026, 9, 5, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(4181), "Experience the magic of Harry Styles & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Harry Styles & Ed Sheeran: Farewell Tour", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111127") },
                    { new Guid("2052580f-78a0-4ed4-ae10-852e058ec6d8"), "Beyoncé", new DateTime(2027, 7, 8, 16, 41, 23, 400, DateTimeKind.Local).AddTicks(7605), "Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Beyoncé: The Sessions", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111129") },
                    { new Guid("20b0199a-6fdf-4d8b-9178-90d34db74f50"), "Adele & BTS", new DateTime(2028, 6, 5, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(3281), "The electrifying Adele & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Adele & BTS: Legends Tour", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111140") },
                    { new Guid("20f77fa0-34e4-4d30-953c-e35bf17c4c61"), "Charlie Puth", new DateTime(2026, 2, 28, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8542), "Charlie Puth returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Charlie Puth: The Sessions", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111164") },
                    { new Guid("211ad54a-7d0b-4131-a91e-d4528bc6fc6e"), "Halsey", new DateTime(2025, 12, 21, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(5533), "An unforgettable night with Halsey showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Halsey: World Tour", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111141") },
                    { new Guid("220a777c-0324-4f1a-913d-c403f1f1a248"), "The Script & Ed Sheeran", new DateTime(2027, 6, 29, 16, 41, 23, 399, DateTimeKind.Local).AddTicks(580), "An unforgettable night with The Script & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "The Script & Ed Sheeran: Summer Festival", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111126") },
                    { new Guid("222bc22a-f435-4583-bf11-f01957d1a420"), "Kygo & Drake", new DateTime(2029, 9, 1, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(9441), "An unforgettable night with Kygo & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Kygo & Drake: World Tour", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111191") },
                    { new Guid("22302f72-d03b-4458-9719-13c9523c6a5a"), "Nicki Minaj & BTS", new DateTime(2029, 1, 7, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(82), "Experience the magic of Nicki Minaj & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Nicki Minaj & BTS: Farewell Tour", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111112") },
                    { new Guid("2353992d-5130-4630-a5f7-6d9647a32e1b"), "Marshmello & Beyoncé", new DateTime(2027, 10, 21, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(548), "Marshmello & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Marshmello & Beyoncé: Anniversary Tour", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111164") },
                    { new Guid("2355549e-98b2-4a0b-818f-556bd88cea7c"), "Lana Del Rey & Ed Sheeran", new DateTime(2027, 1, 27, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(920), "The electrifying Lana Del Rey & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Lana Del Rey & Ed Sheeran: Legends Tour", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111175") },
                    { new Guid("2376f3b2-5adc-40c7-ad17-ff6746c5aa35"), "Twenty One Pilots & Drake", new DateTime(2029, 7, 6, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(6808), "Experience the magic of Twenty One Pilots & Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Twenty One Pilots & Drake: Farewell Tour", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111172") },
                    { new Guid("238b127f-367a-469f-8986-df4d41ac7e24"), "Drake & Beyoncé", new DateTime(2027, 7, 14, 16, 41, 23, 400, DateTimeKind.Local).AddTicks(8015), "An unforgettable night with Drake & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Drake & Beyoncé: Stadium Tour", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111131") },
                    { new Guid("23a2667b-e45f-4234-9bd6-159f252ef24b"), "Bruno Mars", new DateTime(2025, 10, 31, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(436), "Bruno Mars returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Bruno Mars: Anniversary Tour", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111124") },
                    { new Guid("244e889e-bdc5-46ca-ae00-bff02feebebe"), "DaBaby & Beyoncé", new DateTime(2027, 12, 29, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(6837), "Experience the magic of DaBaby & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "DaBaby & Beyoncé: Unplugged", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111187") },
                    { new Guid("245f8670-23d4-4e51-b2b5-a65b79c81802"), "Lil Baby", new DateTime(2026, 3, 24, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8835), "Experience the magic of Lil Baby in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Lil Baby: Live in Concert", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111172") },
                    { new Guid("24d2abe1-0f45-4719-a46f-0b7a9a217fb0"), "Miley Cyrus & Drake", new DateTime(2029, 9, 4, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(9474), "Experience the magic of Miley Cyrus & Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Miley Cyrus & Drake: Live in Concert", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111192") },
                    { new Guid("24d5f634-85f2-462f-9335-320fce15a7f1"), "Doja Cat & Drake", new DateTime(2029, 6, 30, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(6684), "The electrifying Doja Cat & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Doja Cat & Drake: Acoustic Night", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111170") },
                    { new Guid("253df387-29c1-426a-9229-231e9e1d2a1c"), "KAROL G & Beyoncé", new DateTime(2028, 2, 3, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(8592), "KAROL G & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "KAROL G & Beyoncé: Greatest Hits Tour", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111199") },
                    { new Guid("254528a8-647c-4e06-89da-8e571e727c79"), "Tame Impala & BTS", new DateTime(2028, 11, 26, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7850), "Join Tame Impala & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Tame Impala & BTS: Comeback Tour", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111198") },
                    { new Guid("25860718-edae-4c5e-9fa1-31193ba7e79e"), "Troye Sivan & BTS", new DateTime(2029, 2, 6, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(2949), "Experience the magic of Troye Sivan & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Troye Sivan & BTS: Unplugged", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111122") },
                    { new Guid("260727a0-a700-4e09-a714-2aa5b7829ddc"), "Lil Nas X", new DateTime(2025, 12, 30, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(5896), "Lil Nas X returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Lil Nas X: Greatest Hits Tour", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111144") },
                    { new Guid("28227ba9-fd96-4fba-b013-76a7fbbf54fc"), "Kygo", new DateTime(2026, 2, 13, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8341), "Kygo returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Kygo: Greatest Hits Tour", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111159") },
                    { new Guid("28a0e493-178c-48a0-a9cc-04960c72c955"), "Future & Ed Sheeran", new DateTime(2026, 12, 22, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(9834), "Join Future & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Future & Ed Sheeran: Reunion Tour", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111163") },
                    { new Guid("28b0ede5-bed7-4a00-8e55-07687b689cee"), "Mabel & BTS", new DateTime(2029, 2, 9, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(3094), "Join Mabel & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Mabel & BTS: Live at Home", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111123") },
                    { new Guid("2a89e10b-1048-4c87-a6d9-9332b97f3555"), "Dan + Shay & Beyoncé", new DateTime(2028, 3, 28, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(1168), "Experience the magic of Dan + Shay & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Dan + Shay & Beyoncé: Unplugged", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111117") },
                    { new Guid("2afa95fb-dfd2-43dd-8c28-c12870a843fa"), "Bastille & BTS", new DateTime(2029, 1, 28, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(2807), "Bastille & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Bastille & BTS: Greatest Hits Tour", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111119") },
                    { new Guid("2b157a36-235a-429d-895d-dcccb6dafade"), "Selena Gomez & Beyoncé", new DateTime(2027, 11, 5, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(1890), "Selena Gomez & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Selena Gomez & Beyoncé: Greatest Hits Tour", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111169") },
                    { new Guid("2b34d8cf-0a69-4f86-af2b-87ffd2e5e74d"), "Blackpink", new DateTime(2026, 1, 17, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(6668), "The electrifying Blackpink brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Blackpink: Acoustic Night", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111150") },
                    { new Guid("2c0e7469-2111-4837-b965-e03b8644d02a"), "Lewis Capaldi & Ed Sheeran", new DateTime(2026, 11, 13, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(7524), "The electrifying Lewis Capaldi & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Lewis Capaldi & Ed Sheeran: The Experience", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111150") },
                    { new Guid("2c892bd1-2490-4f7c-a87e-3eac6cd7fdbe"), "Imagine Dragons & Drake", new DateTime(2029, 6, 3, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(4577), "An unforgettable night with Imagine Dragons & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Imagine Dragons & Drake: World Tour", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111161") },
                    { new Guid("2e2c216c-2829-4dad-9e23-ced8612d032a"), "Jonas Brothers & Ed Sheeran", new DateTime(2026, 12, 19, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(9092), "Experience the magic of Jonas Brothers & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Jonas Brothers & Ed Sheeran: Live in Concert", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111162") },
                    { new Guid("2ee0e329-1f23-4a0c-ad96-2dd540a07964"), "Lil Uzi Vert", new DateTime(2026, 4, 29, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(9252), "Lil Uzi Vert returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Lil Uzi Vert: Anniversary Tour", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111184") },
                    { new Guid("2f11a29a-40fb-4dbc-a526-e8523a4b271e"), "Robin Schulz & BTS", new DateTime(2029, 3, 5, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(3431), "An unforgettable night with Robin Schulz & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Robin Schulz & BTS: World Tour", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111131") },
                    { new Guid("2f7fa6e1-c2f6-4076-9116-d11975bd55cf"), "Megan Thee Stallion", new DateTime(2026, 2, 7, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8284), "Experience the magic of Megan Thee Stallion in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Megan Thee Stallion: Live in Concert", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111157") },
                    { new Guid("2fb19ce5-8a95-4dbc-a2ef-6b9647df5744"), "J Balvin & Drake", new DateTime(2029, 6, 9, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(4908), "Join J Balvin & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "J Balvin & Drake: Reunion Tour", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111163") },
                    { new Guid("2ff537cd-8af4-475e-b582-da48fe7b0002"), "J Balvin & BTS", new DateTime(2028, 7, 20, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(4654), "The electrifying J Balvin & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "J Balvin & BTS: Legends Tour", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111155") },
                    { new Guid("30aaa606-94cf-44f2-bec2-72fc74d94167"), "Lana Del Rey & Drake", new DateTime(2029, 9, 25, 16, 41, 23, 405, DateTimeKind.Local).AddTicks(347), "Lana Del Rey & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Lana Del Rey & Drake: The Sessions", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111199") },
                    { new Guid("31ac7a0e-7c3f-4d29-89de-65e38ae5b293"), "Olivia Rodrigo & Beyoncé", new DateTime(2027, 10, 6, 16, 41, 23, 401, DateTimeKind.Local).AddTicks(8760), "Olivia Rodrigo & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Olivia Rodrigo & Beyoncé: The Sessions", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111159") },
                    { new Guid("32010720-b626-42f5-a288-ac1a1b1fb59d"), "Mabel & Beyoncé", new DateTime(2028, 3, 22, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(1101), "The electrifying Mabel & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Mabel & Beyoncé: The Experience", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111115") },
                    { new Guid("3291970c-c091-48d0-8e5a-f8df8ff634e3"), "J Balvin & Ed Sheeran", new DateTime(2026, 10, 11, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(4895), "J Balvin & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "J Balvin & Ed Sheeran: The Sessions", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111139") },
                    { new Guid("3375b7d0-32cc-471a-a090-7279ead43074"), "Drake", new DateTime(2029, 4, 22, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(4057), "Experience the magic of Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Drake: Live in Concert", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111147") },
                    { new Guid("345152aa-4915-496f-8c7b-b08508df2e1d"), "Miley Cyrus", new DateTime(2026, 2, 16, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8419), "The electrifying Miley Cyrus brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Miley Cyrus: The Experience", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111160") },
                    { new Guid("34b90c63-46bb-4164-b74e-40a0c4c94aec"), "Doja Cat & Beyoncé", new DateTime(2027, 9, 21, 16, 41, 23, 401, DateTimeKind.Local).AddTicks(4104), "Doja Cat & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Doja Cat & Beyoncé: Greatest Hits Tour", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111154") },
                    { new Guid("3569e103-a0be-4afc-99cc-a69886c68bdb"), "Dua Lipa & Beyoncé", new DateTime(2027, 8, 13, 16, 41, 23, 400, DateTimeKind.Local).AddTicks(9962), "An unforgettable night with Dua Lipa & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Dua Lipa & Beyoncé: Summer Festival", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111141") },
                    { new Guid("36a70e3d-cd80-4249-852d-53a183f83e7e"), "Sia & BTS", new DateTime(2028, 9, 21, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7083), "An unforgettable night with Sia & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Sia & BTS: Summer Festival", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111176") },
                    { new Guid("376b22e5-95b4-4cd1-b8ca-5bd5af682879"), "Bad Bunny & BTS", new DateTime(2028, 8, 1, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(4880), "Bad Bunny & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Bad Bunny & BTS: Greatest Hits Tour", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111159") },
                    { new Guid("385d111d-6c81-4027-820a-d56a91dac96c"), "Sam Smith & BTS", new DateTime(2028, 10, 30, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7528), "Sam Smith & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Sam Smith & BTS: Greatest Hits Tour", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111189") },
                    { new Guid("390eacd1-4571-454b-900e-179eb9355663"), "The Weeknd", new DateTime(2025, 10, 10, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(158), "Experience the magic of The Weeknd in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "The Weeknd: Unplugged", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111117") },
                    { new Guid("39aba83e-3f2c-43b8-b774-35d36cc9224f"), "Jonas Brothers & Drake", new DateTime(2029, 8, 17, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(9266), "An unforgettable night with Jonas Brothers & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Jonas Brothers & Drake: Stadium Tour", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111186") },
                    { new Guid("39cb9600-2319-4ee8-8f46-87c95a5c5ab1"), "Lady Gaga & Beyoncé", new DateTime(2027, 7, 29, 16, 41, 23, 400, DateTimeKind.Local).AddTicks(9404), "An unforgettable night with Lady Gaga & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Lady Gaga & Beyoncé: World Tour", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111136") },
                    { new Guid("39e37090-95de-45a0-afbe-43e6a43d40e2"), "Avicii & Ed Sheeran", new DateTime(2027, 5, 18, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(7700), "Experience the magic of Avicii & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Avicii & Ed Sheeran: Unplugged", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111112") },
                    { new Guid("3a523fe7-ca76-4c04-8869-80e2bc0ad6d9"), "Jonas Brothers & BTS", new DateTime(2028, 9, 27, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7149), "Join Jonas Brothers & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Jonas Brothers & BTS: Live at Home", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111178") },
                    { new Guid("3b30c634-3354-4816-b906-735d0d6fcfb1"), "Rihanna", new DateTime(2025, 11, 9, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(527), "Experience the magic of Rihanna in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Rihanna: Live in Concert", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111127") },
                    { new Guid("3b725ee5-1fa5-49e2-8f2e-fc794e3d8584"), "Ed Sheeran & Beyoncé", new DateTime(2027, 7, 5, 16, 41, 23, 400, DateTimeKind.Local).AddTicks(6572), "Join Ed Sheeran & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Ed Sheeran & Beyoncé: Live at Home", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111128") },
                    { new Guid("3bc9c45b-27d0-4501-ba64-f8bd3e0f99e7"), "Marshmello & Drake", new DateTime(2029, 7, 30, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(8494), "The electrifying Marshmello & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Marshmello & Drake: The Experience", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111180") },
                    { new Guid("3c1f2510-568c-4330-8942-6764547cd70c"), "Post Malone & BTS", new DateTime(2028, 6, 26, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(3570), "Experience the magic of Post Malone & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Post Malone & BTS: Unplugged", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111147") },
                    { new Guid("3d9bf236-a885-402f-b7a1-acf8759e35ed"), "Maroon 5 & BTS", new DateTime(2028, 7, 23, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(4687), "An unforgettable night with Maroon 5 & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Maroon 5 & BTS: World Tour", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111156") },
                    { new Guid("3df72858-cc41-40a7-9ef0-497a36cea6aa"), "Eminem & BTS", new DateTime(2028, 7, 29, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(4841), "Join Eminem & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Eminem & BTS: Reunion Tour", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111158") },
                    { new Guid("3e4ecf2d-9223-445a-b6bd-b3859ce40b6d"), "Bruno Mars & Ed Sheeran", new DateTime(2026, 9, 20, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(4610), "Experience the magic of Bruno Mars & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Bruno Mars & Ed Sheeran: Live in Concert", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111132") },
                    { new Guid("3e67e1e6-29d4-492d-a76b-cdeb8191724f"), "BLACKPINK ROSÉ & BTS", new DateTime(2029, 3, 29, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(3735), "BLACKPINK ROSÉ & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "BLACKPINK ROSÉ & BTS: The Sessions", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111139") },
                    { new Guid("3ee78370-d134-45c3-86bc-b2275fda107e"), "Lil Nas X & Ed Sheeran", new DateTime(2026, 11, 19, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(7588), "Experience the magic of Lil Nas X & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Lil Nas X & Ed Sheeran: Unplugged", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111152") },
                    { new Guid("3f1254d2-3c90-4ee6-a54c-32f7ed399072"), "BLACKPINK ROSÉ & Ed Sheeran", new DateTime(2027, 6, 20, 16, 41, 23, 399, DateTimeKind.Local).AddTicks(23), "Join BLACKPINK ROSÉ & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "BLACKPINK ROSÉ & Ed Sheeran: Reunion Tour", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111123") },
                    { new Guid("41930d2c-d0bc-4337-a651-710ce7dcde38"), "BTS & Ed Sheeran", new DateTime(2026, 8, 21, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(3636), "Experience the magic of BTS & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "BTS & Ed Sheeran: Unplugged", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111122") },
                    { new Guid("43b0facf-ff46-4bca-9a4f-a5fef0f4eb22"), "Marshmello & BTS", new DateTime(2028, 9, 9, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(6177), "Experience the magic of Marshmello & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Marshmello & BTS: Live in Concert", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111172") },
                    { new Guid("445aaaaf-d605-4403-a1d9-c0970cc047dd"), "Adele & Beyoncé", new DateTime(2027, 7, 17, 16, 41, 23, 400, DateTimeKind.Local).AddTicks(8050), "Experience the magic of Adele & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Adele & Beyoncé: Farewell Tour", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111132") },
                    { new Guid("44c9e36f-3b99-40d9-ab58-5ec22a1adb31"), "Luke Combs & Ed Sheeran", new DateTime(2027, 2, 5, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(1015), "Join Luke Combs & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Luke Combs & Ed Sheeran: Reunion Tour", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111178") },
                    { new Guid("45e89f2a-a7f9-4a66-b449-b538778857a6"), "SZA & Drake", new DateTime(2029, 7, 27, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(8453), "SZA & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "SZA & Drake: Greatest Hits Tour", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111179") },
                    { new Guid("46ca6dfd-0d7b-4027-89a7-a7832eb11078"), "Katy Perry & Drake", new DateTime(2029, 6, 6, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(4612), "Experience the magic of Katy Perry & Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Katy Perry & Drake: Live in Concert", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111162") },
                    { new Guid("46d9de4f-0708-41df-a5d2-65889afbc9ab"), "Megan Thee Stallion & Drake", new DateTime(2029, 8, 26, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(9379), "Megan Thee Stallion & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Megan Thee Stallion & Drake: Anniversary Tour", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111189") },
                    { new Guid("47055083-6aa3-4cb4-8175-a553b6d2aad4"), "Elton John & BTS", new DateTime(2028, 10, 21, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7441), "An unforgettable night with Elton John & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Elton John & BTS: World Tour", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111186") },
                    { new Guid("474953ff-09a4-477a-b249-95498e48c009"), "Taylor Swift", new DateTime(2025, 9, 22, 16, 41, 23, 395, DateTimeKind.Local).AddTicks(9755), "An unforgettable night with Taylor Swift showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Taylor Swift: World Tour", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("48ce7969-3c00-4f72-9ce7-c3c6f8d2312a"), "Bruno Mars & Beyoncé", new DateTime(2027, 8, 10, 16, 41, 23, 400, DateTimeKind.Local).AddTicks(9930), "The electrifying Bruno Mars & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Bruno Mars & Beyoncé: The Experience", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111140") },
                    { new Guid("4902c543-d14e-4bd7-bd53-aab506c2226b"), "Katy Perry & BTS", new DateTime(2028, 7, 17, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(4617), "Katy Perry & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Katy Perry & BTS: Anniversary Tour", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111154") },
                    { new Guid("4971aa75-1993-4019-b666-0055f4b1ac45"), "Luke Combs & BTS", new DateTime(2028, 11, 14, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7728), "Luke Combs & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Luke Combs & BTS: The Sessions", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111194") },
                    { new Guid("49ceacc6-59c2-497f-91c6-06031af6592b"), "Post Malone", new DateTime(2025, 10, 28, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(383), "Join Post Malone for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Post Malone: Comeback Tour", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111123") },
                    { new Guid("4a9773f3-c655-4708-978e-29cfb571913c"), "Lana Del Rey", new DateTime(2026, 3, 9, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8634), "Experience the magic of Lana Del Rey in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Lana Del Rey: Farewell Tour", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111167") },
                    { new Guid("4afcc1f7-47a9-41bc-9da4-d15c01ec93d3"), "Nicki Minaj & Ed Sheeran", new DateTime(2027, 3, 31, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(2243), "An unforgettable night with Nicki Minaj & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Nicki Minaj & Ed Sheeran: Summer Festival", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111196") },
                    { new Guid("4b24eb28-306b-435e-b4e8-00ee6e4f47c5"), "Bastille", new DateTime(2026, 6, 1, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(732), "The electrifying Bastille brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Bastille: Acoustic Night", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111195") },
                    { new Guid("4c0ca294-abbe-4ddc-a7ea-8f6612134580"), "Dua Lipa & Drake", new DateTime(2029, 5, 22, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(4405), "Experience the magic of Dua Lipa & Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Dua Lipa & Drake: Farewell Tour", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111157") },
                    { new Guid("4d28da3a-8073-4c72-a7a7-985f92c643ad"), "Camila Cabello & Beyoncé", new DateTime(2027, 9, 18, 16, 41, 23, 401, DateTimeKind.Local).AddTicks(4066), "Join Camila Cabello & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Camila Cabello & Beyoncé: Reunion Tour", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111153") },
                    { new Guid("4d309012-6f5f-492b-b48e-a3f32a838417"), "OneRepublic & Beyoncé", new DateTime(2028, 1, 28, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(8356), "Experience the magic of OneRepublic & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "OneRepublic & Beyoncé: Live in Concert", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111197") },
                    { new Guid("4d83994f-2cf1-4013-8e68-cec7efcfd00b"), "BLACKPINK ROSÉ & Beyoncé", new DateTime(2028, 5, 9, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(2206), "An unforgettable night with BLACKPINK ROSÉ & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "BLACKPINK ROSÉ & Beyoncé: Summer Festival", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111131") },
                    { new Guid("4e92a468-fff1-4af1-a27b-cb1116488282"), "Nicki Minaj", new DateTime(2026, 5, 11, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(9415), "Join Nicki Minaj for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Nicki Minaj: Reunion Tour", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111188") },
                    { new Guid("4f5aea44-723e-4258-80f9-bf6cc52e09ba"), "Tame Impala & Beyoncé", new DateTime(2028, 1, 7, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(7993), "The electrifying Tame Impala & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Tame Impala & Beyoncé: Acoustic Night", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111190") },
                    { new Guid("50d2803b-eee2-4df2-879b-ce8c8e6cb85c"), "Machine Gun Kelly & Ed Sheeran", new DateTime(2027, 4, 12, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(3887), "The electrifying Machine Gun Kelly & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Machine Gun Kelly & Ed Sheeran: Acoustic Night", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111200") },
                    { new Guid("522179ff-d0d8-4ed4-adf9-3b4bfd535199"), "Post Malone & Beyoncé", new DateTime(2027, 8, 7, 16, 41, 23, 400, DateTimeKind.Local).AddTicks(9862), "Post Malone & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Post Malone & Beyoncé: Greatest Hits Tour", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111139") },
                    { new Guid("52736df9-5593-478f-a308-fcbc5682fa99"), "Billie Eilish", new DateTime(2025, 10, 13, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(189), "Join Billie Eilish for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Billie Eilish: Live at Home", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111118") },
                    { new Guid("52790a59-7a87-4749-b9cf-2ac7676c1e51"), "Lil Nas X & BTS", new DateTime(2028, 8, 28, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(6043), "Join Lil Nas X & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Lil Nas X & BTS: Comeback Tour", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111168") },
                    { new Guid("52b16acd-8bea-4929-a2e3-0bb850455497"), "Maroon 5 & Drake", new DateTime(2029, 6, 12, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(4981), "Maroon 5 & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Maroon 5 & Drake: Greatest Hits Tour", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111164") },
                    { new Guid("541596cc-b39a-4ace-badf-71ee789a0289"), "Juice WRLD & BTS", new DateTime(2028, 10, 9, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7273), "Experience the magic of Juice WRLD & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Juice WRLD & BTS: Farewell Tour", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111182") },
                    { new Guid("54856a87-3224-479c-a115-1241c873a8aa"), "Lady Gaga & BTS", new DateTime(2028, 6, 17, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(3477), "Lady Gaga & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Lady Gaga & BTS: Greatest Hits Tour", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111144") },
                    { new Guid("550d9109-787c-4d0e-b240-2c6927275bf1"), "Little Mix & Ed Sheeran", new DateTime(2027, 4, 3, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(2287), "Experience the magic of Little Mix & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Little Mix & Ed Sheeran: Unplugged", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111197") },
                    { new Guid("550f18e5-dcde-4589-ab71-af46a6b939ee"), "NCT 127 & Ed Sheeran", new DateTime(2027, 5, 15, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(7509), "An unforgettable night with NCT 127 & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "NCT 127 & Ed Sheeran: Summer Festival", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("55ec9cd2-557c-4675-b004-99d409a7bd6f"), "James Arthur & Ed Sheeran", new DateTime(2027, 6, 17, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(9960), "Experience the magic of James Arthur & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "James Arthur & Ed Sheeran: Live in Concert", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111122") },
                    { new Guid("561f87c7-f2ce-4d95-a06d-866bef8ff76a"), "Rihanna & Drake", new DateTime(2029, 5, 28, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(4466), "Rihanna & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Rihanna & Drake: Anniversary Tour", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111159") },
                    { new Guid("5648d21c-046a-4dbe-aaf5-0f8fb805fea7"), "Lewis Capaldi", new DateTime(2025, 12, 24, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(5762), "Experience the magic of Lewis Capaldi in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Lewis Capaldi: Live in Concert", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111142") },
                    { new Guid("565f6aae-8517-425c-99c4-b79e5d7dbb7d"), "Juice WRLD & Beyoncé", new DateTime(2027, 11, 20, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(3798), "Juice WRLD & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Juice WRLD & Beyoncé: The Sessions", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111174") },
                    { new Guid("580e4505-8cf2-42f3-9b03-e9d59bc7b17a"), "Daddy Yankee & Ed Sheeran", new DateTime(2026, 12, 10, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(8662), "Daddy Yankee & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Daddy Yankee & Ed Sheeran: Anniversary Tour", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111159") },
                    { new Guid("5861ed93-49ce-4a71-9fc3-66ccea41a2cb"), "Tame Impala & Ed Sheeran", new DateTime(2027, 2, 17, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(1188), "Experience the magic of Tame Impala & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Tame Impala & Ed Sheeran: Unplugged", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111182") },
                    { new Guid("591332f9-c1be-4105-8ecf-7cdef26b8f08"), "Alan Walker", new DateTime(2026, 4, 17, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(9128), "The electrifying Alan Walker brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Alan Walker: Acoustic Night", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111180") },
                    { new Guid("5a44eafd-ccf0-4a3a-bce7-3ed26f7f198f"), "Elton John", new DateTime(2026, 2, 22, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8483), "Experience the magic of Elton John in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Elton John: Unplugged", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111162") },
                    { new Guid("5a9ed362-6233-487f-8b45-7a426e4c21b6"), "Ariana Grande & Beyoncé", new DateTime(2027, 8, 4, 16, 41, 23, 400, DateTimeKind.Local).AddTicks(9609), "Join Ariana Grande & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Ariana Grande & Beyoncé: Reunion Tour", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111138") },
                    { new Guid("5b5acb6e-065f-46e8-b172-cd3364bcaaa5"), "Jonas Brothers", new DateTime(2026, 1, 29, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8200), "Jonas Brothers returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Jonas Brothers: Anniversary Tour", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111154") },
                    { new Guid("5b954308-b5ed-44ba-b339-39e62046264e"), "Eminem & Beyoncé", new DateTime(2027, 9, 9, 16, 41, 23, 401, DateTimeKind.Local).AddTicks(3536), "The electrifying Eminem & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Eminem & Beyoncé: Legends Tour", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111150") },
                    { new Guid("5b95a085-2364-42f2-9d2a-0c2c12a99829"), "BTS", new DateTime(2028, 5, 30, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(3215), "Join BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "BTS: Comeback Tour", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111138") },
                    { new Guid("5bb8062c-6b2e-4725-afa9-ab7af1a8e94b"), "Elton John & Beyoncé", new DateTime(2027, 12, 2, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(5249), "Join Elton John & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Elton John & Beyoncé: Comeback Tour", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111178") },
                    { new Guid("5c6974f1-3102-4af0-830e-30ff45bc8379"), "David Guetta", new DateTime(2026, 2, 19, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8452), "An unforgettable night with David Guetta showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "David Guetta: Summer Festival", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111161") },
                    { new Guid("5c6f5f05-730b-44ab-918c-f940bfda7441"), "Martin Garrix & Beyoncé", new DateTime(2027, 12, 14, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(6112), "Experience the magic of Martin Garrix & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Martin Garrix & Beyoncé: Live in Concert", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111182") },
                    { new Guid("5c9ef963-005f-4b62-b27f-13a3b7f0af0b"), "Robin Schulz & Beyoncé", new DateTime(2028, 4, 15, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(1646), "Join Robin Schulz & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Robin Schulz & Beyoncé: Comeback Tour", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111123") },
                    { new Guid("5d3c53a4-df52-47ca-b9e4-17392606ff1e"), "Rosalía & BTS", new DateTime(2028, 12, 2, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7913), "The electrifying Rosalía & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Rosalía & BTS: Legends Tour", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111200") },
                    { new Guid("5de3b967-b0ae-4f04-ab73-cc27dcab33db"), "Robin Schulz & Ed Sheeran", new DateTime(2027, 5, 27, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(8434), "The electrifying Robin Schulz & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Robin Schulz & Ed Sheeran: Acoustic Night", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111115") },
                    { new Guid("5f1604d6-9c03-4d7c-8b44-8ab17a14b269"), "Halsey & Ed Sheeran", new DateTime(2026, 11, 10, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(7487), "Halsey & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Halsey & Ed Sheeran: Greatest Hits Tour", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111149") },
                    { new Guid("5f4bad14-055d-49d4-a735-1e35095f1fcb"), "Juice WRLD & Ed Sheeran", new DateTime(2026, 12, 31, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(366), "An unforgettable night with Juice WRLD & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Juice WRLD & Ed Sheeran: Summer Festival", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111166") },
                    { new Guid("60546c07-a9b9-4059-8d34-ba91ad3dc183"), "SZA", new DateTime(2026, 1, 8, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(6520), "Experience the magic of SZA in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "SZA: Unplugged", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111147") },
                    { new Guid("61603b9c-26eb-4a20-b117-bcc24c292d5a"), "SZA & BTS", new DateTime(2028, 9, 6, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(6144), "An unforgettable night with SZA & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "SZA & BTS: World Tour", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111171") },
                    { new Guid("6249ddbb-ed94-4547-a099-711d3e4c7542"), "Calvin Harris & Drake", new DateTime(2029, 7, 24, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(8285), "Join Calvin Harris & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Calvin Harris & Drake: Reunion Tour", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111178") },
                    { new Guid("627fa872-250e-46f8-b14b-3abe557676e1"), "The Kid LAROI & Beyoncé", new DateTime(2027, 11, 14, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(3647), "Experience the magic of The Kid LAROI & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "The Kid LAROI & Beyoncé: Unplugged", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111172") },
                    { new Guid("62e0f453-d725-4931-b2e1-95d900a63de2"), "David Guetta & BTS", new DateTime(2028, 10, 18, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7411), "The electrifying David Guetta & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "David Guetta & BTS: Legends Tour", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111185") },
                    { new Guid("639b5de0-da2d-40eb-ae6c-e6a2944bace0"), "Martin Garrix", new DateTime(2026, 3, 6, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8605), "An unforgettable night with Martin Garrix showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Martin Garrix: Stadium Tour", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111166") },
                    { new Guid("639f6420-e8bd-4bfd-91c9-369e046e31d8"), "The Chainsmokers & Beyoncé", new DateTime(2027, 10, 12, 16, 41, 23, 401, DateTimeKind.Local).AddTicks(8923), "An unforgettable night with The Chainsmokers & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "The Chainsmokers & Beyoncé: Stadium Tour", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111161") },
                    { new Guid("64224f2e-2910-4f3c-b9bf-714c9bb40351"), "Fall Out Boy & BTS", new DateTime(2029, 2, 27, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(3371), "Fall Out Boy & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Fall Out Boy & BTS: Anniversary Tour", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111129") },
                    { new Guid("6465a5e1-3cf2-445a-8f58-facc16ec0680"), "Bad Bunny & Beyoncé", new DateTime(2027, 9, 12, 16, 41, 23, 401, DateTimeKind.Local).AddTicks(3572), "An unforgettable night with Bad Bunny & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Bad Bunny & Beyoncé: World Tour", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111151") },
                    { new Guid("64a55ad5-c6ec-49e7-b34b-6804423e32c5"), "Harry Styles & BTS", new DateTime(2028, 6, 14, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(3445), "Join Harry Styles & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Harry Styles & BTS: Reunion Tour", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111143") },
                    { new Guid("65a65227-0e41-4637-9538-4ece1d050119"), "Post Malone & Ed Sheeran", new DateTime(2026, 9, 17, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(4506), "An unforgettable night with Post Malone & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Post Malone & Ed Sheeran: World Tour", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111131") },
                    { new Guid("65b298e8-0a96-4e67-807e-3266310613d3"), "Ed Sheeran", new DateTime(2025, 9, 25, 16, 41, 23, 395, DateTimeKind.Local).AddTicks(9919), "Experience the magic of Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Ed Sheeran: Live in Concert", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111112") },
                    { new Guid("67b3c836-79f5-4654-ba7f-8cdb7d5ef148"), "Calvin Harris & Beyoncé", new DateTime(2027, 10, 15, 16, 41, 23, 401, DateTimeKind.Local).AddTicks(9143), "Experience the magic of Calvin Harris & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Calvin Harris & Beyoncé: Farewell Tour", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111162") },
                    { new Guid("67ee9364-149d-4b95-8188-892a2ef5527b"), "Kendrick Lamar & BTS", new DateTime(2028, 7, 5, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(3982), "The electrifying Kendrick Lamar & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Kendrick Lamar & BTS: Acoustic Night", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111150") },
                    { new Guid("688333a3-2e39-467a-ad56-dda1010e76a6"), "Justin Bieber & Beyoncé", new DateTime(2027, 8, 1, 16, 41, 23, 400, DateTimeKind.Local).AddTicks(9543), "Experience the magic of Justin Bieber & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Justin Bieber & Beyoncé: Live in Concert", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111137") },
                    { new Guid("68b54138-1923-40c3-9725-19a05b2bfa3e"), "Shawn Mendes & BTS", new DateTime(2028, 8, 4, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(5020), "The electrifying Shawn Mendes & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Shawn Mendes & BTS: The Experience", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111160") },
                    { new Guid("68e7938e-7a3d-40c1-8fce-21418ad35e28"), "The Script & Beyoncé", new DateTime(2028, 5, 18, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(3083), "The Script & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "The Script & Beyoncé: The Sessions", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111134") },
                    { new Guid("68fa755c-d94b-4fd6-88bb-00c12c8873f8"), "Lauv & Ed Sheeran", new DateTime(2027, 6, 14, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(9206), "An unforgettable night with Lauv & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Lauv & Ed Sheeran: World Tour", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111121") },
                    { new Guid("6904a09c-ab3f-4725-a3dc-21798d3c5937"), "Khalid", new DateTime(2026, 2, 25, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8512), "Join Khalid for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Khalid: Live at Home", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111163") },
                    { new Guid("6917df1b-464e-430f-a254-f00299f0a1c4"), "Dua Lipa", new DateTime(2025, 11, 3, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(469), "The electrifying Dua Lipa brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Dua Lipa: Legends Tour", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111125") },
                    { new Guid("698b84a6-0afc-44eb-b4f3-fb41832e2e4f"), "Shawn Mendes & Beyoncé", new DateTime(2027, 9, 15, 16, 41, 23, 401, DateTimeKind.Local).AddTicks(3920), "Experience the magic of Shawn Mendes & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Shawn Mendes & Beyoncé: Live in Concert", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111152") },
                    { new Guid("69f6e700-c87d-487c-97b2-8d63e806c518"), "Luke Combs", new DateTime(2026, 3, 18, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8761), "The electrifying Luke Combs brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Luke Combs: Legends Tour", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111170") },
                    { new Guid("6a345eff-01bc-41fe-95b3-f953cb4c901f"), "Megan Thee Stallion & Beyoncé", new DateTime(2027, 11, 17, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(3722), "Join Megan Thee Stallion & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Megan Thee Stallion & Beyoncé: Live at Home", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111173") },
                    { new Guid("6a5bc475-5d70-435a-a80c-bbe3b5017bd0"), "Adele & Drake", new DateTime(2029, 4, 25, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(4087), "Join Adele & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Adele & Drake: Reunion Tour", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111148") },
                    { new Guid("6ace52ac-c656-4da8-8db7-548400e465fb"), "Anitta & Beyoncé", new DateTime(2028, 3, 16, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(998), "Join Anitta & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Anitta & Beyoncé: Reunion Tour", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111113") },
                    { new Guid("6b8b74cf-d242-4a04-a3ba-6dc457506787"), "Taylor Swift & BTS", new DateTime(2028, 5, 21, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(3116), "The electrifying Taylor Swift & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Taylor Swift & BTS: Acoustic Night", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111135") },
                    { new Guid("6c471bd0-90f9-4845-b9c8-0255a52cbb53"), "Lauv & Beyoncé", new DateTime(2028, 5, 3, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(2073), "Lauv & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Lauv & Beyoncé: Greatest Hits Tour", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111129") },
                    { new Guid("6d26fab6-f3d8-40d7-b038-19b7cf2bc114"), "Billie Eilish & Ed Sheeran", new DateTime(2026, 9, 2, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(4146), "An unforgettable night with Billie Eilish & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Billie Eilish & Ed Sheeran: Stadium Tour", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111126") },
                    { new Guid("6d43973b-2b31-4d04-b725-4fd81f3f439c"), "The Weeknd & Beyoncé", new DateTime(2027, 7, 20, 16, 41, 23, 400, DateTimeKind.Local).AddTicks(9042), "Join The Weeknd & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "The Weeknd & Beyoncé: Comeback Tour", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111133") },
                    { new Guid("6ea1aa8c-a273-4523-a491-9cef6bffc03b"), "Future & Beyoncé", new DateTime(2027, 11, 11, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(3279), "An unforgettable night with Future & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Future & Beyoncé: Summer Festival", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111171") },
                    { new Guid("6f24a470-9d17-444e-bc87-00009060bad5"), "Justin Bieber & BTS", new DateTime(2028, 6, 20, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(3509), "The electrifying Justin Bieber & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Justin Bieber & BTS: The Experience", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111145") },
                    { new Guid("6f48c593-3ebd-4dab-ad5d-c37e175f36c4"), "Anitta & BTS", new DateTime(2029, 2, 3, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(2910), "An unforgettable night with Anitta & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Anitta & BTS: Summer Festival", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111121") },
                    { new Guid("6f56df60-2d7d-4a71-961d-a42d317fac23"), "Glass Animals", new DateTime(2026, 4, 11, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(9065), "Join Glass Animals for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Glass Animals: Live at Home", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111178") },
                    { new Guid("6fce4ae7-5188-4e67-a554-018ee4402fcd"), "Young Thug & BTS", new DateTime(2029, 3, 20, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(3637), "An unforgettable night with Young Thug & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Young Thug & BTS: Summer Festival", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111136") },
                    { new Guid("6fe33acf-68dd-4542-bdd7-01ef547d2a98"), "Niall Horan & Beyoncé", new DateTime(2027, 12, 20, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(6193), "Niall Horan & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Niall Horan & Beyoncé: Greatest Hits Tour", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111184") },
                    { new Guid("70468e45-7f9f-4bdc-af01-8b6290cedfe2"), "Miley Cyrus & Ed Sheeran", new DateTime(2027, 1, 6, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(578), "Join Miley Cyrus & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Miley Cyrus & Ed Sheeran: Live at Home", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111168") },
                    { new Guid("70cc40ab-5376-40c7-914a-1aba48f87502"), "Lil Baby & Ed Sheeran", new DateTime(2027, 2, 11, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(1121), "The electrifying Lil Baby & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Lil Baby & Ed Sheeran: The Experience", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111180") },
                    { new Guid("7120d330-ce13-4ac9-94f4-7d11333843b3"), "YUNGBLUD & BTS", new DateTime(2029, 1, 13, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(194), "YUNGBLUD & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "YUNGBLUD & BTS: Anniversary Tour", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111114") },
                    { new Guid("72399432-0685-41c5-8e04-ec83e2ce2e4f"), "Kendrick Lamar & Drake", new DateTime(2029, 5, 25, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(4435), "Join Kendrick Lamar & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Kendrick Lamar & Drake: Comeback Tour", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111158") },
                    { new Guid("72b03b5b-9bdb-41ae-9c49-aea09c166891"), "Miley Cyrus & Beyoncé", new DateTime(2027, 11, 26, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(5036), "An unforgettable night with Miley Cyrus & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Miley Cyrus & Beyoncé: Stadium Tour", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111176") },
                    { new Guid("72bdcd16-140d-437e-a211-8ba357978304"), "DaBaby", new DateTime(2026, 3, 21, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8805), "An unforgettable night with DaBaby showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "DaBaby: World Tour", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111171") },
                    { new Guid("730c237c-c5ae-4b37-8147-c749f922b1ab"), "KAROL G", new DateTime(2026, 4, 26, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(9222), "Join KAROL G for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "KAROL G: Comeback Tour", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111183") },
                    { new Guid("74031357-ea81-430a-833b-3790ba30707d"), "Machine Gun Kelly", new DateTime(2026, 5, 23, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(9915), "Experience the magic of Machine Gun Kelly in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Machine Gun Kelly: Unplugged", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111192") },
                    { new Guid("74e1a368-4867-45cf-91d0-2a11664314cc"), "Lady Gaga", new DateTime(2025, 10, 19, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(249), "The electrifying Lady Gaga brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Lady Gaga: Acoustic Night", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111120") },
                    { new Guid("755b94e4-9868-4e5a-90b6-78634dd72f16"), "Marshmello & Ed Sheeran", new DateTime(2026, 12, 1, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(8553), "An unforgettable night with Marshmello & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Marshmello & Ed Sheeran: Stadium Tour", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111156") },
                    { new Guid("77241910-ce92-4d5a-bdc7-a137f93c1b31"), "Cardi B", new DateTime(2025, 12, 15, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(5152), "Cardi B returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Cardi B: Anniversary Tour", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111139") },
                    { new Guid("77c0535c-b3f7-43e1-8ac7-0b2a67d72324"), "Charlie Puth & Drake", new DateTime(2029, 9, 16, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(9635), "An unforgettable night with Charlie Puth & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Charlie Puth & Drake: Summer Festival", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111196") },
                    { new Guid("77c66649-fee2-40f6-ae89-d762e86ac2f4"), "SEVENTEEN & Beyoncé", new DateTime(2028, 4, 12, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(1467), "Experience the magic of SEVENTEEN & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "SEVENTEEN & Beyoncé: Farewell Tour", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111122") },
                    { new Guid("77fbc72c-4bc0-4c5b-b4e7-65b43f48cdf0"), "Khalid & Beyoncé", new DateTime(2027, 12, 5, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(5803), "Khalid & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Khalid & Beyoncé: Anniversary Tour", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111179") },
                    { new Guid("7801fd9a-e991-42eb-8074-364d8f869629"), "Lizzo & Ed Sheeran", new DateTime(2026, 12, 4, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(8590), "Experience the magic of Lizzo & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Lizzo & Ed Sheeran: Farewell Tour", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111157") },
                    { new Guid("786b303e-95f1-4c00-8b4d-1d8df4c7f009"), "Offset & Beyoncé", new DateTime(2028, 4, 21, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(1751), "The electrifying Offset & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Offset & Beyoncé: Legends Tour", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111125") },
                    { new Guid("78ac67c4-de12-4b56-9024-e84b3813a9f8"), "Glass Animals & Ed Sheeran", new DateTime(2027, 3, 1, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(1315), "An unforgettable night with Glass Animals & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Glass Animals & Ed Sheeran: Stadium Tour", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111186") },
                    { new Guid("78e1e485-f7b1-4b60-804d-c132417e0009"), "Madison Beer & Beyoncé", new DateTime(2028, 5, 12, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(2943), "Experience the magic of Madison Beer & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Madison Beer & Beyoncé: Unplugged", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111132") },
                    { new Guid("792b786f-60a4-4272-ba1d-270f0dca8512"), "Megan Thee Stallion & BTS", new DateTime(2028, 10, 6, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7243), "An unforgettable night with Megan Thee Stallion & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Megan Thee Stallion & BTS: Stadium Tour", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111181") },
                    { new Guid("7957cbd0-daa8-4081-b50c-37dd7f6c2f21"), "Fall Out Boy & Ed Sheeran", new DateTime(2027, 5, 21, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(8219), "Join Fall Out Boy & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Fall Out Boy & Ed Sheeran: Live at Home", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111113") },
                    { new Guid("7a315dfa-a59d-416f-b283-d2225d01c68b"), "Anne-Marie & Beyoncé", new DateTime(2028, 4, 24, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(1782), "An unforgettable night with Anne-Marie & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Anne-Marie & Beyoncé: World Tour", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111126") },
                    { new Guid("7b3d24b9-3a28-443f-897f-1842c8879359"), "Tame Impala", new DateTime(2026, 3, 30, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8900), "Tame Impala returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Tame Impala: Greatest Hits Tour", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111174") },
                    { new Guid("7b78addc-a4af-41c0-a5ca-14e612390589"), "James Arthur & Beyoncé", new DateTime(2028, 5, 6, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(2172), "The electrifying James Arthur & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "James Arthur & Beyoncé: The Experience", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111130") },
                    { new Guid("7c5fa001-2145-45c1-8249-1e9a124b1734"), "Jack Harlow", new DateTime(2026, 3, 27, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8867), "Join Jack Harlow for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Jack Harlow: Reunion Tour", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111173") },
                    { new Guid("7cdfa267-cb36-4df7-901b-72ae313acd7f"), "Khalid & Drake", new DateTime(2029, 9, 13, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(9603), "The electrifying Khalid & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Khalid & Drake: The Experience", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111195") },
                    { new Guid("7ce325a4-1956-416e-bcc6-5ee53c518849"), "Lil Uzi Vert & Ed Sheeran", new DateTime(2027, 3, 19, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(1766), "Experience the magic of Lil Uzi Vert & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Lil Uzi Vert & Ed Sheeran: Live in Concert", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111192") },
                    { new Guid("7e1ac943-12c8-4395-b836-5f80ace9d8d4"), "BTS & Beyoncé", new DateTime(2027, 7, 11, 16, 41, 23, 400, DateTimeKind.Local).AddTicks(7950), "The electrifying BTS & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "BTS & Beyoncé: Acoustic Night", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111130") },
                    { new Guid("7edfaf72-dea0-423a-98e1-f5c6343eefa8"), "Martin Garrix & Drake", new DateTime(2029, 9, 22, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(9698), "Join Martin Garrix & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Martin Garrix & Drake: Live at Home", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111198") },
                    { new Guid("7f5606ec-c8d1-41ba-84b2-67fb9f731271"), "Machine Gun Kelly & BTS", new DateTime(2029, 1, 19, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(793), "An unforgettable night with Machine Gun Kelly & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Machine Gun Kelly & BTS: World Tour", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111116") },
                    { new Guid("7fb131b2-dd72-4ef9-825d-cd6822d2ae4a"), "Drake & BTS", new DateTime(2028, 6, 2, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(3248), "Drake & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Drake & BTS: Anniversary Tour", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111139") },
                    { new Guid("8025f6df-99fc-435f-b805-d5a7e36706a4"), "Madison Beer & Ed Sheeran", new DateTime(2027, 6, 23, 16, 41, 23, 399, DateTimeKind.Local).AddTicks(59), "Madison Beer & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Madison Beer & Ed Sheeran: Greatest Hits Tour", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111124") },
                    { new Guid("802ddb08-92ad-4ffa-8fbb-3b645b80a01e"), "Lana Del Rey & BTS", new DateTime(2028, 11, 5, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7589), "An unforgettable night with Lana Del Rey & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Lana Del Rey & BTS: Summer Festival", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111191") },
                    { new Guid("81d3d6d3-c34e-40de-a7aa-07b59428c0e7"), "Blackpink & Ed Sheeran", new DateTime(2026, 12, 7, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(8624), "Join Blackpink & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Blackpink & Ed Sheeran: Comeback Tour", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111158") },
                    { new Guid("81ea7d39-346d-49a5-a1ba-acaeecb37409"), "Imagine Dragons", new DateTime(2025, 11, 15, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(2259), "Imagine Dragons returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Imagine Dragons: Greatest Hits Tour", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111129") },
                    { new Guid("82e49645-abc3-4d4c-a086-5b7235d5d5f5"), "Jack Harlow & Beyoncé", new DateTime(2028, 1, 4, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(7952), "Jack Harlow & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Jack Harlow & Beyoncé: The Sessions", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111189") },
                    { new Guid("835e32b1-38e8-422f-a39f-8a8f58297d57"), "Lil Baby & BTS", new DateTime(2028, 11, 20, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7790), "An unforgettable night with Lil Baby & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Lil Baby & BTS: Stadium Tour", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111196") },
                    { new Guid("835f2495-f67e-4071-a596-7a9bf3b462b5"), "Eminem & Drake", new DateTime(2029, 6, 18, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(5069), "An unforgettable night with Eminem & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Eminem & Drake: Summer Festival", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111166") },
                    { new Guid("83922827-59b6-42c0-8f4d-5f493053426e"), "Lady Gaga & Drake", new DateTime(2029, 5, 7, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(4249), "Experience the magic of Lady Gaga & Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Lady Gaga & Drake: Unplugged", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111152") },
                    { new Guid("83e22a4f-c4e6-4ab8-94fb-84ba4657963f"), "Sam Smith & Beyoncé", new DateTime(2027, 12, 11, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(5952), "An unforgettable night with Sam Smith & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Sam Smith & Beyoncé: World Tour", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111181") },
                    { new Guid("84ddc53a-f26c-40ba-be3f-1ac1317e7805"), "Kygo & Beyoncé", new DateTime(2027, 11, 23, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(3830), "The electrifying Kygo & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Kygo & Beyoncé: Acoustic Night", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111175") },
                    { new Guid("85a105d2-36b4-4eca-8615-9de77e5495e9"), "Justin Bieber & Ed Sheeran", new DateTime(2026, 9, 11, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(4441), "Justin Bieber & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Justin Bieber & Ed Sheeran: Anniversary Tour", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111129") },
                    { new Guid("85b73afc-ba03-4a2c-8d95-6792ab8cdee9"), "Lauv & BTS", new DateTime(2029, 3, 23, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(3668), "Experience the magic of Lauv & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Lauv & BTS: Unplugged", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111137") },
                    { new Guid("85d4e02d-749a-4f73-b363-a7b797acffd5"), "Halsey & Beyoncé", new DateTime(2027, 9, 30, 16, 41, 23, 401, DateTimeKind.Local).AddTicks(5654), "Experience the magic of Halsey & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Halsey & Beyoncé: Unplugged", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111157") },
                    { new Guid("863fed69-29ad-4e85-a58d-36b58969ccce"), "Martin Garrix & Ed Sheeran", new DateTime(2027, 1, 24, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(890), "Martin Garrix & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Martin Garrix & Ed Sheeran: Anniversary Tour", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111174") },
                    { new Guid("86c2d1f6-5509-4e2f-8180-4c847abd0e29"), "Justin Bieber & Drake", new DateTime(2029, 5, 10, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(4282), "Join Justin Bieber & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Justin Bieber & Drake: Live at Home", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111153") },
                    { new Guid("87cc163f-86f3-4dc1-b74d-b78397353e06"), "David Guetta & Ed Sheeran", new DateTime(2027, 1, 9, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(657), "David Guetta & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "David Guetta & Ed Sheeran: The Sessions", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111169") },
                    { new Guid("8969a61c-0834-4e00-be66-9ec420688bf6"), "Jonas Brothers & Beyoncé", new DateTime(2027, 11, 8, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(2868), "The electrifying Jonas Brothers & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Jonas Brothers & Beyoncé: The Experience", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111170") },
                    { new Guid("89e73bc7-798d-48cc-a89b-0f282b51e4cd"), "Maroon 5 & Ed Sheeran", new DateTime(2026, 10, 14, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(5054), "The electrifying Maroon 5 & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Maroon 5 & Ed Sheeran: Acoustic Night", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111140") },
                    { new Guid("8a1117af-a09f-48d6-b08f-38dfda980b67"), "G-Eazy & Beyoncé", new DateTime(2028, 3, 25, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(1134), "An unforgettable night with G-Eazy & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "G-Eazy & Beyoncé: Summer Festival", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111116") },
                    { new Guid("8a8ce2c8-0867-444c-a0e9-bc33c5d7cd5e"), "Rihanna & Ed Sheeran", new DateTime(2026, 9, 29, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(4725), "The electrifying Rihanna & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Rihanna & Ed Sheeran: The Experience", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111135") },
                    { new Guid("8b10ae24-1fe1-4045-973b-2606deafba0a"), "Glass Animals & Beyoncé", new DateTime(2028, 1, 19, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(8260), "Glass Animals & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Glass Animals & Beyoncé: Anniversary Tour", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111194") },
                    { new Guid("8c88a752-6501-4e69-8678-8ec67d7a3a3a"), "Ava Max", new DateTime(2026, 3, 15, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8693), "Ava Max returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Ava Max: Anniversary Tour", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111169") },
                    { new Guid("8d790e87-0c5e-4932-8718-6614a9488949"), "Madison Beer", new DateTime(2026, 8, 3, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(3234), "An unforgettable night with Madison Beer showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Madison Beer: World Tour", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111116") },
                    { new Guid("8de4051c-caf5-4f16-99d1-225ae4e28766"), "Olivia Rodrigo & Drake", new DateTime(2029, 7, 15, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(7290), "The electrifying Olivia Rodrigo & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Olivia Rodrigo & Drake: Legends Tour", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111175") },
                    { new Guid("8e0dbdb8-57bd-45ee-8505-1cb5c5a9b526"), "Cardi B & Ed Sheeran", new DateTime(2026, 11, 4, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(7375), "Experience the magic of Cardi B & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Cardi B & Ed Sheeran: Live in Concert", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111147") },
                    { new Guid("8e2f8b95-ad3c-4777-9811-f3c4bed1ceec"), "Maroon 5", new DateTime(2025, 11, 24, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(2666), "Experience the magic of Maroon 5 in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Maroon 5: Unplugged", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111132") },
                    { new Guid("8f768acc-204c-440e-8adf-62de936fed26"), "Beyoncé & Ed Sheeran", new DateTime(2026, 8, 18, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(3391), "An unforgettable night with Beyoncé & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Beyoncé & Ed Sheeran: Summer Festival", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111121") },
                    { new Guid("8f7f169c-cf49-4672-8137-5a66bbc4eeba"), "LISA & Ed Sheeran", new DateTime(2027, 6, 26, 16, 41, 23, 399, DateTimeKind.Local).AddTicks(91), "The electrifying LISA & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "LISA & Ed Sheeran: The Experience", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111125") },
                    { new Guid("9002b807-6280-4365-a90b-7f7c8627f6f6"), "Jack Harlow & Ed Sheeran", new DateTime(2027, 2, 14, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(1152), "An unforgettable night with Jack Harlow & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Jack Harlow & Ed Sheeran: Summer Festival", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111181") },
                    { new Guid("90485b3d-0984-4f27-97b8-351e8f7dd181"), "Rihanna & Beyoncé", new DateTime(2027, 8, 19, 16, 41, 23, 401, DateTimeKind.Local).AddTicks(2362), "Join Rihanna & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Rihanna & Beyoncé: Live at Home", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111143") },
                    { new Guid("9071604d-8cc7-46a0-b097-a4e88574c35f"), "Adele", new DateTime(2025, 10, 7, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(125), "An unforgettable night with Adele showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Adele: Summer Festival", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111116") },
                    { new Guid("9075bdc8-c558-47b2-9953-151930f1b213"), "Billie Eilish & Drake", new DateTime(2029, 5, 1, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(4147), "The electrifying Billie Eilish & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Billie Eilish & Drake: The Experience", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111150") },
                    { new Guid("909566e7-762b-41a3-82c7-4a4ccb5f9043"), "DaBaby & BTS", new DateTime(2028, 11, 17, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7759), "The electrifying DaBaby & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "DaBaby & BTS: Acoustic Night", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111195") },
                    { new Guid("90fd94c3-d03d-474a-bf1b-c7bcf09341a2"), "Calvin Harris & BTS", new DateTime(2028, 9, 3, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(6112), "The electrifying Calvin Harris & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Calvin Harris & BTS: Legends Tour", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111170") },
                    { new Guid("9185110f-3b52-48cd-b449-83c9c5ee4a33"), "Post Malone & Drake", new DateTime(2029, 5, 16, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(4345), "The electrifying Post Malone & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Post Malone & Drake: Acoustic Night", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111155") },
                    { new Guid("925de6fb-043a-4d7a-8ff6-dfadf57d7a7d"), "Bruno Mars & BTS", new DateTime(2028, 6, 29, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(3759), "Join Bruno Mars & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Bruno Mars & BTS: Live at Home", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111148") },
                    { new Guid("9295151d-189b-4fc1-a57c-765406d8039c"), "Kehlani & BTS", new DateTime(2029, 1, 16, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(382), "The electrifying Kehlani & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Kehlani & BTS: Legends Tour", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111115") },
                    { new Guid("92a401b1-bed2-494d-9e6e-80c7e21d2ae2"), "Cardi B & Drake", new DateTime(2029, 7, 3, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(6771), "An unforgettable night with Cardi B & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Cardi B & Drake: Stadium Tour", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111171") },
                    { new Guid("92f3d9db-e426-402b-9dff-783944f65f52"), "Tyler, The Creator", new DateTime(2026, 5, 29, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(695), "Tyler, The Creator returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Tyler, The Creator: The Sessions", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111194") },
                    { new Guid("9309b6eb-6fb6-4634-812a-61019652cff6"), "The Weeknd & BTS", new DateTime(2028, 6, 8, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(3361), "An unforgettable night with The Weeknd & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "The Weeknd & BTS: World Tour", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111141") },
                    { new Guid("934fc0a5-0516-4979-9d79-85ea222609c6"), "Lewis Capaldi & BTS", new DateTime(2028, 8, 22, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(5619), "An unforgettable night with Lewis Capaldi & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Lewis Capaldi & BTS: Stadium Tour", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111166") },
                    { new Guid("940b9632-48fb-4892-bf0d-798bbeb36f81"), "Drake", new DateTime(2025, 10, 4, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(93), "The electrifying Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Drake: The Experience", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111115") },
                    { new Guid("941014a9-8515-4516-8e6c-c5ae5336d3a7"), "Maroon 5 & Beyoncé", new DateTime(2027, 9, 3, 16, 41, 23, 401, DateTimeKind.Local).AddTicks(3237), "Join Maroon 5 & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Maroon 5 & Beyoncé: Comeback Tour", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111148") },
                    { new Guid("942bc4bb-b9ec-481f-8a12-899d0ff16be6"), "5 Seconds of Summer & BTS", new DateTime(2029, 1, 4, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(9911), "An unforgettable night with 5 Seconds of Summer & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "5 Seconds of Summer & BTS: Stadium Tour", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("94bcbbbf-a33a-4f6b-8464-3a130fa3f294"), "Zara Larsson", new DateTime(2026, 4, 23, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(9192), "Experience the magic of Zara Larsson in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Zara Larsson: Farewell Tour", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111182") },
                    { new Guid("94c0d856-af92-47d1-a1b1-0a0b18803649"), "Zara Larsson & Ed Sheeran", new DateTime(2027, 3, 13, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(1482), "The electrifying Zara Larsson & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Zara Larsson & Ed Sheeran: Legends Tour", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111190") },
                    { new Guid("9549867d-4737-4ce5-8a2d-56be0391f9df"), "Lana Del Rey & Beyoncé", new DateTime(2027, 12, 17, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(6163), "Join Lana Del Rey & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Lana Del Rey & Beyoncé: Reunion Tour", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111183") },
                    { new Guid("9607c089-cbc5-4499-9bfc-0d1c5fa63d3c"), "SEVENTEEN & Ed Sheeran", new DateTime(2027, 5, 24, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(8389), "SEVENTEEN & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "SEVENTEEN & Ed Sheeran: The Sessions", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111114") },
                    { new Guid("961e27f1-9a79-41d6-827e-457ad74c9352"), "Calvin Harris", new DateTime(2026, 1, 5, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(6266), "An unforgettable night with Calvin Harris showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Calvin Harris: Summer Festival", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111146") },
                    { new Guid("9704a4b1-910e-4cfb-87bf-f7e79d07bea0"), "Camila Cabello", new DateTime(2025, 12, 9, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(4845), "Experience the magic of Camila Cabello in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Camila Cabello: Farewell Tour", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111137") },
                    { new Guid("975bddc6-6e2b-4ec7-8e71-9829f24aac3f"), "Panic! At The Disco", new DateTime(2026, 5, 26, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(647), "Join Panic! At The Disco for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Panic! At The Disco: Live at Home", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111193") },
                    { new Guid("9800c52c-56f7-4810-b56b-315ef9d1d0d7"), "Shawn Mendes & Ed Sheeran", new DateTime(2026, 10, 26, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(5900), "Shawn Mendes & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Shawn Mendes & Ed Sheeran: Anniversary Tour", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111144") },
                    { new Guid("98645266-a223-4742-84dc-9fb79ce60c76"), "Tyler, The Creator & BTS", new DateTime(2029, 1, 25, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(2327), "Join Tyler, The Creator & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Tyler, The Creator & BTS: Reunion Tour", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111118") },
                    { new Guid("992f7b8e-4cd6-421d-ae09-1ae427256006"), "Beyoncé", new DateTime(2025, 9, 28, 16, 41, 23, 395, DateTimeKind.Local).AddTicks(9954), "Join Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Beyoncé: Reunion Tour", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111113") },
                    { new Guid("9978acc7-e88a-4cd9-aca6-0bf663d6c3b3"), "BTS & Drake", new DateTime(2029, 4, 19, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(4026), "An unforgettable night with BTS & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "BTS & Drake: World Tour", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111146") },
                    { new Guid("9aea68f8-5e2a-49cd-b09a-7ecdb7153ce3"), "J Balvin & Beyoncé", new DateTime(2027, 8, 31, 16, 41, 23, 401, DateTimeKind.Local).AddTicks(3202), "Experience the magic of J Balvin & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "J Balvin & Beyoncé: Farewell Tour", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111147") },
                    { new Guid("9c1e36f2-3407-4b12-9008-24b8b31edca1"), "Kygo & BTS", new DateTime(2028, 10, 12, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7304), "Join Kygo & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Kygo & BTS: Comeback Tour", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111183") },
                    { new Guid("9c1eadcd-9612-4037-afb0-46a118386dbd"), "LISA & BTS", new DateTime(2029, 4, 4, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(3798), "An unforgettable night with LISA & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "LISA & BTS: Stadium Tour", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111141") },
                    { new Guid("9c2f6fde-93a0-4e09-8b01-ff7d343f0ed6"), "Cardi B & BTS", new DateTime(2028, 8, 13, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(5232), "Join Cardi B & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Cardi B & BTS: Live at Home", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111163") },
                    { new Guid("9c3d6947-deb6-4f55-98dd-0abf620592e8"), "BLACKPINK ROSÉ", new DateTime(2026, 7, 31, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(3112), "The electrifying BLACKPINK ROSÉ brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "BLACKPINK ROSÉ: Legends Tour", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111115") },
                    { new Guid("9d69b462-95c2-4f43-8f18-b7dd159ed0ea"), "Rosalía & Beyoncé", new DateTime(2028, 1, 13, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(8196), "Experience the magic of Rosalía & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Rosalía & Beyoncé: Farewell Tour", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111192") },
                    { new Guid("9e6b86c9-f022-4cbd-9712-09e2710c3c9f"), "Marshmello", new DateTime(2026, 1, 11, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(6586), "Join Marshmello for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Marshmello: Live at Home", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111148") },
                    { new Guid("9f764b14-b1f4-40f1-aaf4-36029e0c56bd"), "Katy Perry & Beyoncé", new DateTime(2027, 8, 28, 16, 41, 23, 401, DateTimeKind.Local).AddTicks(3060), "An unforgettable night with Katy Perry & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Katy Perry & Beyoncé: Stadium Tour", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111146") },
                    { new Guid("9fd2ac9a-97d7-46fc-a202-a8405a51f5aa"), "LISA & Beyoncé", new DateTime(2028, 5, 15, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(3048), "Join LISA & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "LISA & Beyoncé: Live at Home", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111133") },
                    { new Guid("9ff056e2-a8c9-4022-a3a4-d66243612b84"), "Imagine Dragons & Beyoncé", new DateTime(2027, 8, 25, 16, 41, 23, 401, DateTimeKind.Local).AddTicks(2928), "The electrifying Imagine Dragons & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Imagine Dragons & Beyoncé: Acoustic Night", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111145") },
                    { new Guid("a0dcc9b5-644a-44fd-ad5c-644e65d7af92"), "Olivia Rodrigo & Ed Sheeran", new DateTime(2026, 11, 16, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(7557), "An unforgettable night with Olivia Rodrigo & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Olivia Rodrigo & Ed Sheeran: Summer Festival", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111151") },
                    { new Guid("a18906c7-143f-428c-ba27-d1e1d507ea6c"), "Sia & Beyoncé", new DateTime(2027, 11, 2, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(1858), "Join Sia & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Sia & Beyoncé: Reunion Tour", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111168") },
                    { new Guid("a19e002b-846b-47e7-8080-b8d12bc24aa4"), "Harry Styles", new DateTime(2025, 10, 16, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(219), "Harry Styles returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Harry Styles: The Sessions", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111119") },
                    { new Guid("a1f4f5af-c68c-4612-9f8f-13a579186f92"), "The Script", new DateTime(2026, 8, 9, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(3300), "Join The Script for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "The Script: Reunion Tour", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111118") },
                    { new Guid("a2116da0-f676-4f82-b3b6-4dce94149fbf"), "Lil Uzi Vert & Beyoncé", new DateTime(2028, 2, 6, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(8942), "The electrifying Lil Uzi Vert & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Lil Uzi Vert & Beyoncé: The Experience", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111200") },
                    { new Guid("a2eb857b-fd49-40bc-a168-8a1917cd9f49"), "Lewis Capaldi & Beyoncé", new DateTime(2027, 10, 3, 16, 41, 23, 401, DateTimeKind.Local).AddTicks(8598), "Join Lewis Capaldi & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Lewis Capaldi & Beyoncé: Live at Home", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111158") },
                    { new Guid("a366b007-eaea-489d-a39c-74dec5c9d85a"), "Kehlani & Ed Sheeran", new DateTime(2027, 4, 9, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(3769), "Kehlani & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Kehlani & Ed Sheeran: The Sessions", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111199") },
                    { new Guid("a424f9db-95fc-4426-a386-ac3fed83ea85"), "Ed Sheeran", new DateTime(2026, 8, 15, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(3360), "The electrifying Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Ed Sheeran: The Experience", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111120") },
                    { new Guid("a4354e16-7356-4760-bb22-b36e30576173"), "SEVENTEEN & BTS", new DateTime(2029, 3, 2, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(3402), "The electrifying SEVENTEEN & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "SEVENTEEN & BTS: Legends Tour", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111130") },
                    { new Guid("a4a4fc4e-6b64-40d8-849c-65649047cb17"), "Katy Perry & Ed Sheeran", new DateTime(2026, 10, 8, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(4860), "Join Katy Perry & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Katy Perry & Ed Sheeran: Live at Home", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111138") },
                    { new Guid("a4fd4f3b-b034-4ca1-81d2-0062a826a36f"), "G-Eazy & BTS", new DateTime(2029, 2, 12, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(3128), "G-Eazy & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "G-Eazy & BTS: The Sessions", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111124") },
                    { new Guid("a4ff0c68-7e80-4843-b3cf-a828b7a6ae30"), "Zedd", new DateTime(2026, 7, 19, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(2707), "An unforgettable night with Zedd showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Zedd: Stadium Tour", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("a53e9ebd-048a-417b-84ca-5886f6605eab"), "Jack Harlow & BTS", new DateTime(2028, 11, 23, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7820), "Experience the magic of Jack Harlow & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Jack Harlow & BTS: Farewell Tour", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111197") },
                    { new Guid("a5722a86-7aed-485e-a437-a822df51c83f"), "Coldplay & Drake", new DateTime(2029, 5, 31, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(4499), "The electrifying Coldplay & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Coldplay & Drake: Legends Tour", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111160") },
                    { new Guid("a6d48e87-758d-4c10-a0be-9ba0b9c52792"), "Elton John & Ed Sheeran", new DateTime(2027, 1, 12, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(688), "The electrifying Elton John & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Elton John & Ed Sheeran: Acoustic Night", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111170") },
                    { new Guid("a75abc5e-dd2b-4cb8-9ab3-237293dd709b"), "Elton John & Drake", new DateTime(2029, 9, 10, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(9537), "Elton John & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Elton John & Drake: Greatest Hits Tour", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111194") },
                    { new Guid("a8b77c79-fc9b-4a77-b91c-88292efdfa19"), "Madison Beer & BTS", new DateTime(2029, 4, 1, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(3764), "The electrifying Madison Beer & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Madison Beer & BTS: Acoustic Night", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111140") },
                    { new Guid("a9936370-10c0-46a6-bc3a-a21c322ba80d"), "Demi Lovato & Ed Sheeran", new DateTime(2027, 3, 4, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(1347), "Experience the magic of Demi Lovato & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Demi Lovato & Ed Sheeran: Farewell Tour", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111187") },
                    { new Guid("aa864d6e-1f34-4dcf-920b-090a16e27237"), "Kehlani", new DateTime(2026, 5, 20, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(9509), "An unforgettable night with Kehlani showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Kehlani: Summer Festival", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111191") },
                    { new Guid("aba49a58-edfa-425a-bb43-244a5ffaa80b"), "The Chainsmokers & Drake", new DateTime(2029, 7, 21, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(8082), "Experience the magic of The Chainsmokers & Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "The Chainsmokers & Drake: Live in Concert", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111177") },
                    { new Guid("ac3b9132-894e-4166-8d6d-5d338f57194d"), "Lizzo & BTS", new DateTime(2028, 9, 12, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(6375), "Join Lizzo & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Lizzo & BTS: Reunion Tour", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111173") },
                    { new Guid("ac5891dd-529d-49ff-a0c3-54c5bff1abc6"), "Bad Bunny & Ed Sheeran", new DateTime(2026, 10, 23, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(5829), "Join Bad Bunny & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Bad Bunny & Ed Sheeran: Comeback Tour", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111143") },
                    { new Guid("ac594a77-f5d5-4ae8-9455-1d2f3333eba5"), "Ed Sheeran & BTS", new DateTime(2028, 5, 24, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(3148), "An unforgettable night with Ed Sheeran & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Ed Sheeran & BTS: Stadium Tour", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111136") },
                    { new Guid("ace3355b-c091-4416-b554-b2699d63fd65"), "Ed Sheeran & Drake", new DateTime(2029, 4, 13, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(3962), "Ed Sheeran & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Ed Sheeran & Drake: Anniversary Tour", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111144") },
                    { new Guid("ae375716-d411-42ce-96f3-eae7882dfb90"), "Ariana Grande & Drake", new DateTime(2029, 5, 13, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(4314), "Ariana Grande & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Ariana Grande & Drake: The Sessions", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111154") },
                    { new Guid("ae72633a-5370-464e-8e20-0f8688139fef"), "Jason Derulo & BTS", new DateTime(2029, 3, 8, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(3461), "Experience the magic of Jason Derulo & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Jason Derulo & BTS: Live in Concert", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111132") },
                    { new Guid("af0de038-3a69-42cc-84ae-99db6193f4f9"), "Rihanna & BTS", new DateTime(2028, 7, 8, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(4015), "An unforgettable night with Rihanna & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Rihanna & BTS: Stadium Tour", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111151") },
                    { new Guid("af1d311e-756f-458f-9a3c-2b18400f29be"), "Coldplay & BTS", new DateTime(2028, 7, 11, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(4053), "Experience the magic of Coldplay & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Coldplay & BTS: Farewell Tour", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111152") },
                    { new Guid("b0367e52-fe34-47e6-a16f-122787c6692c"), "Megan Thee Stallion & Ed Sheeran", new DateTime(2026, 12, 28, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(327), "The electrifying Megan Thee Stallion & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Megan Thee Stallion & Ed Sheeran: The Experience", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111165") },
                    { new Guid("b062eb9e-94b9-47a0-b750-87ab2439ca5e"), "Kendrick Lamar", new DateTime(2025, 11, 6, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(498), "An unforgettable night with Kendrick Lamar showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Kendrick Lamar: World Tour", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111126") },
                    { new Guid("b09d3873-e255-44af-bff3-722ef05a9505"), "5 Seconds of Summer", new DateTime(2026, 5, 8, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(9342), "Experience the magic of 5 Seconds of Summer in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "5 Seconds of Summer: Live in Concert", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111187") },
                    { new Guid("b20f5bdc-5e5b-4d9d-ba5b-31018a6190b6"), "Twenty One Pilots & Beyoncé", new DateTime(2027, 9, 27, 16, 41, 23, 401, DateTimeKind.Local).AddTicks(5611), "An unforgettable night with Twenty One Pilots & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Twenty One Pilots & Beyoncé: Summer Festival", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111156") },
                    { new Guid("b2193b98-e7b5-473e-97c0-3b59c68d26fe"), "Ariana Grande", new DateTime(2025, 10, 25, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(311), "Experience the magic of Ariana Grande in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Ariana Grande: Farewell Tour", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111122") },
                    { new Guid("b3bd42b6-e3f9-41e4-af1f-605192d8dab3"), "Demi Lovato", new DateTime(2026, 4, 14, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(9096), "Demi Lovato returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Demi Lovato: The Sessions", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111179") },
                    { new Guid("b4b053c6-5a44-4434-9d5f-80c4071ffa6d"), "Sam Smith & Drake", new DateTime(2029, 9, 19, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(9667), "Experience the magic of Sam Smith & Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Sam Smith & Drake: Unplugged", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111197") },
                    { new Guid("b4cab40a-a958-4fef-ae8a-ec4f55e2b0db"), "Niall Horan & BTS", new DateTime(2028, 11, 8, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7621), "Experience the magic of Niall Horan & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Niall Horan & BTS: Unplugged", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111192") },
                    { new Guid("b687b6a9-f1cd-443e-aaf2-8a8d23faabf1"), "Blackpink & BTS", new DateTime(2028, 9, 15, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(6704), "Blackpink & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Blackpink & BTS: Greatest Hits Tour", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111174") },
                    { new Guid("b6da21c0-41eb-4cf3-bf15-9bfac0c0473e"), "Camila Cabello & BTS", new DateTime(2028, 8, 7, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(5160), "An unforgettable night with Camila Cabello & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Camila Cabello & BTS: Summer Festival", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111161") },
                    { new Guid("b7127989-3164-44c8-9683-694b4d56094e"), "Calvin Harris & Ed Sheeran", new DateTime(2026, 11, 25, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(7649), "Calvin Harris & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Calvin Harris & Ed Sheeran: The Sessions", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111154") },
                    { new Guid("b75f4b7c-8178-4c6b-93db-7062b0586053"), "Halsey & Drake", new DateTime(2029, 7, 9, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(7007), "Join Halsey & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Halsey & Drake: Comeback Tour", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111173") },
                    { new Guid("b7f3c72b-808f-4ec5-acfb-7ea53788108f"), "Lauv", new DateTime(2026, 7, 25, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(2877), "Join Lauv for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Lauv: Comeback Tour", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111113") },
                    { new Guid("b969d8ef-7b56-4a5c-9f35-91382e9c1a91"), "Billie Eilish & BTS", new DateTime(2028, 6, 11, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(3393), "Experience the magic of Billie Eilish & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Billie Eilish & BTS: Live in Concert", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111142") },
                    { new Guid("bb80fac6-5824-4477-a439-3c8eee4dc8f2"), "Panic! At The Disco & BTS", new DateTime(2029, 1, 22, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(1472), "Experience the magic of Panic! At The Disco & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Panic! At The Disco & BTS: Live in Concert", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111117") },
                    { new Guid("bbb9fb83-2ec6-452f-88b0-36159e526981"), "Bad Bunny", new DateTime(2025, 12, 3, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(3665), "The electrifying Bad Bunny brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Bad Bunny: Acoustic Night", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111135") },
                    { new Guid("bc311068-3470-4bb9-9584-e4556f58ed36"), "Eminem & Ed Sheeran", new DateTime(2026, 10, 20, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(5193), "Experience the magic of Eminem & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Eminem & Ed Sheeran: Farewell Tour", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111142") },
                    { new Guid("bcd181f6-d65c-4cc4-b68f-a76850f9d03e"), "Kendrick Lamar & Ed Sheeran", new DateTime(2026, 9, 26, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(4681), "Kendrick Lamar & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Kendrick Lamar & Ed Sheeran: Greatest Hits Tour", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111134") },
                    { new Guid("bceba463-3e29-4c15-bf81-7656dfa01060"), "Coldplay & Ed Sheeran", new DateTime(2026, 10, 2, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(4755), "An unforgettable night with Coldplay & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Coldplay & Ed Sheeran: Summer Festival", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111136") },
                    { new Guid("bd5c7f60-a766-4e2a-9357-17b3b70239e0"), "Imagine Dragons & BTS", new DateTime(2028, 7, 14, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(4555), "Join Imagine Dragons & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Imagine Dragons & BTS: Comeback Tour", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111153") },
                    { new Guid("bd6c3f17-0735-46b1-9859-596f36db5cb7"), "Daddy Yankee & Drake", new DateTime(2029, 8, 8, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(8749), "Join Daddy Yankee & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Daddy Yankee & Drake: Live at Home", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111183") },
                    { new Guid("bd82a445-aee3-4e25-b64f-1eaf339441bd"), "Shawn Mendes", new DateTime(2025, 12, 6, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(4686), "An unforgettable night with Shawn Mendes showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Shawn Mendes: Stadium Tour", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111136") },
                    { new Guid("be38a1c2-d3b8-4ff8-9e7e-c1863eef6b55"), "The Chainsmokers & Ed Sheeran", new DateTime(2026, 11, 22, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(7619), "Join The Chainsmokers & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "The Chainsmokers & Ed Sheeran: Live at Home", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111153") },
                    { new Guid("bf1b2972-6d24-4bcf-a476-fd64ff86a3b6"), "Charlie Puth & Beyoncé", new DateTime(2027, 12, 8, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(5912), "The electrifying Charlie Puth & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Charlie Puth & Beyoncé: Legends Tour", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111180") },
                    { new Guid("bf5e1d5a-caf1-4916-95ca-d099200206bd"), "Travis Scott & Drake", new DateTime(2029, 6, 15, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(5032), "The electrifying Travis Scott & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Travis Scott & Drake: The Experience", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111165") },
                    { new Guid("bfbc6127-e6a6-466d-a2af-0e790deb1e32"), "Offset & Ed Sheeran", new DateTime(2027, 6, 2, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(8504), "Experience the magic of Offset & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Offset & Ed Sheeran: Farewell Tour", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111117") },
                    { new Guid("bfc240fd-db40-4dd2-8154-2db41d215694"), "Avicii & BTS", new DateTime(2029, 2, 24, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(3339), "Join Avicii & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Avicii & BTS: Comeback Tour", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111128") },
                    { new Guid("c11714c9-7c94-4b7e-93b2-1ddbe588e576"), "Harry Styles & Beyoncé", new DateTime(2027, 7, 26, 16, 41, 23, 400, DateTimeKind.Local).AddTicks(9160), "The electrifying Harry Styles & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Harry Styles & Beyoncé: Legends Tour", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111135") },
                    { new Guid("c13f634b-59de-4018-8798-6b8c9d66725f"), "OneRepublic", new DateTime(2026, 4, 20, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(9159), "An unforgettable night with OneRepublic showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "OneRepublic: Stadium Tour", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111181") },
                    { new Guid("c17691d8-f03b-41f4-ae31-2db027edf56b"), "The Kid LAROI & BTS", new DateTime(2028, 10, 3, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7212), "The electrifying The Kid LAROI & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "The Kid LAROI & BTS: Acoustic Night", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111180") },
                    { new Guid("c264b9d2-c22e-444c-adb9-f7b96e4b222e"), "Demi Lovato & Beyoncé", new DateTime(2028, 1, 22, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(8292), "The electrifying Demi Lovato & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Demi Lovato & Beyoncé: Legends Tour", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111195") },
                    { new Guid("c2b7049f-a0e1-4b51-9a24-418d80151f1e"), "Troye Sivan", new DateTime(2026, 6, 10, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(1279), "Join Troye Sivan for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Troye Sivan: Comeback Tour", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111198") },
                    { new Guid("c37d6d59-854e-4e0f-8a6b-71421e02ee67"), "Luke Combs & Beyoncé", new DateTime(2027, 12, 26, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(6787), "An unforgettable night with Luke Combs & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Luke Combs & Beyoncé: Summer Festival", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111186") },
                    { new Guid("c3b28038-0031-4f10-ac84-cc1500ccb34e"), "Olivia Rodrigo & BTS", new DateTime(2028, 8, 25, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(5985), "Experience the magic of Olivia Rodrigo & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Olivia Rodrigo & BTS: Farewell Tour", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111167") },
                    { new Guid("c3c922a1-cf21-441e-8cde-080dc9556db0"), "Young Thug & Ed Sheeran", new DateTime(2027, 6, 11, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(8887), "The electrifying Young Thug & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Young Thug & Ed Sheeran: Legends Tour", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111120") },
                    { new Guid("c3e1da30-f5ba-4eba-a94c-c6155266ecc2"), "Kygo & Ed Sheeran", new DateTime(2027, 1, 3, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(399), "Experience the magic of Kygo & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Kygo & Ed Sheeran: Unplugged", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111167") },
                    { new Guid("c41a3fba-c35a-40ce-95f7-9a44b305a968"), "Nicky Jam & Beyoncé", new DateTime(2028, 3, 13, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(966), "Experience the magic of Nicky Jam & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Nicky Jam & Beyoncé: Live in Concert", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111112") },
                    { new Guid("c42f0195-80cf-4605-a54d-91da1f5db75b"), "David Guetta & Beyoncé", new DateTime(2027, 11, 29, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(5207), "Experience the magic of David Guetta & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "David Guetta & Beyoncé: Farewell Tour", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111177") },
                    { new Guid("c6fbf06d-0907-4c55-be55-fb9735ddb026"), "Travis Scott & Beyoncé", new DateTime(2027, 9, 6, 16, 41, 23, 401, DateTimeKind.Local).AddTicks(3416), "Travis Scott & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Travis Scott & Beyoncé: Anniversary Tour", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111149") },
                    { new Guid("c7a60561-d2dd-462b-93f3-2fa4471123df"), "Sia", new DateTime(2026, 1, 23, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8131), "Experience the magic of Sia in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Sia: Farewell Tour", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111152") },
                    { new Guid("c9b22085-72b0-436e-80bf-0dda62e176fc"), "Maluma & Ed Sheeran", new DateTime(2027, 2, 20, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(1218), "Join Maluma & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Maluma & Ed Sheeran: Live at Home", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111183") },
                    { new Guid("ca4f5edd-19d6-4528-890d-86223ee4cc8b"), "Dan + Shay & BTS", new DateTime(2029, 2, 15, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(3160), "The electrifying Dan + Shay & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Dan + Shay & BTS: Acoustic Night", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111125") },
                    { new Guid("cacfee95-91fc-4471-8308-86095b408f40"), "Maluma & Beyoncé", new DateTime(2028, 1, 10, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(8156), "An unforgettable night with Maluma & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Maluma & Beyoncé: Stadium Tour", 159.99m, 159.99m, new Guid("11111111-1111-1111-1111-111111111191") },
                    { new Guid("cc9fab61-370a-4ee6-9888-31bf7b4bb928"), "Meghan Trainor & BTS", new DateTime(2029, 2, 18, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(3275), "An unforgettable night with Meghan Trainor & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Meghan Trainor & BTS: Stadium Tour", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111126") },
                    { new Guid("cd44fb3a-b13e-4ccb-a5e0-7b0c3bd93e78"), "Imagine Dragons & Ed Sheeran", new DateTime(2026, 10, 5, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(4790), "Experience the magic of Imagine Dragons & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Imagine Dragons & Ed Sheeran: Unplugged", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111137") },
                    { new Guid("cd7c85a1-4cf9-4165-97a8-bee6e21a4fe9"), "Camila Cabello & Drake", new DateTime(2029, 6, 27, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(5982), "Camila Cabello & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Camila Cabello & Drake: The Sessions", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111169") },
                    { new Guid("cddf422b-d92b-4896-88f6-47b4a37a03c6"), "Doja Cat & Ed Sheeran", new DateTime(2026, 11, 1, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(6714), "An unforgettable night with Doja Cat & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Doja Cat & Ed Sheeran: World Tour", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111146") },
                    { new Guid("ce4ff7a2-ee0f-48aa-82f1-d4f5d022b31f"), "Young Thug & Beyoncé", new DateTime(2028, 4, 30, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(1854), "Join Young Thug & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Young Thug & Beyoncé: Reunion Tour", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111128") },
                    { new Guid("cf2106ab-a3c0-4b7f-8dcc-b353d0b287d3"), "Coldplay & Beyoncé", new DateTime(2027, 8, 22, 16, 41, 23, 401, DateTimeKind.Local).AddTicks(2820), "Coldplay & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Coldplay & Beyoncé: The Sessions", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111144") },
                    { new Guid("cf75b460-ebec-472d-b93e-8d288f075028"), "David Guetta & Drake", new DateTime(2029, 9, 7, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(9505), "Join David Guetta & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "David Guetta & Drake: Reunion Tour", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111193") },
                    { new Guid("cfce4db6-3c5a-4ed4-9db5-5f3981fde920"), "The Kid LAROI & Ed Sheeran", new DateTime(2026, 12, 25, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(233), "The Kid LAROI & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "The Kid LAROI & Ed Sheeran: Greatest Hits Tour", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111164") },
                    { new Guid("d015353b-7256-42c4-bb7f-244d9f7177df"), "NCT 127 & Beyoncé", new DateTime(2028, 4, 3, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(1231), "NCT 127 & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "NCT 127 & Beyoncé: The Sessions", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111119") },
                    { new Guid("d066a8d8-aede-4b51-a8ae-e4fa14433034"), "Alan Walker & Ed Sheeran", new DateTime(2027, 3, 7, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(1420), "Join Alan Walker & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Alan Walker & Ed Sheeran: Comeback Tour", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111188") },
                    { new Guid("d08d0223-5efc-46c8-acd1-4659941cd9cc"), "The Weeknd & Drake", new DateTime(2029, 4, 28, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(4117), "The Weeknd & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "The Weeknd & Drake: Greatest Hits Tour", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111149") },
                    { new Guid("d1068b6e-b611-4e7d-a95d-22ffb8b665dd"), "Tones and I & Ed Sheeran", new DateTime(2027, 2, 26, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(1281), "The electrifying Tones and I & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Tones and I & Ed Sheeran: Acoustic Night", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111185") },
                    { new Guid("d161ec42-f610-4937-a1a4-cae6a3ef1157"), "Taylor Swift & Beyoncé", new DateTime(2027, 7, 2, 16, 41, 23, 399, DateTimeKind.Local).AddTicks(1322), "Experience the magic of Taylor Swift & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Taylor Swift & Beyoncé: Unplugged", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111127") },
                    { new Guid("d376d318-ac5c-4ab6-bb7d-fcfed6aec8e9"), "The Kid LAROI & Drake", new DateTime(2029, 8, 23, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(9343), "Join The Kid LAROI & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "The Kid LAROI & Drake: Comeback Tour", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111188") },
                    { new Guid("d42cb771-db0e-4558-a4d0-8b737d23dae9"), "The Script & BTS", new DateTime(2029, 4, 7, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(3830), "Experience the magic of The Script & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "The Script & BTS: Farewell Tour", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111142") },
                    { new Guid("d458de3d-a6c9-47fb-aaec-8563d8310888"), "Tones and I & Beyoncé", new DateTime(2028, 1, 16, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(8229), "Join Tones and I & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Tones and I & Beyoncé: Comeback Tour", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111193") },
                    { new Guid("d55fe24e-460b-41aa-a2ea-6d8b547232b0"), "Future & BTS", new DateTime(2028, 9, 30, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7180), "Future & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Future & BTS: The Sessions", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111179") },
                    { new Guid("d6d49c07-fb43-4c6d-b814-8d100f741195"), "Blackpink & Beyoncé", new DateTime(2027, 10, 27, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(1586), "An unforgettable night with Blackpink & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Blackpink & Beyoncé: World Tour", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111166") },
                    { new Guid("d8c0e86e-0c4a-40c8-9ae0-70c59bb5b3ac"), "Cardi B & Beyoncé", new DateTime(2027, 9, 24, 16, 41, 23, 401, DateTimeKind.Local).AddTicks(5426), "The electrifying Cardi B & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Cardi B & Beyoncé: The Experience", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111155") },
                    { new Guid("d93fcc93-fc6f-43be-8ae5-784bc9d99db4"), "Halsey & BTS", new DateTime(2028, 8, 19, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(5585), "The electrifying Halsey & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Halsey & BTS: Acoustic Night", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111165") },
                    { new Guid("d9a64361-e7d1-46cd-8198-3e7b6453e2e8"), "Zedd & Beyoncé", new DateTime(2028, 4, 27, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(1819), "Experience the magic of Zedd & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Zedd & Beyoncé: Live in Concert", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111127") },
                    { new Guid("daa53a76-44c3-40f3-bbc9-2c05ac20e42f"), "SZA & Beyoncé", new DateTime(2027, 10, 18, 16, 41, 23, 401, DateTimeKind.Local).AddTicks(9542), "Join SZA & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "SZA & Beyoncé: Comeback Tour", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111163") },
                    { new Guid("db062a75-8a93-40bf-b043-59d1397a73c9"), "Meghan Trainor & Beyoncé", new DateTime(2028, 3, 31, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(1199), "Join Meghan Trainor & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Meghan Trainor & Beyoncé: Live at Home", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111118") },
                    { new Guid("db79d7ce-f5f0-4323-bc0c-6a9f9c76550e"), "KAROL G & Ed Sheeran", new DateTime(2027, 3, 16, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(1695), "An unforgettable night with KAROL G & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "KAROL G & Ed Sheeran: World Tour", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111191") },
                    { new Guid("dbc78dff-f6af-4cda-a95e-7d9dc7944ab9"), "Daddy Yankee & BTS", new DateTime(2028, 9, 18, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(6994), "The electrifying Daddy Yankee & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Daddy Yankee & BTS: The Experience", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111175") },
                    { new Guid("dc463b4f-b67e-4fe5-a293-e1ce8834411d"), "Khalid & BTS", new DateTime(2028, 10, 24, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7471), "Experience the magic of Khalid & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Khalid & BTS: Live in Concert", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111187") },
                    { new Guid("dd4a4fc4-edf9-48fd-8359-a8b17cd78413"), "Doja Cat & BTS", new DateTime(2028, 8, 10, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(5198), "Experience the magic of Doja Cat & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Doja Cat & BTS: Unplugged", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111162") },
                    { new Guid("dd7bc611-cde9-48b6-8f0f-e3623f7cad4d"), "Rosalía", new DateTime(2026, 4, 5, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8959), "An unforgettable night with Rosalía showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Rosalía: Summer Festival", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111176") },
                    { new Guid("dd9338de-b46b-4af1-850e-77965d256c89"), "Charlie Puth & BTS", new DateTime(2028, 10, 27, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7500), "Join Charlie Puth & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Charlie Puth & BTS: Reunion Tour", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111188") },
                    { new Guid("ddb9ecd0-c748-4c83-9482-96d72f9b807f"), "Offset & BTS", new DateTime(2029, 3, 11, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(3490), "Join Offset & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Offset & BTS: Reunion Tour", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111133") },
                    { new Guid("ddd98668-0d94-43d1-8ad2-c332a3502ff1"), "Sia & Ed Sheeran", new DateTime(2026, 12, 13, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(8937), "The electrifying Sia & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Sia & Ed Sheeran: Legends Tour", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111160") },
                    { new Guid("de0a6dad-cfdf-4aed-a5ee-40c26c59cd8c"), "Fall Out Boy & Beyoncé", new DateTime(2028, 4, 9, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(1294), "An unforgettable night with Fall Out Boy & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Fall Out Boy & Beyoncé: Stadium Tour", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111121") },
                    { new Guid("dedc6626-a402-4875-9a5f-97d6b84e820e"), "Selena Gomez", new DateTime(2026, 1, 26, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8170), "Join Selena Gomez for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Selena Gomez: Comeback Tour", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111153") },
                    { new Guid("dee6b3a5-ac2b-4359-b257-93e099f471f0"), "Twenty One Pilots & Ed Sheeran", new DateTime(2026, 11, 7, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(7449), "Join Twenty One Pilots & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Twenty One Pilots & Ed Sheeran: Reunion Tour", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111148") },
                    { new Guid("df50c55a-4c68-4426-8218-bc2da1895256"), "Olivia Rodrigo", new DateTime(2025, 12, 27, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(5861), "Join Olivia Rodrigo for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Olivia Rodrigo: Reunion Tour", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111143") },
                    { new Guid("e115505d-7885-45ca-a1a0-dcdf722fb34c"), "Maluma & BTS", new DateTime(2028, 11, 29, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7881), "Maluma & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Maluma & BTS: Anniversary Tour", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111199") },
                    { new Guid("e13e259b-601d-4477-8dde-d73973bc9c42"), "Anne-Marie & BTS", new DateTime(2029, 3, 14, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(3570), "Anne-Marie & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Anne-Marie & BTS: Greatest Hits Tour", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111134") },
                    { new Guid("e14156bc-add2-497c-b6b3-ead0ef9c7967"), "YUNGBLUD & Ed Sheeran", new DateTime(2027, 4, 6, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(3044), "Join YUNGBLUD & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "YUNGBLUD & Ed Sheeran: Live at Home", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111198") },
                    { new Guid("e144d787-ec4e-46fd-aad3-d1e3cb2c59fb"), "Lil Nas X & Drake", new DateTime(2029, 7, 18, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(7821), "An unforgettable night with Lil Nas X & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Lil Nas X & Drake: World Tour", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111176") },
                    { new Guid("e1c702e7-0158-4343-9dbe-0e861874fba7"), "Drake & Ed Sheeran", new DateTime(2026, 8, 24, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(3703), "Join Drake & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Drake & Ed Sheeran: Live at Home", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111123") },
                    { new Guid("e1e3a126-f040-4eaa-acef-4a7b7300a2a6"), "Zedd & BTS", new DateTime(2029, 3, 17, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(3607), "The electrifying Zedd & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Zedd & BTS: The Experience", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111135") },
                    { new Guid("e20fcdfa-fb01-469c-bf44-94a8df1f98ba"), "G-Eazy", new DateTime(2026, 6, 16, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(1445), "The electrifying G-Eazy brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "G-Eazy: Legends Tour", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111200") },
                    { new Guid("e2354dee-0fd1-4e09-bdde-e81f147a3abb"), "The Kid LAROI", new DateTime(2026, 2, 4, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8256), "An unforgettable night with The Kid LAROI showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "The Kid LAROI: World Tour", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111156") },
                    { new Guid("e2cfc41c-1638-47e2-9ca8-db94e9aa6d20"), "The Weeknd & Ed Sheeran", new DateTime(2026, 8, 30, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(4109), "The electrifying The Weeknd & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "The Weeknd & Ed Sheeran: Acoustic Night", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111125") },
                    { new Guid("e3b0af93-e22a-452c-a52e-160406b24c56"), "Ariana Grande & Ed Sheeran", new DateTime(2026, 9, 14, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(4475), "The electrifying Ariana Grande & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Ariana Grande & Ed Sheeran: Legends Tour", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111130") },
                    { new Guid("e611b38d-da14-4a2f-97bc-0cc950765557"), "Nicky Jam", new DateTime(2026, 6, 4, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(1048), "An unforgettable night with Nicky Jam showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Nicky Jam: Stadium Tour", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111196") },
                    { new Guid("e61b97c3-f148-48fa-b020-c257597228a6"), "OneRepublic & Ed Sheeran", new DateTime(2027, 3, 10, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(1451), "OneRepublic & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "OneRepublic & Ed Sheeran: Anniversary Tour", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111189") },
                    { new Guid("e6f7a428-ed61-4c0c-84dc-43a6516f58ef"), "Camila Cabello & Ed Sheeran", new DateTime(2026, 10, 29, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(6575), "The electrifying Camila Cabello & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Camila Cabello & Ed Sheeran: Legends Tour", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111145") },
                    { new Guid("e79fecbd-d012-4238-92de-1a1c6bec070d"), "Future & Drake", new DateTime(2029, 8, 20, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(9309), "Experience the magic of Future & Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Future & Drake: Farewell Tour", 29.99m, 29.99m, new Guid("11111111-1111-1111-1111-111111111187") },
                    { new Guid("e7ed26f6-fe09-4d73-8bac-883fb1e1de18"), "Little Mix", new DateTime(2026, 5, 14, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(9445), "Little Mix returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Little Mix: Greatest Hits Tour", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111189") },
                    { new Guid("e82e844f-6b53-4dc3-845b-cb5c3515bd2e"), "DaBaby & Ed Sheeran", new DateTime(2027, 2, 8, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(1085), "DaBaby & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "DaBaby & Ed Sheeran: Greatest Hits Tour", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111179") },
                    { new Guid("e87a16a6-ab92-4199-9f18-2fbcda16a5c8"), "Doja Cat", new DateTime(2025, 12, 12, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(4893), "Join Doja Cat for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Doja Cat: Comeback Tour", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111138") },
                    { new Guid("e8e76c04-b8f2-453c-97c2-335272c23b80"), "Daddy Yankee & Beyoncé", new DateTime(2027, 10, 30, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(1815), "Experience the magic of Daddy Yankee & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Daddy Yankee & Beyoncé: Live in Concert", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111167") },
                    { new Guid("e8e7e932-f94e-4f8e-a530-ddd97d5107e3"), "Avicii & Beyoncé", new DateTime(2028, 4, 6, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(1262), "The electrifying Avicii & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Avicii & Beyoncé: Acoustic Night", 69.99m, 69.99m, new Guid("11111111-1111-1111-1111-111111111120") },
                    { new Guid("e8ff8090-65b2-4cd6-977d-3481725e88d3"), "Justin Bieber", new DateTime(2025, 10, 22, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(278), "An unforgettable night with Justin Bieber showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Justin Bieber: Stadium Tour", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111121") },
                    { new Guid("ea28d4f7-f77c-402d-81af-76c43e559710"), "Future", new DateTime(2026, 2, 1, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8229), "The electrifying Future brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Future: Legends Tour", 79.99m, 79.99m, new Guid("11111111-1111-1111-1111-111111111155") },
                    { new Guid("ea3547c2-80d3-4ee1-9835-1d62c0900294"), "Harry Styles & Drake", new DateTime(2029, 5, 4, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(4179), "An unforgettable night with Harry Styles & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Harry Styles & Drake: Summer Festival", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111151") },
                    { new Guid("ead13691-8b74-4e2a-bfee-c0792d80e8de"), "Alan Walker & Beyoncé", new DateTime(2028, 1, 25, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(8325), "An unforgettable night with Alan Walker & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Alan Walker & Beyoncé: World Tour", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111196") },
                    { new Guid("eaddba00-98b1-4b27-88f8-b40c77ea15c3"), "Coldplay", new DateTime(2025, 11, 12, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(1692), "Join Coldplay for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Coldplay: Reunion Tour", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111128") },
                    { new Guid("eaf04090-9180-402d-a8fe-17590ee399fb"), "Tiësto", new DateTime(2026, 5, 2, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(9282), "The electrifying Tiësto brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Tiësto: Legends Tour", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111185") },
                    { new Guid("eb03c361-eab5-4391-a854-6697deccd009"), "Twenty One Pilots & BTS", new DateTime(2028, 8, 16, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(5536), "Twenty One Pilots & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Twenty One Pilots & BTS: The Sessions", 129.99m, 129.99m, new Guid("11111111-1111-1111-1111-111111111164") },
                    { new Guid("eb8736a9-def7-4e59-97e0-fefff04f2807"), "Little Mix & BTS", new DateTime(2029, 1, 10, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(153), "Join Little Mix & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Little Mix & BTS: Comeback Tour", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111113") },
                    { new Guid("ebd52893-f511-40ea-a186-282437c57edb"), "Ava Max & Beyoncé", new DateTime(2027, 12, 23, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(6647), "The electrifying Ava Max & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Ava Max & Beyoncé: The Experience", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111185") },
                    { new Guid("ec059ff7-faab-43e3-bb38-a85bebcf4c19"), "Sam Smith & Ed Sheeran", new DateTime(2027, 1, 21, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(854), "Join Sam Smith & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Sam Smith & Ed Sheeran: Comeback Tour", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111173") },
                    { new Guid("ec940211-3cd3-4159-b9c2-8df01e39f101"), "Nicky Jam & BTS", new DateTime(2029, 1, 31, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(2874), "The electrifying Nicky Jam & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Nicky Jam & BTS: The Experience", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111120") },
                    { new Guid("ed268b8a-4227-4df7-b2f1-80953562449d"), "Beyoncé & BTS", new DateTime(2028, 5, 27, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(3185), "Experience the magic of Beyoncé & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Beyoncé & BTS: Farewell Tour", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111137") },
                    { new Guid("ed488eea-f0ad-422e-96ef-ab2acc874ada"), "Jason Derulo & Ed Sheeran", new DateTime(2027, 5, 30, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(8471), "An unforgettable night with Jason Derulo & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Jason Derulo & Ed Sheeran: Stadium Tour", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111116") },
                    { new Guid("ed76f782-3e32-468b-a690-1be36d706d79"), "Travis Scott & BTS", new DateTime(2028, 7, 26, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(4721), "Experience the magic of Travis Scott & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Travis Scott & BTS: Live in Concert", 59.99m, 59.99m, new Guid("11111111-1111-1111-1111-111111111157") },
                    { new Guid("ede308b2-7478-447b-8e03-2419dc91aea2"), "Troye Sivan & Beyoncé", new DateTime(2028, 3, 19, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(1028), "Troye Sivan & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Troye Sivan & Beyoncé: Greatest Hits Tour", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111114") },
                    { new Guid("ee292f11-429d-4cff-8d75-a1c0978e06cd"), "Ariana Grande & BTS", new DateTime(2028, 6, 23, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(3540), "An unforgettable night with Ariana Grande & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Ariana Grande & BTS: Summer Festival", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111146") },
                    { new Guid("efbf33eb-86fa-478f-ae46-b0fde7deaf9f"), "Rosalía & Ed Sheeran", new DateTime(2027, 2, 23, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(1250), "Rosalía & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Rosalía & Ed Sheeran: The Sessions", 39.99m, 39.99m, new Guid("11111111-1111-1111-1111-111111111184") },
                    { new Guid("efe1f0bf-b454-4a36-9951-dd80e58c9e59"), "Blackpink & Drake", new DateTime(2029, 8, 5, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(8564), "Experience the magic of Blackpink & Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Blackpink & Drake: Unplugged", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111182") },
                    { new Guid("eff32098-12b7-432f-9cab-7fc1f8520846"), "Bad Bunny & Drake", new DateTime(2029, 6, 21, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(5556), "Experience the magic of Bad Bunny & Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Bad Bunny & Drake: Unplugged", 19.99m, 19.99m, new Guid("11111111-1111-1111-1111-111111111167") },
                    { new Guid("f0c5f7a6-8088-4498-acaa-319028d8c45f"), "Jason Derulo & Beyoncé", new DateTime(2028, 4, 18, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(1709), "Jason Derulo & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Jason Derulo & Beyoncé: Anniversary Tour", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111124") },
                    { new Guid("f110016c-16a9-4d8f-a712-f4554e6e66c3"), "Lady Gaga & Ed Sheeran", new DateTime(2026, 9, 8, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(4357), "Join Lady Gaga & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Lady Gaga & Ed Sheeran: Comeback Tour", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111128") },
                    { new Guid("f1d511a5-a6c2-4bd9-beb7-94a3826034fe"), "Miley Cyrus & BTS", new DateTime(2028, 10, 15, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7378), "Miley Cyrus & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Miley Cyrus & BTS: Anniversary Tour", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111184") },
                    { new Guid("f41ac576-de26-4ab2-935a-6aa020423d1d"), "Charlie Puth & Ed Sheeran", new DateTime(2027, 1, 18, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(824), "Experience the magic of Charlie Puth & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Charlie Puth & Ed Sheeran: Farewell Tour", 109.99m, 109.99m, new Guid("11111111-1111-1111-1111-111111111172") },
                    { new Guid("f5df0a70-6402-4a3a-b031-09ae318924cc"), "Alicia Keys", new DateTime(2026, 5, 5, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(9311), "An unforgettable night with Alicia Keys showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Alicia Keys: World Tour", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111186") },
                    { new Guid("f6a2aac3-db38-43ae-b19a-8bb42a200261"), "Travis Scott", new DateTime(2025, 11, 27, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(3245), "Join Travis Scott for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Travis Scott: Live at Home", 49.99m, 49.99m, new Guid("11111111-1111-1111-1111-111111111133") },
                    { new Guid("f717f318-b312-479c-8cb3-5e90a8c88265"), "Maluma", new DateTime(2026, 4, 2, 16, 41, 23, 396, DateTimeKind.Local).AddTicks(8929), "The electrifying Maluma brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Maluma: The Experience", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111175") },
                    { new Guid("f837875e-31b9-4058-96d7-3591b1a62af3"), "Anitta", new DateTime(2026, 6, 7, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(1143), "Experience the magic of Anitta in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Anitta: Farewell Tour", 119.99m, 119.99m, new Guid("11111111-1111-1111-1111-111111111197") },
                    { new Guid("f8469e38-495b-4e5c-ab2a-0d2ce3f18cbe"), "Martin Garrix & BTS", new DateTime(2028, 11, 2, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(7558), "The electrifying Martin Garrix & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Martin Garrix & BTS: The Experience", 199.99m, 199.99m, new Guid("11111111-1111-1111-1111-111111111190") },
                    { new Guid("f8ab0574-dcc8-4207-b680-be8866301d85"), "Dua Lipa & BTS", new DateTime(2028, 7, 2, 16, 41, 23, 403, DateTimeKind.Local).AddTicks(3946), "Dua Lipa & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Dua Lipa & BTS: The Sessions", 169.99m, 169.99m, new Guid("11111111-1111-1111-1111-111111111149") },
                    { new Guid("f9b17957-d7c9-402e-aec7-81a91a500e44"), "Alicia Keys & Ed Sheeran", new DateTime(2027, 3, 25, 16, 41, 23, 398, DateTimeKind.Local).AddTicks(2046), "Alicia Keys & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Alicia Keys & Ed Sheeran: Greatest Hits Tour", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111194") },
                    { new Guid("fa3962f1-0995-4c18-b2b2-2b49da2ce327"), "Mabel", new DateTime(2026, 6, 13, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(1406), "Mabel returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Mabel: Anniversary Tour", 139.99m, 139.99m, new Guid("11111111-1111-1111-1111-111111111199") },
                    { new Guid("fa6dba4b-42db-47ef-b24f-9591c5fc3b2d"), "James Arthur", new DateTime(2026, 7, 28, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(2969), "James Arthur returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "James Arthur: Anniversary Tour", 99.99m, 99.99m, new Guid("11111111-1111-1111-1111-111111111114") },
                    { new Guid("fb3c5b61-df0c-4c70-b96a-1eb2f8effa66"), "Lizzo & Beyoncé", new DateTime(2027, 10, 24, 16, 41, 23, 402, DateTimeKind.Local).AddTicks(1330), "The electrifying Lizzo & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Lizzo & Beyoncé: Legends Tour", 89.99m, 89.99m, new Guid("11111111-1111-1111-1111-111111111165") },
                    { new Guid("fc961d97-f6e1-4315-95ed-1f7aa3bf9733"), "Taylor Swift", new DateTime(2026, 8, 12, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(3329), "Taylor Swift returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Taylor Swift: Greatest Hits Tour", 149.99m, 149.99m, new Guid("11111111-1111-1111-1111-111111111119") },
                    { new Guid("fdae2d92-301e-429f-9254-2e71521ca95f"), "Travis Scott & Ed Sheeran", new DateTime(2026, 10, 17, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(5153), "An unforgettable night with Travis Scott & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Travis Scott & Ed Sheeran: Stadium Tour", 179.99m, 179.99m, new Guid("11111111-1111-1111-1111-111111111141") },
                    { new Guid("ff619f44-4729-4175-889c-d61567ff5ca2"), "Selena Gomez & Ed Sheeran", new DateTime(2026, 12, 16, 16, 41, 23, 397, DateTimeKind.Local).AddTicks(9055), "An unforgettable night with Selena Gomez & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Selena Gomez & Ed Sheeran: World Tour", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111161") },
                    { new Guid("ff7072e3-9686-4f7d-b74e-cc61da8d854c"), "Sia & Drake", new DateTime(2029, 8, 11, 16, 41, 23, 404, DateTimeKind.Local).AddTicks(8877), "Sia & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Sia & Drake: The Sessions", 189.99m, 189.99m, new Guid("11111111-1111-1111-1111-111111111184") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_VenueId",
                table: "Events",
                column: "VenueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Venues_VenueId",
                table: "Events",
                column: "VenueId",
                principalTable: "Venues",
                principalColumn: "VenueId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Venues_VenueId",
                table: "Events");

            migrationBuilder.DropTable(
                name: "Venues");

            migrationBuilder.DropIndex(
                name: "IX_Events_VenueId",
                table: "Events");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0028174e-6305-46f6-b173-a2d95b4ccaf0"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("00ad5387-e123-405f-b24d-3114a2fa30df"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0159656d-f1cd-4099-8b55-b4189273ea35"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("015f3a6c-d669-4f56-916f-0365301616d0"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("022904de-ee8b-4ae1-b537-f8e889f6db54"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("022da06f-6fc9-4189-bdbc-a6759140f3ce"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("03b3bba4-5aa2-4c08-8842-2c5870bcbb0c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("03c893ba-c32e-4921-9558-3c599b80027a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("03cc5eae-c6c2-450b-897f-c703d18ae7c9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("04713fca-7c28-4106-9167-f99fabeafb0c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("04c70f9e-c00f-4ca6-a7e6-f8f7ed5ade62"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("051d5ce2-3f7a-4c26-b6a9-52e3e30d0c64"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("05472854-24e9-4310-9000-6291e336a3fa"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("05f90115-23ae-4165-aa5e-896e600c42e9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("06a6162d-b0ed-41d3-acad-9766a5872dce"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("06c22707-23a0-4855-bd80-763a18925ede"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("06c9d072-0153-4181-a1ce-a6c1f06a81e5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("07303f77-a5b4-4191-ad75-517f867cb744"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("078f9972-c8aa-4e6e-8172-4ec50cdd551d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("094cf581-69a2-4e9c-8371-dda33e0feacf"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("09d4f4ba-353c-40ef-b680-328e2af6b99f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0ab355f7-95f8-4586-9d7d-13fb6be76419"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0b217949-cd17-4141-94a5-23434c5acc28"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0b69d81c-bc41-4fa6-a57c-8801f5cebe25"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0b76b04f-213b-4764-9f42-a238afa31837"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0beb5562-ef5c-43ac-8b22-ba9975de96fe"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0c0f9c53-8b38-4032-8a8f-c3f485f17751"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0d6d839d-7dbe-47cb-b8f5-1888fb94e775"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0f4db768-af85-441a-9d2e-2d04b0ea4d8a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0f5a5cc8-dc1e-4240-9773-49eed96a205d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0f607a40-89cc-4d52-8d5e-f30e76c72468"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("0fa65934-349d-49de-82af-42208fc1a4c2"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("11f57d27-274f-4ec8-90b5-4fa0e15254ba"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("12172636-2ff3-4a5e-a69b-923a3806da64"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("12f00315-797d-4b49-9479-bd51b489ad2c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("131eb2da-231e-437b-a376-ce2504186768"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("143fe96a-035f-4b11-8c91-bfc89ecfbbd7"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("14618079-bb43-4448-8eca-c4a2b85c77d8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("15bbeb71-8810-4eb4-b0b9-e0b1117fce8a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("181de9fc-32c5-48ba-b27e-945ce4fda0f5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("18609045-f6fc-4640-835d-0e990ba19993"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1875819f-c609-4e07-a484-633b77296595"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("18a425d2-a6f1-485a-a8ff-796cef559a95"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("18cdb2d3-8b36-4477-b795-325c2d112a0c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("19bb40ac-3895-40ac-9a1c-47b594305504"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1abc7dbb-67e1-474e-8269-e82bc2259c11"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1aca8e0f-5042-4fc0-882a-c3d421962aab"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1ad75aeb-07f9-4db0-85e7-ac237cdfee3d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1b466c2e-6837-45e4-b879-33a5d857e871"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1b4b7758-dc5b-4014-bd61-436b7ca476f2"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1c44c487-4a06-433a-8d6d-17404e7f1015"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1db8d8f6-ac14-49a8-896d-bab9edc1dcea"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1e6d3efa-729a-4f72-b4e6-41ed62ecaf92"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1f4155c4-8d9c-4225-9919-5d5ea499da96"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2052580f-78a0-4ed4-ae10-852e058ec6d8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("20b0199a-6fdf-4d8b-9178-90d34db74f50"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("20f77fa0-34e4-4d30-953c-e35bf17c4c61"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("211ad54a-7d0b-4131-a91e-d4528bc6fc6e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("220a777c-0324-4f1a-913d-c403f1f1a248"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("222bc22a-f435-4583-bf11-f01957d1a420"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("22302f72-d03b-4458-9719-13c9523c6a5a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("226ab9f8-3f36-4033-9239-1b8de2caf0d2"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2353992d-5130-4630-a5f7-6d9647a32e1b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2355549e-98b2-4a0b-818f-556bd88cea7c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2376f3b2-5adc-40c7-ad17-ff6746c5aa35"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("238b127f-367a-469f-8986-df4d41ac7e24"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("23a2667b-e45f-4234-9bd6-159f252ef24b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("244e889e-bdc5-46ca-ae00-bff02feebebe"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("245f8670-23d4-4e51-b2b5-a65b79c81802"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("24d2abe1-0f45-4719-a46f-0b7a9a217fb0"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("24d5f634-85f2-462f-9335-320fce15a7f1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("253df387-29c1-426a-9229-231e9e1d2a1c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("254528a8-647c-4e06-89da-8e571e727c79"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("25860718-edae-4c5e-9fa1-31193ba7e79e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("260727a0-a700-4e09-a714-2aa5b7829ddc"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("260c0324-274a-40e3-90ab-c96171690d13"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("28227ba9-fd96-4fba-b013-76a7fbbf54fc"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("28a0e493-178c-48a0-a9cc-04960c72c955"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("28b0ede5-bed7-4a00-8e55-07687b689cee"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2a89e10b-1048-4c87-a6d9-9332b97f3555"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2afa95fb-dfd2-43dd-8c28-c12870a843fa"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2b157a36-235a-429d-895d-dcccb6dafade"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2b34d8cf-0a69-4f86-af2b-87ffd2e5e74d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2c0e7469-2111-4837-b965-e03b8644d02a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2c892bd1-2490-4f7c-a87e-3eac6cd7fdbe"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2e2c216c-2829-4dad-9e23-ced8612d032a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2ee0e329-1f23-4a0c-ad96-2dd540a07964"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2f11a29a-40fb-4dbc-a526-e8523a4b271e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2f7fa6e1-c2f6-4076-9116-d11975bd55cf"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2fb19ce5-8a95-4dbc-a2ef-6b9647df5744"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("2ff537cd-8af4-475e-b582-da48fe7b0002"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("30aaa606-94cf-44f2-bec2-72fc74d94167"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("31ac7a0e-7c3f-4d29-89de-65e38ae5b293"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("32010720-b626-42f5-a288-ac1a1b1fb59d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3289175f-2a4f-477e-95c6-b7e81377d071"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3291970c-c091-48d0-8e5a-f8df8ff634e3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3375b7d0-32cc-471a-a090-7279ead43074"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("345152aa-4915-496f-8c7b-b08508df2e1d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("34b90c63-46bb-4164-b74e-40a0c4c94aec"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3569e103-a0be-4afc-99cc-a69886c68bdb"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("36405785-e8d8-4c95-97fb-4c40089745b6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("36a70e3d-cd80-4249-852d-53a183f83e7e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("376b22e5-95b4-4cd1-b8ca-5bd5af682879"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("385d111d-6c81-4027-820a-d56a91dac96c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("390eacd1-4571-454b-900e-179eb9355663"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("39aba83e-3f2c-43b8-b774-35d36cc9224f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("39cb9600-2319-4ee8-8f46-87c95a5c5ab1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("39e37090-95de-45a0-afbe-43e6a43d40e2"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3a523fe7-ca76-4c04-8869-80e2bc0ad6d9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3a94ae2b-f03e-430b-91ba-99549cf1d061"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3b30c634-3354-4816-b906-735d0d6fcfb1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3b725ee5-1fa5-49e2-8f2e-fc794e3d8584"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3bc9c45b-27d0-4501-ba64-f8bd3e0f99e7"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3c1f2510-568c-4330-8942-6764547cd70c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3d9bf236-a885-402f-b7a1-acf8759e35ed"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3de89521-af06-4b1a-b703-67ef771ff736"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3df72858-cc41-40a7-9ef0-497a36cea6aa"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3e4ecf2d-9223-445a-b6bd-b3859ce40b6d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3e67e1e6-29d4-492d-a76b-cdeb8191724f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3ee78370-d134-45c3-86bc-b2275fda107e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3f1254d2-3c90-4ee6-a54c-32f7ed399072"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("41057844-82e5-4b31-9279-2203a5367bce"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("41930d2c-d0bc-4337-a651-710ce7dcde38"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("43b0facf-ff46-4bca-9a4f-a5fef0f4eb22"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("445aaaaf-d605-4403-a1d9-c0970cc047dd"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("44c9e36f-3b99-40d9-ab58-5ec22a1adb31"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("45e89f2a-a7f9-4a66-b449-b538778857a6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("46ca6dfd-0d7b-4027-89a7-a7832eb11078"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("46d9de4f-0708-41df-a5d2-65889afbc9ab"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("47055083-6aa3-4cb4-8175-a553b6d2aad4"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("474953ff-09a4-477a-b249-95498e48c009"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("48ce7969-3c00-4f72-9ce7-c3c6f8d2312a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4902c543-d14e-4bd7-bd53-aab506c2226b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4971aa75-1993-4019-b666-0055f4b1ac45"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("49ceacc6-59c2-497f-91c6-06031af6592b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4a9773f3-c655-4708-978e-29cfb571913c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4afcc1f7-47a9-41bc-9da4-d15c01ec93d3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4b24eb28-306b-435e-b4e8-00ee6e4f47c5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4c0ca294-abbe-4ddc-a7ea-8f6612134580"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4c10af3b-c82e-4ba7-ad7c-7316b009c1ee"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4d28da3a-8073-4c72-a7a7-985f92c643ad"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4d309012-6f5f-492b-b48e-a3f32a838417"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4d83994f-2cf1-4013-8e68-cec7efcfd00b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4e92a468-fff1-4af1-a27b-cb1116488282"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("4f5aea44-723e-4258-80f9-bf6cc52e09ba"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("50d2803b-eee2-4df2-879b-ce8c8e6cb85c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5106c3c7-fb59-437f-aad9-4c158b773b1f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("522179ff-d0d8-4ed4-adf9-3b4bfd535199"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("52736df9-5593-478f-a308-fcbc5682fa99"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("52790a59-7a87-4749-b9cf-2ac7676c1e51"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("52b16acd-8bea-4929-a2e3-0bb850455497"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("541596cc-b39a-4ace-badf-71ee789a0289"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("54856a87-3224-479c-a115-1241c873a8aa"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("550d9109-787c-4d0e-b240-2c6927275bf1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("550f18e5-dcde-4589-ab71-af46a6b939ee"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("55ec9cd2-557c-4675-b004-99d409a7bd6f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("561f87c7-f2ce-4d95-a06d-866bef8ff76a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5648d21c-046a-4dbe-aaf5-0f8fb805fea7"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("565f6aae-8517-425c-99c4-b79e5d7dbb7d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("56f34e9d-b4a1-4606-b9ba-17b539910a5d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("580e4505-8cf2-42f3-9b03-e9d59bc7b17a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5861ed93-49ce-4a71-9fc3-66ccea41a2cb"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("591332f9-c1be-4105-8ecf-7cdef26b8f08"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5a44eafd-ccf0-4a3a-bce7-3ed26f7f198f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5a9ed362-6233-487f-8b45-7a426e4c21b6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5b5acb6e-065f-46e8-b172-cd3364bcaaa5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5b954308-b5ed-44ba-b339-39e62046264e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5b95a085-2364-42f2-9d2a-0c2c12a99829"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5bb8062c-6b2e-4725-afa9-ab7af1a8e94b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5c6974f1-3102-4af0-830e-30ff45bc8379"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5c6f5f05-730b-44ab-918c-f940bfda7441"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5c9ef963-005f-4b62-b27f-13a3b7f0af0b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5d3c53a4-df52-47ca-b9e4-17392606ff1e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5de3b967-b0ae-4f04-ab73-cc27dcab33db"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5f1604d6-9c03-4d7c-8b44-8ab17a14b269"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("5f4bad14-055d-49d4-a735-1e35095f1fcb"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("60546c07-a9b9-4059-8d34-ba91ad3dc183"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("61603b9c-26eb-4a20-b117-bcc24c292d5a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6249ddbb-ed94-4547-a099-711d3e4c7542"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("627fa872-250e-46f8-b14b-3abe557676e1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("62e0f453-d725-4931-b2e1-95d900a63de2"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("639b5de0-da2d-40eb-ae6c-e6a2944bace0"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("639f6420-e8bd-4bfd-91c9-369e046e31d8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("64224f2e-2910-4f3c-b9bf-714c9bb40351"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6465a5e1-3cf2-445a-8f58-facc16ec0680"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("64a55ad5-c6ec-49e7-b34b-6804423e32c5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("65a65227-0e41-4637-9538-4ece1d050119"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("65b298e8-0a96-4e67-807e-3266310613d3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("67b3c836-79f5-4654-ba7f-8cdb7d5ef148"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("67ee9364-149d-4b95-8188-892a2ef5527b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("688333a3-2e39-467a-ad56-dda1010e76a6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("68b54138-1923-40c3-9725-19a05b2bfa3e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("68e7938e-7a3d-40c1-8fce-21418ad35e28"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("68fa755c-d94b-4fd6-88bb-00c12c8873f8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6904a09c-ab3f-4725-a3dc-21798d3c5937"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6917df1b-464e-430f-a254-f00299f0a1c4"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("698b84a6-0afc-44eb-b4f3-fb41832e2e4f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("69f5dfd0-5cc1-4324-b930-a739fba7a226"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("69f6e700-c87d-487c-97b2-8d63e806c518"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6a345eff-01bc-41fe-95b3-f953cb4c901f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6a5bc475-5d70-435a-a80c-bbe3b5017bd0"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6ace52ac-c656-4da8-8db7-548400e465fb"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6b8b74cf-d242-4a04-a3ba-6dc457506787"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6c471bd0-90f9-4845-b9c8-0255a52cbb53"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6d26fab6-f3d8-40d7-b038-19b7cf2bc114"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6d43973b-2b31-4d04-b725-4fd81f3f439c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6ea1aa8c-a273-4523-a491-9cef6bffc03b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6f24a470-9d17-444e-bc87-00009060bad5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6f48c593-3ebd-4dab-ad5d-c37e175f36c4"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6f56df60-2d7d-4a71-961d-a42d317fac23"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6fce4ae7-5188-4e67-a554-018ee4402fcd"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("6fe33acf-68dd-4542-bdd7-01ef547d2a98"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("70468e45-7f9f-4bdc-af01-8b6290cedfe2"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("70cc40ab-5376-40c7-914a-1aba48f87502"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7120d330-ce13-4ac9-94f4-7d11333843b3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("72399432-0685-41c5-8e04-ec83e2ce2e4f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("72b03b5b-9bdb-41ae-9c49-aea09c166891"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("72bdcd16-140d-437e-a211-8ba357978304"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("730c237c-c5ae-4b37-8147-c749f922b1ab"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7371caae-af01-46cc-a43c-73d8dd1d2bb8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("73759084-c0a1-4953-a3a1-4f6ff592631e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("74031357-ea81-430a-833b-3790ba30707d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("74e1a368-4867-45cf-91d0-2a11664314cc"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("755b94e4-9868-4e5a-90b6-78634dd72f16"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("77241910-ce92-4d5a-bdc7-a137f93c1b31"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("77c0535c-b3f7-43e1-8ac7-0b2a67d72324"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("77c66649-fee2-40f6-ae89-d762e86ac2f4"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("77fbc72c-4bc0-4c5b-b4e7-65b43f48cdf0"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7801fd9a-e991-42eb-8074-364d8f869629"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("786b303e-95f1-4c00-8b4d-1d8df4c7f009"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("78ac67c4-de12-4b56-9024-e84b3813a9f8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("78e1e485-f7b1-4b60-804d-c132417e0009"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("792b786f-60a4-4272-ba1d-270f0dca8512"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7957cbd0-daa8-4081-b50c-37dd7f6c2f21"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7a315dfa-a59d-416f-b283-d2225d01c68b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7b3d24b9-3a28-443f-897f-1842c8879359"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7b78addc-a4af-41c0-a5ca-14e612390589"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7bdd5ab9-d272-4f39-94a6-8dfd681e18c4"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7c5fa001-2145-45c1-8249-1e9a124b1734"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7cdfa267-cb36-4df7-901b-72ae313acd7f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7ce325a4-1956-416e-bcc6-5ee53c518849"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7dc8e8e8-ddc9-4f57-ba8b-fbde2ff8095d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7e1ac943-12c8-4395-b836-5f80ace9d8d4"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7e8c7984-1e93-4435-8297-a9ab6ba6a44a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7edfaf72-dea0-423a-98e1-f5c6343eefa8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7f5606ec-c8d1-41ba-84b2-67fb9f731271"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7f6116f9-969d-4916-9080-a984cc092abd"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("7fb131b2-dd72-4ef9-825d-cd6822d2ae4a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8025f6df-99fc-435f-b805-d5a7e36706a4"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("802ddb08-92ad-4ffa-8fbb-3b645b80a01e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("81d3d6d3-c34e-40de-a7aa-07b59428c0e7"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("81ea7d39-346d-49a5-a1ba-acaeecb37409"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("82e49645-abc3-4d4c-a086-5b7235d5d5f5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("835e32b1-38e8-422f-a39f-8a8f58297d57"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("835f2495-f67e-4071-a596-7a9bf3b462b5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("83922827-59b6-42c0-8f4d-5f493053426e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("83e22a4f-c4e6-4ab8-94fb-84ba4657963f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("84ddc53a-f26c-40ba-be3f-1ac1317e7805"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("84eb6dd1-8c45-4212-9416-035998a75408"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("85a105d2-36b4-4eca-8615-9de77e5495e9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("85b73afc-ba03-4a2c-8d95-6792ab8cdee9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("85d4e02d-749a-4f73-b363-a7b797acffd5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("863fed69-29ad-4e85-a58d-36b58969ccce"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("86c2d1f6-5509-4e2f-8180-4c847abd0e29"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("87cc163f-86f3-4dc1-b74d-b78397353e06"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8969a61c-0834-4e00-be66-9ec420688bf6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8984296d-1003-4485-a7bb-181c2a854f0a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("89e73bc7-798d-48cc-a89b-0f282b51e4cd"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8a1117af-a09f-48d6-b08f-38dfda980b67"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8a8ce2c8-0867-444c-a0e9-bc33c5d7cd5e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8b10ae24-1fe1-4045-973b-2606deafba0a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8c42925d-a73b-4288-a411-d04cf258bafc"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8c88a752-6501-4e69-8678-8ec67d7a3a3a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8d790e87-0c5e-4932-8718-6614a9488949"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8de4051c-caf5-4f16-99d1-225ae4e28766"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8e0dbdb8-57bd-45ee-8505-1cb5c5a9b526"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8e2f8b95-ad3c-4777-9811-f3c4bed1ceec"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8e86bc83-125a-45a9-bb0b-cb6ce97cb6b9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8f768acc-204c-440e-8adf-62de936fed26"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8f7f169c-cf49-4672-8137-5a66bbc4eeba"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9002b807-6280-4365-a90b-7f7c8627f6f6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("901f8015-e9d3-4089-bb8c-57dd9f4550ef"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("90485b3d-0984-4f27-97b8-351e8f7dd181"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9071604d-8cc7-46a0-b097-a4e88574c35f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9075bdc8-c558-47b2-9953-151930f1b213"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("909566e7-762b-41a3-82c7-4a4ccb5f9043"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("90fd94c3-d03d-474a-bf1b-c7bcf09341a2"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9185110f-3b52-48cd-b449-83c9c5ee4a33"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("925de6fb-043a-4d7a-8ff6-dfadf57d7a7d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9295151d-189b-4fc1-a57c-765406d8039c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("92a401b1-bed2-494d-9e6e-80c7e21d2ae2"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("92f3d9db-e426-402b-9dff-783944f65f52"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9309b6eb-6fb6-4634-812a-61019652cff6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("934fc0a5-0516-4979-9d79-85ea222609c6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("940b9632-48fb-4892-bf0d-798bbeb36f81"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("941014a9-8515-4516-8e6c-c5ae5336d3a7"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("942bc4bb-b9ec-481f-8a12-899d0ff16be6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("94bcbbbf-a33a-4f6b-8464-3a130fa3f294"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("94c0d856-af92-47d1-a1b1-0a0b18803649"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9549867d-4737-4ce5-8a2d-56be0391f9df"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9607c089-cbc5-4499-9bfc-0d1c5fa63d3c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("961e27f1-9a79-41d6-827e-457ad74c9352"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9704a4b1-910e-4cfb-87bf-f7e79d07bea0"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("975bddc6-6e2b-4ec7-8e71-9829f24aac3f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("975d55df-3934-434c-b35a-6194200b970e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9800c52c-56f7-4810-b56b-315ef9d1d0d7"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("98645266-a223-4742-84dc-9fb79ce60c76"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("988f596a-052d-461f-80ba-a0dabf9f40bc"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("992f7b8e-4cd6-421d-ae09-1ae427256006"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("99680a65-72d1-4817-9601-f85d531dc07c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9978acc7-e88a-4cd9-aca6-0bf663d6c3b3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9aea68f8-5e2a-49cd-b09a-7ecdb7153ce3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9c1e36f2-3407-4b12-9008-24b8b31edca1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9c1eadcd-9612-4037-afb0-46a118386dbd"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9c2f6fde-93a0-4e09-8b01-ff7d343f0ed6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9c3d6947-deb6-4f55-98dd-0abf620592e8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9d69b462-95c2-4f43-8f18-b7dd159ed0ea"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9e6b86c9-f022-4cbd-9712-09e2710c3c9f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9f764b14-b1f4-40f1-aaf4-36029e0c56bd"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9fd2ac9a-97d7-46fc-a202-a8405a51f5aa"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9ff056e2-a8c9-4022-a3a4-d66243612b84"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a043c6f2-83ca-45ae-9b72-f24e06d2e670"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a0dcc9b5-644a-44fd-ad5c-644e65d7af92"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a11f9ab3-f274-484c-a263-c39632b6a4a4"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a18906c7-143f-428c-ba27-d1e1d507ea6c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a19e002b-846b-47e7-8080-b8d12bc24aa4"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a1f4f5af-c68c-4612-9f8f-13a579186f92"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a2116da0-f676-4f82-b3b6-4dce94149fbf"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a2eb857b-fd49-40bc-a168-8a1917cd9f49"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a366b007-eaea-489d-a39c-74dec5c9d85a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a3a1f725-f84d-4536-abb0-ae63f2d080d4"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a424f9db-95fc-4426-a386-ac3fed83ea85"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a4354e16-7356-4760-bb22-b36e30576173"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a4a4fc4e-6b64-40d8-849c-65649047cb17"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a4fd4f3b-b034-4ca1-81d2-0062a826a36f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a4ff0c68-7e80-4843-b3cf-a828b7a6ae30"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a53e9ebd-048a-417b-84ca-5886f6605eab"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a54d2954-5bb1-408d-9efc-ec77fcaa5d3f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a5722a86-7aed-485e-a437-a822df51c83f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a5f2e723-3c2b-4602-94b3-605594ee3a45"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a6d48e87-758d-4c10-a0be-9ba0b9c52792"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a75abc5e-dd2b-4cb8-9ab3-237293dd709b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a8288144-1aa0-4c61-b3c1-e75d6b158ba9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a8b77c79-fc9b-4a77-b91c-88292efdfa19"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("a9936370-10c0-46a6-bc3a-a21c322ba80d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("aa864d6e-1f34-4dcf-920b-090a16e27237"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("aba49a58-edfa-425a-bb43-244a5ffaa80b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ac3b9132-894e-4166-8d6d-5d338f57194d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ac5891dd-529d-49ff-a0c3-54c5bff1abc6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ac594a77-f5d5-4ae8-9455-1d2f3333eba5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ace3355b-c091-4416-b554-b2699d63fd65"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("add9b6c8-ef50-4666-9f67-7af099ec5f18"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ae375716-d411-42ce-96f3-eae7882dfb90"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ae72633a-5370-464e-8e20-0f8688139fef"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("af0de038-3a69-42cc-84ae-99db6193f4f9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("af1d311e-756f-458f-9a3c-2b18400f29be"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b0367e52-fe34-47e6-a16f-122787c6692c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b062eb9e-94b9-47a0-b750-87ab2439ca5e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b09d3873-e255-44af-bff3-722ef05a9505"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b20f5bdc-5e5b-4d9d-ba5b-31018a6190b6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b2193b98-e7b5-473e-97c0-3b59c68d26fe"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b307c1f8-f8ed-46ed-95e9-7e44193b370a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b3bd42b6-e3f9-41e4-af1f-605192d8dab3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b4b053c6-5a44-4434-9d5f-80c4071ffa6d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b4cab40a-a958-4fef-ae8a-ec4f55e2b0db"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b687b6a9-f1cd-443e-aaf2-8a8d23faabf1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b6da21c0-41eb-4cf3-bf15-9bfac0c0473e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b7127989-3164-44c8-9683-694b4d56094e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b75f4b7c-8178-4c6b-93db-7062b0586053"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b7f3c72b-808f-4ec5-acfb-7ea53788108f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b89f96b2-011d-4303-986f-c013fbb3851c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b8b06512-b9f4-4cab-9a23-b727d90bffa2"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b969d8ef-7b56-4a5c-9f35-91382e9c1a91"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("bb80fac6-5824-4477-a439-3c8eee4dc8f2"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("bbb9fb83-2ec6-452f-88b0-36159e526981"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("bc311068-3470-4bb9-9584-e4556f58ed36"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("bcd181f6-d65c-4cc4-b68f-a76850f9d03e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("bceba463-3e29-4c15-bf81-7656dfa01060"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("bd5c7f60-a766-4e2a-9357-17b3b70239e0"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("bd6c3f17-0735-46b1-9859-596f36db5cb7"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("bd82a445-aee3-4e25-b64f-1eaf339441bd"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("be38a1c2-d3b8-4ff8-9e7e-c1863eef6b55"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("bf1b2972-6d24-4bcf-a476-fd64ff86a3b6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("bf5e1d5a-caf1-4916-95ca-d099200206bd"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("bfbc6127-e6a6-466d-a2af-0e790deb1e32"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("bfc240fd-db40-4dd2-8154-2db41d215694"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c11714c9-7c94-4b7e-93b2-1ddbe588e576"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c13f634b-59de-4018-8798-6b8c9d66725f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c17691d8-f03b-41f4-ae31-2db027edf56b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c1f4d07b-1f73-4a03-96d9-e3118e4ec834"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c264b9d2-c22e-444c-adb9-f7b96e4b222e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c2b7049f-a0e1-4b51-9a24-418d80151f1e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c37d6d59-854e-4e0f-8a6b-71421e02ee67"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c3b28038-0031-4f10-ac84-cc1500ccb34e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c3c922a1-cf21-441e-8cde-080dc9556db0"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c3e1da30-f5ba-4eba-a94c-c6155266ecc2"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c41a3fba-c35a-40ce-95f7-9a44b305a968"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c42f0195-80cf-4605-a54d-91da1f5db75b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c6fbf06d-0907-4c55-be55-fb9735ddb026"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c700f49d-2ab1-4a8d-82b7-bf6c4e0cbd7b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c7a60561-d2dd-462b-93f3-2fa4471123df"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c95b94f8-24a8-485d-8a42-12823eabf471"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("c9b22085-72b0-436e-80bf-0dda62e176fc"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ca4f5edd-19d6-4528-890d-86223ee4cc8b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cacfee95-91fc-4471-8308-86095b408f40"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cc9fab61-370a-4ee6-9888-31bf7b4bb928"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cd44fb3a-b13e-4ccb-a5e0-7b0c3bd93e78"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cd7c85a1-4cf9-4165-97a8-bee6e21a4fe9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cddf422b-d92b-4896-88f6-47b4a37a03c6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ce4ff7a2-ee0f-48aa-82f1-d4f5d022b31f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ce9fbd87-5d41-430a-a601-90b90878f0a0"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cf2106ab-a3c0-4b7f-8dcc-b353d0b287d3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cf75b460-ebec-472d-b93e-8d288f075028"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cfce4db6-3c5a-4ed4-9db5-5f3981fde920"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d015353b-7256-42c4-bb7f-244d9f7177df"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d066a8d8-aede-4b51-a8ae-e4fa14433034"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d08d0223-5efc-46c8-acd1-4659941cd9cc"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d1068b6e-b611-4e7d-a95d-22ffb8b665dd"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d161ec42-f610-4937-a1a4-cae6a3ef1157"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d376d318-ac5c-4ab6-bb7d-fcfed6aec8e9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d42cb771-db0e-4558-a4d0-8b737d23dae9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d458de3d-a6c9-47fb-aaec-8563d8310888"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d55fe24e-460b-41aa-a2ea-6d8b547232b0"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d6d49c07-fb43-4c6d-b814-8d100f741195"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d8c0e86e-0c4a-40c8-9ae0-70c59bb5b3ac"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d93fcc93-fc6f-43be-8ae5-784bc9d99db4"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("d9a64361-e7d1-46cd-8198-3e7b6453e2e8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("daa53a76-44c3-40f3-bbc9-2c05ac20e42f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("db062a75-8a93-40bf-b043-59d1397a73c9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("db79d7ce-f5f0-4323-bc0c-6a9f9c76550e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("dbc78dff-f6af-4cda-a95e-7d9dc7944ab9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("dc463b4f-b67e-4fe5-a293-e1ce8834411d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("dd4a4fc4-edf9-48fd-8359-a8b17cd78413"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("dd7bc611-cde9-48b6-8f0f-e3623f7cad4d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("dd9338de-b46b-4af1-850e-77965d256c89"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ddb9ecd0-c748-4c83-9482-96d72f9b807f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ddd98668-0d94-43d1-8ad2-c332a3502ff1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("de0a6dad-cfdf-4aed-a5ee-40c26c59cd8c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("dedc6626-a402-4875-9a5f-97d6b84e820e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("dee6b3a5-ac2b-4359-b257-93e099f471f0"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("df50c55a-4c68-4426-8218-bc2da1895256"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e115505d-7885-45ca-a1a0-dcdf722fb34c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e13e259b-601d-4477-8dde-d73973bc9c42"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e14156bc-add2-497c-b6b3-ead0ef9c7967"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e144d787-ec4e-46fd-aad3-d1e3cb2c59fb"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e1c702e7-0158-4343-9dbe-0e861874fba7"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e1e3a126-f040-4eaa-acef-4a7b7300a2a6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e20fcdfa-fb01-469c-bf44-94a8df1f98ba"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e2354dee-0fd1-4e09-bdde-e81f147a3abb"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e2cfc41c-1638-47e2-9ca8-db94e9aa6d20"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e3b0af93-e22a-452c-a52e-160406b24c56"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e611b38d-da14-4a2f-97bc-0cc950765557"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e61b97c3-f148-48fa-b020-c257597228a6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e6f7a428-ed61-4c0c-84dc-43a6516f58ef"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e79fecbd-d012-4238-92de-1a1c6bec070d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e7ed26f6-fe09-4d73-8bac-883fb1e1de18"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e82e844f-6b53-4dc3-845b-cb5c3515bd2e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e87a16a6-ab92-4199-9f18-2fbcda16a5c8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e8e76c04-b8f2-453c-97c2-335272c23b80"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e8e7e932-f94e-4f8e-a530-ddd97d5107e3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e8ff8090-65b2-4cd6-977d-3481725e88d3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("e90f18b6-5ffc-4f83-ae68-64741f7ff690"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ea28d4f7-f77c-402d-81af-76c43e559710"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ea3547c2-80d3-4ee1-9835-1d62c0900294"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("eab73bd6-6a65-4452-8d55-753144f7cee1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ead13691-8b74-4e2a-bfee-c0792d80e8de"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("eaddba00-98b1-4b27-88f8-b40c77ea15c3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("eaf04090-9180-402d-a8fe-17590ee399fb"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("eb03c361-eab5-4391-a854-6697deccd009"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("eb8736a9-def7-4e59-97e0-fefff04f2807"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ebd52893-f511-40ea-a186-282437c57edb"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ec059ff7-faab-43e3-bb38-a85bebcf4c19"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ec940211-3cd3-4159-b9c2-8df01e39f101"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ed268b8a-4227-4df7-b2f1-80953562449d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ed488eea-f0ad-422e-96ef-ab2acc874ada"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ed76f782-3e32-468b-a690-1be36d706d79"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ede308b2-7478-447b-8e03-2419dc91aea2"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ee292f11-429d-4cff-8d75-a1c0978e06cd"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("efbf33eb-86fa-478f-ae46-b0fde7deaf9f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("efc4751a-5670-49a9-ade6-430465899677"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("efe1f0bf-b454-4a36-9951-dd80e58c9e59"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("eff32098-12b7-432f-9cab-7fc1f8520846"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f0c5f7a6-8088-4498-acaa-319028d8c45f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f110016c-16a9-4d8f-a712-f4554e6e66c3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f1d511a5-a6c2-4bd9-beb7-94a3826034fe"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f41ac576-de26-4ab2-935a-6aa020423d1d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f5df0a70-6402-4a3a-b031-09ae318924cc"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f6a2aac3-db38-43ae-b19a-8bb42a200261"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f717f318-b312-479c-8cb3-5e90a8c88265"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f837875e-31b9-4058-96d7-3591b1a62af3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f8469e38-495b-4e5c-ab2a-0d2ce3f18cbe"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f8ab0574-dcc8-4207-b680-be8866301d85"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("f9b17957-d7c9-402e-aec7-81a91a500e44"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("fa3962f1-0995-4c18-b2b2-2b49da2ce327"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("fa6dba4b-42db-47ef-b24f-9591c5fc3b2d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("fb3c5b61-df0c-4c70-b96a-1eb2f8effa66"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("fc961d97-f6e1-4315-95ed-1f7aa3bf9733"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("fdae2d92-301e-429f-9254-2e71521ca95f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ff619f44-4729-4175-889c-d61567ff5ca2"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ff7072e3-9686-4f7d-b74e-cc61da8d854c"));

            migrationBuilder.DropColumn(
                name: "VenueId",
                table: "Events");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                column: "Date",
                value: new DateTime(2026, 5, 17, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                column: "Date",
                value: new DateTime(2025, 12, 17, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                column: "Date",
                value: new DateTime(2026, 4, 17, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                column: "Date",
                value: new DateTime(2025, 12, 17, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                column: "Date",
                value: new DateTime(2026, 2, 17, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Artist", "Date", "Description", "ImageUrl", "IsOnSpecialOffer", "Name", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { new Guid("0020fc11-753d-4888-9db8-e4fa21e773e1"), "Lil Baby & Beyoncé", new DateTime(2027, 12, 26, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3115), "Join Lil Baby & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Lil Baby & Beyoncé: Live at Home", 129.99m, 129.99m },
                    { new Guid("00373f9a-3b48-4319-b0d9-aed4d1440383"), "Panic! At The Disco & BTS", new DateTime(2029, 1, 16, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5408), "Experience the magic of Panic! At The Disco & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Panic! At The Disco & BTS: Live in Concert", 89.99m, 89.99m },
                    { new Guid("0087204e-410d-432c-8191-6a79195f7f4c"), "Luke Combs & Ed Sheeran", new DateTime(2027, 1, 30, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1117), "Join Luke Combs & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Luke Combs & Ed Sheeran: Reunion Tour", 169.99m, 169.99m },
                    { new Guid("00f38e8d-315d-4231-8e34-cc864c5d80e0"), "Miley Cyrus & BTS", new DateTime(2028, 10, 9, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4834), "Miley Cyrus & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Miley Cyrus & BTS: Anniversary Tour", 139.99m, 139.99m },
                    { new Guid("00f91d21-7577-49a5-9883-a99d4ddbaabc"), "OneRepublic", new DateTime(2026, 4, 14, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9417), "An unforgettable night with OneRepublic showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "OneRepublic: Stadium Tour", 149.99m, 149.99m },
                    { new Guid("01ce86ac-f1af-4533-bd6f-a06be542adf2"), "Niall Horan & BTS", new DateTime(2028, 11, 2, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4973), "Experience the magic of Niall Horan & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Niall Horan & BTS: Unplugged", 29.99m, 29.99m },
                    { new Guid("02076f8d-6426-4f41-a057-41edecde37b6"), "Bastille & Ed Sheeran", new DateTime(2027, 4, 15, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1555), "Join Bastille & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Bastille & Ed Sheeran: Comeback Tour", 39.99m, 39.99m },
                    { new Guid("0224e603-0f19-45ee-8aee-874c9aa846f1"), "Dan + Shay & Ed Sheeran", new DateTime(2027, 5, 3, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1642), "Dan + Shay & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Dan + Shay & Ed Sheeran: Greatest Hits Tour", 99.99m, 99.99m },
                    { new Guid("02c736a8-59dd-4b69-b41d-5f566683086e"), "Daddy Yankee & Ed Sheeran", new DateTime(2026, 12, 4, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(784), "Daddy Yankee & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Daddy Yankee & Ed Sheeran: Anniversary Tour", 169.99m, 169.99m },
                    { new Guid("03cadeb0-e294-407b-9214-4f33709eee7a"), "Lil Uzi Vert", new DateTime(2026, 4, 23, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9459), "Lil Uzi Vert returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Lil Uzi Vert: Anniversary Tour", 179.99m, 179.99m },
                    { new Guid("03ff1661-c9e7-4b15-ba78-5e0360ab884a"), "Maluma & BTS", new DateTime(2028, 11, 23, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5077), "Maluma & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Maluma & BTS: Anniversary Tour", 99.99m, 99.99m },
                    { new Guid("04941cee-061a-49f6-ab6d-a1632d9ce5ec"), "Juice WRLD & Ed Sheeran", new DateTime(2026, 12, 25, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(918), "An unforgettable night with Juice WRLD & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Juice WRLD & Ed Sheeran: Summer Festival", 49.99m, 49.99m },
                    { new Guid("04d7110a-fd59-4bcc-94c0-647755f560c6"), "Post Malone & BTS", new DateTime(2028, 6, 20, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4158), "Experience the magic of Post Malone & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Post Malone & BTS: Unplugged", 149.99m, 149.99m },
                    { new Guid("04ef7caa-34ba-4b7f-a415-bda43c20bcda"), "Khalid", new DateTime(2026, 2, 19, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9103), "Join Khalid for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Khalid: Live at Home", 159.99m, 159.99m },
                    { new Guid("050d23b4-d4f4-4356-acfb-2051f775ee5a"), "LISA", new DateTime(2026, 7, 31, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(47), "Experience the magic of LISA in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "LISA: Live in Concert", 129.99m, 129.99m },
                    { new Guid("06665687-c6cd-4778-a3ae-0a5255513fac"), "Juice WRLD & Drake", new DateTime(2029, 8, 23, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6681), "The electrifying Juice WRLD & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Juice WRLD & Drake: Legends Tour", 59.99m, 59.99m },
                    { new Guid("067ce0cc-3439-4d20-82cc-23bfa4568358"), "Machine Gun Kelly & Beyoncé", new DateTime(2028, 2, 24, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3462), "Join Machine Gun Kelly & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Machine Gun Kelly & Beyoncé: Comeback Tour", 139.99m, 139.99m },
                    { new Guid("07d10000-5443-4c95-83a3-398f575b5719"), "Ava Max & Drake", new DateTime(2029, 9, 25, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6859), "An unforgettable night with Ava Max & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Ava Max & Drake: Stadium Tour", 169.99m, 169.99m },
                    { new Guid("07f70730-afbf-418e-9acb-53058d2554cf"), "Marshmello", new DateTime(2026, 1, 5, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8851), "Join Marshmello for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Marshmello: Live at Home", 199.99m, 199.99m },
                    { new Guid("08d713de-06af-48a0-b9c0-69d1d5a1e900"), "J Balvin & BTS", new DateTime(2028, 7, 14, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4318), "The electrifying J Balvin & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "J Balvin & BTS: Legends Tour", 39.99m, 39.99m },
                    { new Guid("09216e8a-16d8-4b20-a951-3592fa111d21"), "Little Mix & BTS", new DateTime(2029, 1, 4, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5347), "Join Little Mix & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Little Mix & BTS: Comeback Tour", 49.99m, 49.99m },
                    { new Guid("094a3af6-1608-4403-862b-55f76ff5ed5a"), "Drake & Beyoncé", new DateTime(2027, 7, 8, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2071), "An unforgettable night with Drake & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Drake & Beyoncé: Stadium Tour", 129.99m, 129.99m },
                    { new Guid("09b1180f-e5c7-4f0b-8bf6-0f1412fef83c"), "SZA & Ed Sheeran", new DateTime(2026, 11, 22, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(724), "The electrifying SZA & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "SZA & Ed Sheeran: Acoustic Night", 129.99m, 129.99m },
                    { new Guid("09cf9290-9dfe-419c-a843-10757cfb20ba"), "Calvin Harris", new DateTime(2025, 12, 30, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8820), "An unforgettable night with Calvin Harris showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Calvin Harris: Summer Festival", 179.99m, 179.99m },
                    { new Guid("0ae2b7f1-8f46-4bcb-a1be-aa960b0f42b1"), "Lana Del Rey & BTS", new DateTime(2028, 10, 30, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4958), "An unforgettable night with Lana Del Rey & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Lana Del Rey & BTS: Summer Festival", 19.99m, 19.99m },
                    { new Guid("0b4c4a35-60b1-4539-8b32-71b6486c28d4"), "Halsey & Drake", new DateTime(2029, 7, 3, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6384), "Join Halsey & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Halsey & Drake: Comeback Tour", 79.99m, 79.99m },
                    { new Guid("0b6a6e70-f04e-49a8-bf76-b4f812990757"), "Dan + Shay & BTS", new DateTime(2029, 2, 9, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5541), "The electrifying Dan + Shay & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Dan + Shay & BTS: Acoustic Night", 169.99m, 169.99m },
                    { new Guid("0c300edd-7583-4bd4-863f-04c91fe943b7"), "Halsey & Beyoncé", new DateTime(2027, 9, 24, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2501), "Experience the magic of Halsey & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Halsey & Beyoncé: Unplugged", 199.99m, 199.99m },
                    { new Guid("0c356008-66c0-4dc6-a5c4-476f8da1fc74"), "The Weeknd & Drake", new DateTime(2029, 4, 22, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5982), "The Weeknd & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "The Weeknd & Drake: Greatest Hits Tour", 29.99m, 29.99m },
                    { new Guid("0c8ef135-97b4-48ca-8265-3dd01da88be3"), "Niall Horan & Beyoncé", new DateTime(2027, 12, 14, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3055), "Niall Horan & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Niall Horan & Beyoncé: Greatest Hits Tour", 89.99m, 89.99m },
                    { new Guid("0cf5b1b8-e378-4f80-bba0-c85877958f5c"), "Alicia Keys & Ed Sheeran", new DateTime(2027, 3, 19, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1389), "Alicia Keys & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Alicia Keys & Ed Sheeran: Greatest Hits Tour", 139.99m, 139.99m },
                    { new Guid("0e0ce6cc-a690-4dba-af23-5bfd5ae6aa28"), "Bad Bunny & BTS", new DateTime(2028, 7, 26, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4377), "Bad Bunny & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Bad Bunny & BTS: Greatest Hits Tour", 79.99m, 79.99m },
                    { new Guid("0eb02058-9252-4345-acbc-ebd5fbfdd8f5"), "Jack Harlow", new DateTime(2026, 3, 21, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9275), "Join Jack Harlow for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Jack Harlow: Reunion Tour", 69.99m, 69.99m },
                    { new Guid("0f31db2e-ecef-4127-a8ad-e3ddaaf8a0dc"), "Jason Derulo & Beyoncé", new DateTime(2028, 4, 12, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3768), "Jason Derulo & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Jason Derulo & Beyoncé: Anniversary Tour", 109.99m, 109.99m },
                    { new Guid("0f3e8edf-f3bf-4db5-b707-64661a547401"), "BLACKPINK ROSÉ & BTS", new DateTime(2029, 3, 23, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5816), "BLACKPINK ROSÉ & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "BLACKPINK ROSÉ & BTS: The Sessions", 119.99m, 119.99m },
                    { new Guid("11185bf4-164e-4f24-bd03-b20291d2d376"), "YUNGBLUD & BTS", new DateTime(2029, 1, 7, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5363), "YUNGBLUD & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "YUNGBLUD & BTS: Anniversary Tour", 59.99m, 59.99m },
                    { new Guid("111b86d7-ecb5-43a7-8bb8-2540ec0fbcf7"), "Kendrick Lamar", new DateTime(2025, 10, 31, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8450), "An unforgettable night with Kendrick Lamar showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Kendrick Lamar: World Tour", 169.99m, 169.99m },
                    { new Guid("11507585-9a36-46a8-8e7b-45d76bdab29c"), "Rosalía & Ed Sheeran", new DateTime(2027, 2, 17, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1227), "Rosalía & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Rosalía & Ed Sheeran: The Sessions", 39.99m, 39.99m },
                    { new Guid("119f45e9-a57f-4fe1-bf8d-4728af4f9649"), "Kygo & Drake", new DateTime(2029, 8, 26, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6697), "An unforgettable night with Kygo & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Kygo & Drake: World Tour", 69.99m, 69.99m },
                    { new Guid("1288b94f-0ff2-404e-a429-eca37d4624b8"), "Lady Gaga & Ed Sheeran", new DateTime(2026, 9, 2, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(241), "Join Lady Gaga & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Lady Gaga & Ed Sheeran: Comeback Tour", 49.99m, 49.99m },
                    { new Guid("12fa4815-6101-4374-a86d-6ff1d3573938"), "SEVENTEEN & Beyoncé", new DateTime(2028, 4, 6, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3736), "Experience the magic of SEVENTEEN & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "SEVENTEEN & Beyoncé: Farewell Tour", 89.99m, 89.99m },
                    { new Guid("14b5428b-d347-46c4-8182-f628d6c6ed09"), "Zara Larsson & Beyoncé", new DateTime(2028, 1, 25, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3287), "Join Zara Larsson & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Zara Larsson & Beyoncé: Reunion Tour", 39.99m, 39.99m },
                    { new Guid("14ec505d-ea2e-4c58-800e-3ebd84fd0dfc"), "Troye Sivan & Ed Sheeran", new DateTime(2027, 4, 24, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1598), "An unforgettable night with Troye Sivan & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Troye Sivan & Ed Sheeran: World Tour", 69.99m, 69.99m },
                    { new Guid("158c45b8-fa86-4a46-a4db-b5ad62d5f2d2"), "Tiësto & Beyoncé", new DateTime(2028, 2, 3, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3333), "An unforgettable night with Tiësto & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Tiësto & Beyoncé: Summer Festival", 69.99m, 69.99m },
                    { new Guid("15fa36c7-3326-4818-83d7-dbf546b584cc"), "Daddy Yankee", new DateTime(2026, 1, 14, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8896), "An unforgettable night with Daddy Yankee showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Daddy Yankee: Stadium Tour", 39.99m, 39.99m },
                    { new Guid("1629130a-ac63-4e98-9d5d-56e56c0fde6e"), "Kehlani & Ed Sheeran", new DateTime(2027, 4, 3, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1464), "Kehlani & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Kehlani & Ed Sheeran: The Sessions", 189.99m, 189.99m },
                    { new Guid("16a4b8d7-d80c-480b-82ba-62fc88ebe823"), "Jack Harlow & Beyoncé", new DateTime(2027, 12, 29, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3130), "Jack Harlow & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Jack Harlow & Beyoncé: The Sessions", 139.99m, 139.99m },
                    { new Guid("182616ff-5b2d-43ad-b151-b1ee84567c81"), "Nicky Jam", new DateTime(2026, 5, 29, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9685), "An unforgettable night with Nicky Jam showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Nicky Jam: Stadium Tour", 109.99m, 109.99m },
                    { new Guid("18299109-f70c-491b-9385-a9a68a7a0e24"), "Madison Beer & Ed Sheeran", new DateTime(2027, 6, 17, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1940), "Madison Beer & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Madison Beer & Ed Sheeran: Greatest Hits Tour", 59.99m, 59.99m },
                    { new Guid("19654cba-70eb-497f-90e7-f40a09fe3ed7"), "Anne-Marie & Ed Sheeran", new DateTime(2027, 5, 30, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1848), "Join Anne-Marie & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Anne-Marie & Ed Sheeran: Comeback Tour", 189.99m, 189.99m },
                    { new Guid("19884de4-fedc-4707-9e14-1253f01653fe"), "Lewis Capaldi", new DateTime(2025, 12, 18, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8760), "Experience the magic of Lewis Capaldi in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Lewis Capaldi: Live in Concert", 139.99m, 139.99m },
                    { new Guid("19f79db9-ae23-42b2-83e1-f6d57aa6801a"), "Post Malone & Beyoncé", new DateTime(2027, 8, 1, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2211), "Post Malone & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Post Malone & Beyoncé: Greatest Hits Tour", 19.99m, 19.99m },
                    { new Guid("1b371b07-27a0-4c2b-84b3-8c7c6ef72bc1"), "Sia & Drake", new DateTime(2029, 8, 5, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6572), "Sia & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Sia & Drake: The Sessions", 189.99m, 189.99m },
                    { new Guid("1cbbb01c-b936-4a22-96bb-deb9e21bd866"), "David Guetta & Drake", new DateTime(2029, 9, 1, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6726), "Join David Guetta & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "David Guetta & Drake: Reunion Tour", 89.99m, 89.99m },
                    { new Guid("1d16439a-7426-484c-90f7-be36ec2d39d9"), "Martin Garrix & Drake", new DateTime(2029, 9, 16, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6798), "Join Martin Garrix & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Martin Garrix & Drake: Live at Home", 139.99m, 139.99m },
                    { new Guid("1d60e7c4-55a6-4a66-9453-221249e15b27"), "The Chainsmokers & Beyoncé", new DateTime(2027, 10, 6, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2583), "An unforgettable night with The Chainsmokers & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "The Chainsmokers & Beyoncé: Stadium Tour", 49.99m, 49.99m },
                    { new Guid("1dd5e4ac-24f9-4344-ab02-c801d7f462e5"), "Fall Out Boy & Ed Sheeran", new DateTime(2027, 5, 15, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1753), "Join Fall Out Boy & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Fall Out Boy & Ed Sheeran: Live at Home", 139.99m, 139.99m },
                    { new Guid("1e756dfe-4c0f-46dc-9dab-6e4e0d1d1db2"), "Selena Gomez & Beyoncé", new DateTime(2027, 10, 30, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2725), "Selena Gomez & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Selena Gomez & Beyoncé: Greatest Hits Tour", 129.99m, 129.99m },
                    { new Guid("1ea9a18a-75d1-48e8-9153-007a45cf4378"), "Adele & Ed Sheeran", new DateTime(2026, 8, 21, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(151), "Adele & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Adele & Ed Sheeran: The Sessions", 199.99m, 199.99m },
                    { new Guid("1ff53ad9-ab38-495b-a04a-e58394655d0e"), "Juice WRLD", new DateTime(2026, 2, 4, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9030), "Join Juice WRLD for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Juice WRLD: Reunion Tour", 109.99m, 109.99m },
                    { new Guid("20b92233-b622-455c-bdbb-0c3893fa5142"), "Daddy Yankee & BTS", new DateTime(2028, 9, 12, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4675), "The electrifying Daddy Yankee & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Daddy Yankee & BTS: The Experience", 49.99m, 49.99m },
                    { new Guid("20bc484c-ef01-413b-ac6e-75861cf1e1be"), "Cardi B", new DateTime(2025, 12, 9, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8663), "Cardi B returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Cardi B: Anniversary Tour", 109.99m, 109.99m },
                    { new Guid("20c8cc38-2989-41cd-b1ed-415cbd2fd1eb"), "Taylor Swift & Beyoncé", new DateTime(2027, 6, 26, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1986), "Experience the magic of Taylor Swift & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Taylor Swift & Beyoncé: Unplugged", 89.99m, 89.99m },
                    { new Guid("20d9ea22-8014-40bd-b942-06c0dab16544"), "Lil Nas X & Beyoncé", new DateTime(2027, 10, 3, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2568), "The electrifying Lil Nas X & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Lil Nas X & Beyoncé: Acoustic Night", 39.99m, 39.99m },
                    { new Guid("21612706-9d6d-40b7-9f0c-0041d07a15c9"), "Tyler, The Creator & Beyoncé", new DateTime(2028, 3, 1, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3491), "The electrifying Tyler, The Creator & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Tyler, The Creator & Beyoncé: Legends Tour", 159.99m, 159.99m },
                    { new Guid("22631533-7aff-46a5-9a01-505f3b96fb3d"), "Glass Animals & Drake", new DateTime(2029, 10, 22, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(7066), "The electrifying Glass Animals & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Glass Animals & Drake: The Experience", 69.99m, 69.99m },
                    { new Guid("22994573-7bf0-4edd-b747-607682231479"), "Justin Bieber & Beyoncé", new DateTime(2027, 7, 26, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2160), "Experience the magic of Justin Bieber & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Justin Bieber & Beyoncé: Live in Concert", 189.99m, 189.99m },
                    { new Guid("2303af90-a10b-4b62-92af-28a4d0ae32b8"), "Blackpink & Ed Sheeran", new DateTime(2026, 12, 1, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(769), "Join Blackpink & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Blackpink & Ed Sheeran: Comeback Tour", 159.99m, 159.99m },
                    { new Guid("237f0f60-0e3b-4017-88a3-ea719f522a84"), "Rosalía & Drake", new DateTime(2029, 10, 16, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(7036), "Join Rosalía & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Rosalía & Drake: Reunion Tour", 49.99m, 49.99m },
                    { new Guid("23e183ba-cfc1-4a08-ab3a-a41ea9c41a98"), "Twenty One Pilots & Ed Sheeran", new DateTime(2026, 11, 1, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(599), "Join Twenty One Pilots & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Twenty One Pilots & Ed Sheeran: Reunion Tour", 59.99m, 59.99m },
                    { new Guid("23f6fd61-b0d5-4a0d-83b5-6811a0314236"), "Maluma & Ed Sheeran", new DateTime(2027, 2, 14, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1212), "Join Maluma & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Maluma & Ed Sheeran: Live at Home", 29.99m, 29.99m },
                    { new Guid("242a0cb1-42c7-419b-9db8-e6a4610fe749"), "NCT 127 & BTS", new DateTime(2029, 2, 15, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5572), "Experience the magic of NCT 127 & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "NCT 127 & BTS: Farewell Tour", 189.99m, 189.99m },
                    { new Guid("244f6870-1dd3-412e-8488-1baf643e16cf"), "Bad Bunny", new DateTime(2025, 11, 27, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8601), "The electrifying Bad Bunny brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Bad Bunny: Acoustic Night", 69.99m, 69.99m },
                    { new Guid("245b7ed5-1d25-4406-a696-235024030747"), "Tones and I & Drake", new DateTime(2029, 10, 19, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(7052), "Tones and I & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Tones and I & Drake: Greatest Hits Tour", 59.99m, 59.99m },
                    { new Guid("2480b99a-5334-4761-b6e0-77535b7798d3"), "Doja Cat & Beyoncé", new DateTime(2027, 9, 15, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2457), "Doja Cat & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Doja Cat & Beyoncé: Greatest Hits Tour", 169.99m, 169.99m },
                    { new Guid("25743468-5e02-4b41-ad13-6a02af8d4a38"), "Selena Gomez & Drake", new DateTime(2029, 8, 8, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6587), "The electrifying Selena Gomez & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Selena Gomez & Drake: Acoustic Night", 199.99m, 199.99m },
                    { new Guid("2580e505-7f21-4ea4-a350-a71792c1ceb8"), "Doja Cat", new DateTime(2025, 12, 6, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8647), "Join Doja Cat for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Doja Cat: Comeback Tour", 99.99m, 99.99m },
                    { new Guid("25a494b6-24c6-4e28-a803-e839f3e896ff"), "Drake & Ed Sheeran", new DateTime(2026, 8, 18, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(137), "Join Drake & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Drake & Ed Sheeran: Live at Home", 189.99m, 189.99m },
                    { new Guid("25ab0895-8a7a-4ac6-973f-7b7b4eb664a6"), "Robin Schulz & Beyoncé", new DateTime(2028, 4, 9, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3753), "Join Robin Schulz & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Robin Schulz & Beyoncé: Comeback Tour", 99.99m, 99.99m },
                    { new Guid("25d79850-a581-4b5e-b221-bb46ecb32417"), "Megan Thee Stallion & Ed Sheeran", new DateTime(2026, 12, 22, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(903), "The electrifying Megan Thee Stallion & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Megan Thee Stallion & Ed Sheeran: The Experience", 39.99m, 39.99m },
                    { new Guid("260ed405-b83e-438c-83bf-4e3139f09aba"), "Megan Thee Stallion & BTS", new DateTime(2028, 9, 30, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4787), "An unforgettable night with Megan Thee Stallion & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Megan Thee Stallion & BTS: Stadium Tour", 109.99m, 109.99m },
                    { new Guid("2618631d-0531-45ce-a87e-7e44bc401b1b"), "Niall Horan", new DateTime(2026, 3, 6, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9201), "Join Niall Horan for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Niall Horan: Comeback Tour", 19.99m, 19.99m },
                    { new Guid("26872b8d-ec5f-46e3-b748-5ae507beb996"), "Nicki Minaj & Beyoncé", new DateTime(2028, 2, 12, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3399), "Nicki Minaj & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Nicki Minaj & Beyoncé: The Sessions", 99.99m, 99.99m },
                    { new Guid("26f623a8-324c-4cdd-ab6b-2d447bdd9fb4"), "Panic! At The Disco", new DateTime(2026, 5, 20, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9617), "Join Panic! At The Disco for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Panic! At The Disco: Live at Home", 79.99m, 79.99m },
                    { new Guid("276f8383-a334-48a9-a7e6-87e7725be161"), "Katy Perry & Beyoncé", new DateTime(2027, 8, 22, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2315), "An unforgettable night with Katy Perry & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Katy Perry & Beyoncé: Stadium Tour", 89.99m, 89.99m },
                    { new Guid("2a4022ed-a403-49f6-8dab-47ec446f1e2c"), "Megan Thee Stallion", new DateTime(2026, 2, 1, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9015), "Experience the magic of Megan Thee Stallion in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Megan Thee Stallion: Live in Concert", 99.99m, 99.99m },
                    { new Guid("2c2a8546-3eee-4f79-8270-cefe7b7af0d8"), "Robin Schulz", new DateTime(2026, 7, 1, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9867), "Experience the magic of Robin Schulz in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Robin Schulz: Unplugged", 29.99m, 29.99m },
                    { new Guid("2c35aabd-eae0-4054-b9fc-5f47646bbc7e"), "Shawn Mendes & BTS", new DateTime(2028, 7, 29, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4422), "The electrifying Shawn Mendes & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Shawn Mendes & BTS: The Experience", 89.99m, 89.99m },
                    { new Guid("2c477f81-a225-4a62-8c5c-4eb0c4afe6c0"), "Luke Combs & Beyoncé", new DateTime(2027, 12, 20, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3085), "An unforgettable night with Luke Combs & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Luke Combs & Beyoncé: Summer Festival", 109.99m, 109.99m },
                    { new Guid("2cc892bc-9100-488c-bde2-850ea4ab35c8"), "Kehlani", new DateTime(2026, 5, 14, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9588), "An unforgettable night with Kehlani showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Kehlani: Summer Festival", 59.99m, 59.99m },
                    { new Guid("2d4db6ca-1d76-46a0-aa4a-d1ec1a2bb923"), "Future", new DateTime(2026, 1, 26, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8986), "The electrifying Future brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Future: Legends Tour", 79.99m, 79.99m },
                    { new Guid("2d634a99-5bbd-4bb9-9aba-9b5d08c7364b"), "Ed Sheeran", new DateTime(2025, 9, 19, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8171), "Experience the magic of Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Ed Sheeran: Live in Concert", 29.99m, 29.99m },
                    { new Guid("2e3909cf-fe1a-4613-bd28-5beab2ec3ef3"), "Justin Bieber", new DateTime(2025, 10, 16, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8344), "An unforgettable night with Justin Bieber showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Justin Bieber: Stadium Tour", 119.99m, 119.99m },
                    { new Guid("2e3ae5b7-1146-4a1e-8bea-ccc090a685ce"), "Selena Gomez & BTS", new DateTime(2028, 9, 18, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4705), "Experience the magic of Selena Gomez & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Selena Gomez & BTS: Unplugged", 69.99m, 69.99m },
                    { new Guid("2e4836f9-dee1-4357-8716-5ce7e534f31a"), "Shawn Mendes & Beyoncé", new DateTime(2027, 9, 9, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2428), "Experience the magic of Shawn Mendes & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Shawn Mendes & Beyoncé: Live in Concert", 149.99m, 149.99m },
                    { new Guid("2e9a8458-91b0-4922-89c9-5b1774ec226b"), "Khalid & BTS", new DateTime(2028, 10, 18, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4879), "Experience the magic of Khalid & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Khalid & BTS: Live in Concert", 169.99m, 169.99m },
                    { new Guid("2eb6d517-0c77-4c19-80b9-5f6320fa861f"), "Coldplay & BTS", new DateTime(2028, 7, 5, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4271), "Experience the magic of Coldplay & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Coldplay & BTS: Farewell Tour", 199.99m, 199.99m },
                    { new Guid("2f2e617a-32cb-43f2-8b67-1b1b539bedf6"), "Lil Uzi Vert & Ed Sheeran", new DateTime(2027, 3, 13, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1360), "Experience the magic of Lil Uzi Vert & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Lil Uzi Vert & Ed Sheeran: Live in Concert", 119.99m, 119.99m },
                    { new Guid("304447b5-3c2c-45ed-86de-a724c5adef88"), "5 Seconds of Summer", new DateTime(2026, 5, 2, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9529), "Experience the magic of 5 Seconds of Summer in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "5 Seconds of Summer: Live in Concert", 19.99m, 19.99m },
                    { new Guid("308ebbb8-c6ec-40e5-9cda-acba1a8431da"), "Ed Sheeran & BTS", new DateTime(2028, 5, 18, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3970), "An unforgettable night with Ed Sheeran & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Ed Sheeran & BTS: Stadium Tour", 39.99m, 39.99m },
                    { new Guid("30fd0bd7-91ea-45da-a0a0-ec89b8903486"), "Dan + Shay", new DateTime(2026, 6, 13, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9759), "An unforgettable night with Dan + Shay showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Dan + Shay: World Tour", 159.99m, 159.99m },
                    { new Guid("311c82d1-2cc1-47cc-9d8a-4c60d6ac35e4"), "The Kid LAROI & Ed Sheeran", new DateTime(2026, 12, 19, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(888), "The Kid LAROI & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "The Kid LAROI & Ed Sheeran: Greatest Hits Tour", 29.99m, 29.99m },
                    { new Guid("31ff03e0-b0fc-40c4-a800-be3a4beee81d"), "Billie Eilish & BTS", new DateTime(2028, 6, 5, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4083), "Experience the magic of Billie Eilish & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Billie Eilish & BTS: Live in Concert", 99.99m, 99.99m },
                    { new Guid("322d2a2e-4144-4e6a-94e1-aa510971c842"), "Eminem & Drake", new DateTime(2029, 6, 12, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6256), "An unforgettable night with Eminem & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Eminem & Drake: Summer Festival", 199.99m, 199.99m },
                    { new Guid("331bfd43-a438-48e6-a0ff-112b8da154e6"), "Coldplay & Drake", new DateTime(2029, 5, 25, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6169), "The electrifying Coldplay & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Coldplay & Drake: Legends Tour", 139.99m, 139.99m },
                    { new Guid("33717686-c6ad-4aa8-b270-f1dbd348bc1a"), "Travis Scott & Beyoncé", new DateTime(2027, 8, 31, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2382), "Travis Scott & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Travis Scott & Beyoncé: Anniversary Tour", 119.99m, 119.99m },
                    { new Guid("33b938b7-ccaf-423e-8454-dde7b628892d"), "Calvin Harris & BTS", new DateTime(2028, 8, 28, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4599), "The electrifying Calvin Harris & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Calvin Harris & BTS: Legends Tour", 189.99m, 189.99m },
                    { new Guid("343428fd-3552-44f6-8961-c8e842556779"), "Young Thug", new DateTime(2026, 7, 16, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9959), "Experience the magic of Young Thug in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Young Thug: Farewell Tour", 79.99m, 79.99m },
                    { new Guid("365416b3-034f-4ea4-8a75-a62bd5b2c020"), "Jason Derulo & BTS", new DateTime(2029, 3, 2, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5681), "Experience the magic of Jason Derulo & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Jason Derulo & BTS: Live in Concert", 49.99m, 49.99m },
                    { new Guid("367ec36c-0938-4527-8b3b-c01b7112a9ac"), "Imagine Dragons", new DateTime(2025, 11, 9, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8495), "Imagine Dragons returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Imagine Dragons: Greatest Hits Tour", 199.99m, 199.99m },
                    { new Guid("3867fd11-a509-47c9-9c55-fbeb1dc8cc27"), "Anitta", new DateTime(2026, 6, 1, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9699), "Experience the magic of Anitta in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Anitta: Farewell Tour", 119.99m, 119.99m },
                    { new Guid("38983fb1-07bd-40ed-b39b-42bc631c85c3"), "Demi Lovato", new DateTime(2026, 4, 8, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9387), "Demi Lovato returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Demi Lovato: The Sessions", 129.99m, 129.99m },
                    { new Guid("38fb3f52-15a1-4994-85dd-c4066d9cfe83"), "Eminem & Beyoncé", new DateTime(2027, 9, 3, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2396), "The electrifying Eminem & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Eminem & Beyoncé: Legends Tour", 129.99m, 129.99m },
                    { new Guid("39d69e08-4a1d-4eb9-8271-c4ad640cf921"), "Olivia Rodrigo & Ed Sheeran", new DateTime(2026, 11, 10, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(642), "An unforgettable night with Olivia Rodrigo & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Olivia Rodrigo & Ed Sheeran: Summer Festival", 89.99m, 89.99m },
                    { new Guid("3a2038d4-c7a1-400f-88b8-67ae7dad0a9f"), "Daddy Yankee & Beyoncé", new DateTime(2027, 10, 24, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2695), "Experience the magic of Daddy Yankee & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Daddy Yankee & Beyoncé: Live in Concert", 109.99m, 109.99m },
                    { new Guid("3a6465be-c993-49c4-9589-9aff82690abe"), "Harry Styles & Beyoncé", new DateTime(2027, 7, 20, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2131), "The electrifying Harry Styles & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Harry Styles & Beyoncé: Legends Tour", 169.99m, 169.99m },
                    { new Guid("3b76f92e-73be-467e-9ea2-394840d8fa46"), "Lil Uzi Vert & Beyoncé", new DateTime(2028, 1, 31, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3317), "The electrifying Lil Uzi Vert & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Lil Uzi Vert & Beyoncé: The Experience", 59.99m, 59.99m },
                    { new Guid("3c4a0d47-6ba0-478e-8a62-863ed0e925bb"), "Ariana Grande & Ed Sheeran", new DateTime(2026, 9, 8, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(271), "The electrifying Ariana Grande & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Ariana Grande & Ed Sheeran: Legends Tour", 69.99m, 69.99m },
                    { new Guid("3c54402d-9861-4e42-90a1-1409595253ce"), "Zedd & BTS", new DateTime(2029, 3, 11, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5727), "The electrifying Zedd & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Zedd & BTS: The Experience", 79.99m, 79.99m },
                    { new Guid("3cc2afbb-a7dd-4c07-b3ce-a46c74dfddb3"), "Martin Garrix & BTS", new DateTime(2028, 10, 27, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4943), "The electrifying Martin Garrix & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Martin Garrix & BTS: The Experience", 199.99m, 199.99m },
                    { new Guid("3ce4f7a6-a4c3-4bd1-b787-e6d20c4d3821"), "Avicii & Ed Sheeran", new DateTime(2027, 5, 12, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1738), "Experience the magic of Avicii & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Avicii & Ed Sheeran: Unplugged", 129.99m, 129.99m },
                    { new Guid("3d46a779-822a-44e7-84e3-d6da9f37fcbf"), "Sam Smith & BTS", new DateTime(2028, 10, 24, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4908), "Sam Smith & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Sam Smith & BTS: Greatest Hits Tour", 189.99m, 189.99m },
                    { new Guid("3d737566-9c33-43a2-964d-652d41f9b745"), "Jonas Brothers & Beyoncé", new DateTime(2027, 11, 2, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2739), "The electrifying Jonas Brothers & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Jonas Brothers & Beyoncé: The Experience", 139.99m, 139.99m },
                    { new Guid("3dbd6f46-7d63-4b41-8862-9debe9beefba"), "Adele & Beyoncé", new DateTime(2027, 7, 11, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2086), "Experience the magic of Adele & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Adele & Beyoncé: Farewell Tour", 139.99m, 139.99m },
                    { new Guid("3ddc8433-32f7-4d3f-86f2-7188bf9c0122"), "G-Eazy", new DateTime(2026, 6, 10, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9745), "The electrifying G-Eazy brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "G-Eazy: Legends Tour", 149.99m, 149.99m },
                    { new Guid("3f1d58a5-fb84-47a2-b0fe-f5181c381ce0"), "KAROL G", new DateTime(2026, 4, 20, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9445), "Join KAROL G for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "KAROL G: Comeback Tour", 169.99m, 169.99m },
                    { new Guid("3f35ce2b-24f8-49de-b663-da1a82951bcc"), "David Guetta & Ed Sheeran", new DateTime(2027, 1, 3, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(961), "David Guetta & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "David Guetta & Ed Sheeran: The Sessions", 79.99m, 79.99m },
                    { new Guid("3f9a6bf4-7173-42e5-9d97-2d7a4ac5e335"), "Tiësto", new DateTime(2026, 4, 26, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9498), "The electrifying Tiësto brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Tiësto: Legends Tour", 189.99m, 189.99m },
                    { new Guid("3fb9a6d3-da9b-4132-893d-6e7e954fd412"), "Drake", new DateTime(2029, 4, 16, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5932), "Experience the magic of Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Drake: Live in Concert", 199.99m, 199.99m },
                    { new Guid("416b5648-2478-48cc-bedc-627a53014a2b"), "Zedd", new DateTime(2026, 7, 13, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9944), "An unforgettable night with Zedd showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Zedd: Stadium Tour", 69.99m, 69.99m },
                    { new Guid("4218d8b0-7b94-4582-9795-e0bc8307792f"), "Zara Larsson & Ed Sheeran", new DateTime(2027, 3, 7, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1315), "The electrifying Zara Larsson & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Zara Larsson & Ed Sheeran: Legends Tour", 99.99m, 99.99m },
                    { new Guid("4220f8bc-ee6d-4568-b092-cb94b9db2b00"), "Lewis Capaldi & Drake", new DateTime(2029, 7, 6, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6398), "Lewis Capaldi & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Lewis Capaldi & Drake: Anniversary Tour", 89.99m, 89.99m },
                    { new Guid("42b8ecb4-d1e4-4416-b537-bb07ae0cbc79"), "Demi Lovato & Beyoncé", new DateTime(2028, 1, 16, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3243), "The electrifying Demi Lovato & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Demi Lovato & Beyoncé: Legends Tour", 199.99m, 199.99m },
                    { new Guid("43248ccb-85dc-4203-b91c-6341c5646464"), "5 Seconds of Summer & Ed Sheeran", new DateTime(2027, 3, 22, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1406), "The electrifying 5 Seconds of Summer & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "5 Seconds of Summer & Ed Sheeran: The Experience", 149.99m, 149.99m },
                    { new Guid("4379e8ac-d487-4173-84fb-448cee5257ac"), "The Kid LAROI & BTS", new DateTime(2028, 9, 27, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4772), "The electrifying The Kid LAROI & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "The Kid LAROI & BTS: Acoustic Night", 99.99m, 99.99m },
                    { new Guid("439773ac-9d12-4c5b-9294-6cc7975bc077"), "Charlie Puth & BTS", new DateTime(2028, 10, 21, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4894), "Join Charlie Puth & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Charlie Puth & BTS: Reunion Tour", 179.99m, 179.99m },
                    { new Guid("4397d272-827c-4d79-8aba-5c9788eca5c5"), "Meghan Trainor", new DateTime(2026, 6, 16, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9773), "Experience the magic of Meghan Trainor in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Meghan Trainor: Live in Concert", 169.99m, 169.99m },
                    { new Guid("44c3cf12-8152-41c6-a357-2dbb940bfec5"), "Travis Scott & BTS", new DateTime(2028, 7, 20, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4347), "Experience the magic of Travis Scott & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Travis Scott & BTS: Live in Concert", 59.99m, 59.99m },
                    { new Guid("4503423a-e6e9-4a50-9882-930b9ee5663a"), "Juice WRLD & BTS", new DateTime(2028, 10, 3, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4803), "Experience the magic of Juice WRLD & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Juice WRLD & BTS: Farewell Tour", 119.99m, 119.99m },
                    { new Guid("4576cd89-1b78-4530-b48f-b78fd806236f"), "Shawn Mendes & Ed Sheeran", new DateTime(2026, 10, 20, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(537), "Shawn Mendes & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Shawn Mendes & Ed Sheeran: Anniversary Tour", 19.99m, 19.99m },
                    { new Guid("477a1c52-ae93-42fa-9d6b-3d566fdd117b"), "Bastille", new DateTime(2026, 5, 26, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9646), "The electrifying Bastille brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Bastille: Acoustic Night", 99.99m, 99.99m },
                    { new Guid("49d86956-6d93-4c75-91aa-253cade68c7f"), "Tiësto & BTS", new DateTime(2028, 12, 23, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5247), "Tiësto & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Tiësto & BTS: The Sessions", 199.99m, 199.99m },
                    { new Guid("4a71c91e-2171-41cb-94ce-377d5ba0fd40"), "Lauv & Beyoncé", new DateTime(2028, 4, 27, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3843), "Lauv & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Lauv & Beyoncé: Greatest Hits Tour", 159.99m, 159.99m },
                    { new Guid("4b6fe349-e9f5-4659-9cd0-dd6bbb121c1c"), "Eminem & Ed Sheeran", new DateTime(2026, 10, 14, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(487), "Experience the magic of Eminem & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Eminem & Ed Sheeran: Farewell Tour", 189.99m, 189.99m },
                    { new Guid("4b95141f-90bd-4630-90bf-aab053e2bb8d"), "Tones and I & BTS", new DateTime(2028, 11, 29, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5128), "An unforgettable night with Tones and I & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Tones and I & BTS: World Tour", 119.99m, 119.99m },
                    { new Guid("4b95de1c-bb34-4459-b253-65f033cb5102"), "Rosalía & Beyoncé", new DateTime(2028, 1, 7, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3198), "Experience the magic of Rosalía & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Rosalía & Beyoncé: Farewell Tour", 169.99m, 169.99m },
                    { new Guid("4c76ad0f-62c8-42ef-b459-70f444424edb"), "Avicii & BTS", new DateTime(2029, 2, 18, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5620), "Join Avicii & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Avicii & BTS: Comeback Tour", 199.99m, 199.99m },
                    { new Guid("4d16287e-d209-4bc1-97fd-9aa843d089c7"), "Megan Thee Stallion & Drake", new DateTime(2029, 8, 20, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6667), "Megan Thee Stallion & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Megan Thee Stallion & Drake: Anniversary Tour", 49.99m, 49.99m },
                    { new Guid("4d4bf6d4-0d5f-49a5-9d1b-f226fab24c18"), "Little Mix", new DateTime(2026, 5, 8, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9558), "Little Mix returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Little Mix: Greatest Hits Tour", 39.99m, 39.99m },
                    { new Guid("4da78141-d978-4a90-b79c-57d93a20ee0a"), "Elton John & BTS", new DateTime(2028, 10, 15, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4862), "An unforgettable night with Elton John & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Elton John & BTS: World Tour", 159.99m, 159.99m },
                    { new Guid("4e10f08b-c0c1-434b-80b9-0102c6afe525"), "The Weeknd & Ed Sheeran", new DateTime(2026, 8, 24, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(166), "The electrifying The Weeknd & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "The Weeknd & Ed Sheeran: Acoustic Night", 19.99m, 19.99m },
                    { new Guid("4e36bf23-5738-4dfa-aefc-a5de494ff09e"), "Olivia Rodrigo", new DateTime(2025, 12, 21, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8776), "Join Olivia Rodrigo for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Olivia Rodrigo: Reunion Tour", 149.99m, 149.99m },
                    { new Guid("4e444149-bd57-4173-9c56-4fabd349c837"), "Taylor Swift", new DateTime(2025, 9, 16, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8114), "An unforgettable night with Taylor Swift showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Taylor Swift: World Tour", 19.99m, 19.99m },
                    { new Guid("4ea26c15-6df9-4c91-9a87-9e8941720e32"), "Camila Cabello & Drake", new DateTime(2029, 6, 21, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6324), "Camila Cabello & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Camila Cabello & Drake: The Sessions", 39.99m, 39.99m },
                    { new Guid("4f0a232a-2c64-4183-bd97-6401cccd4cb2"), "Luke Combs & BTS", new DateTime(2028, 11, 8, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5002), "Luke Combs & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Luke Combs & BTS: The Sessions", 49.99m, 49.99m },
                    { new Guid("4f377302-71b1-41e9-979e-f42ae724fd00"), "The Chainsmokers & Drake", new DateTime(2029, 7, 15, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6444), "Experience the magic of The Chainsmokers & Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "The Chainsmokers & Drake: Live in Concert", 119.99m, 119.99m },
                    { new Guid("4f3c9c29-65d4-496c-8ae4-f9673f1e0777"), "J Balvin & Ed Sheeran", new DateTime(2026, 10, 5, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(444), "J Balvin & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "J Balvin & Ed Sheeran: The Sessions", 159.99m, 159.99m },
                    { new Guid("4fd44eb9-3b2f-4eb9-b2c1-26fb54a82a6e"), "Jack Harlow & BTS", new DateTime(2028, 11, 17, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5047), "Experience the magic of Jack Harlow & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Jack Harlow & BTS: Farewell Tour", 79.99m, 79.99m },
                    { new Guid("50f16bb3-e002-470f-869d-0ec4ee3eb55d"), "Lil Nas X", new DateTime(2025, 12, 24, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8791), "Lil Nas X returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Lil Nas X: Greatest Hits Tour", 159.99m, 159.99m },
                    { new Guid("513625ff-75d2-41a1-8e09-b56d41da4a29"), "Lil Nas X & BTS", new DateTime(2028, 8, 22, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4543), "Join Lil Nas X & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Lil Nas X & BTS: Comeback Tour", 169.99m, 169.99m },
                    { new Guid("5167c2db-50a2-4ee2-808b-ae9b28af39cc"), "The Kid LAROI & Beyoncé", new DateTime(2027, 11, 8, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2800), "Experience the magic of The Kid LAROI & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "The Kid LAROI & Beyoncé: Unplugged", 159.99m, 159.99m },
                    { new Guid("51b9e8df-ad25-4aef-9d70-d38b37dc2aad"), "The Weeknd & BTS", new DateTime(2028, 6, 2, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4069), "An unforgettable night with The Weeknd & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "The Weeknd & BTS: World Tour", 89.99m, 89.99m },
                    { new Guid("522b9462-9033-4183-b076-153bcec52d8e"), "Fall Out Boy", new DateTime(2026, 6, 25, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9816), "The electrifying Fall Out Boy brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Fall Out Boy: The Experience", 199.99m, 199.99m },
                    { new Guid("5269c1c1-ae99-405e-a2c0-1fe3c0e17a42"), "Katy Perry & BTS", new DateTime(2028, 7, 11, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4301), "Katy Perry & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Katy Perry & BTS: Anniversary Tour", 29.99m, 29.99m },
                    { new Guid("52aaec0e-140a-48fb-8045-562fe9651e40"), "Jonas Brothers", new DateTime(2026, 1, 23, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8971), "Jonas Brothers returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Jonas Brothers: Anniversary Tour", 69.99m, 69.99m },
                    { new Guid("52d449ee-255b-4fe7-9f14-d421bd0a4fec"), "Demi Lovato & BTS", new DateTime(2028, 12, 5, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5160), "Join Demi Lovato & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Demi Lovato & BTS: Reunion Tour", 139.99m, 139.99m },
                    { new Guid("5321e747-d096-4344-ad0e-03e5d74632ac"), "Lady Gaga & BTS", new DateTime(2028, 6, 11, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4113), "Lady Gaga & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Lady Gaga & BTS: Greatest Hits Tour", 119.99m, 119.99m },
                    { new Guid("544a1512-0e26-4fa0-9550-b4213b01b374"), "Camila Cabello & BTS", new DateTime(2028, 8, 1, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4438), "An unforgettable night with Camila Cabello & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Camila Cabello & BTS: Summer Festival", 99.99m, 99.99m },
                    { new Guid("5525638e-24ec-4203-8aa0-941f2e04c77c"), "Beyoncé", new DateTime(2025, 9, 22, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8186), "Join Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Beyoncé: Reunion Tour", 39.99m, 39.99m },
                    { new Guid("5588dd39-8f60-4015-b01d-34f75036be80"), "Kendrick Lamar & Drake", new DateTime(2029, 5, 19, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6117), "Join Kendrick Lamar & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Kendrick Lamar & Drake: Comeback Tour", 119.99m, 119.99m },
                    { new Guid("56a29570-91aa-4ce1-8670-2a41fe683446"), "Future & Beyoncé", new DateTime(2027, 11, 5, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2755), "An unforgettable night with Future & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Future & Beyoncé: Summer Festival", 149.99m, 149.99m },
                    { new Guid("56a865da-d0b4-4215-9374-d3520d52a4d5"), "Dua Lipa & Ed Sheeran", new DateTime(2026, 9, 17, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(318), "Join Dua Lipa & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Dua Lipa & Ed Sheeran: Reunion Tour", 99.99m, 99.99m },
                    { new Guid("57a02302-0c36-4a90-ae17-4a2ca692fbe3"), "Lil Baby & Drake", new DateTime(2029, 10, 4, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6903), "Lil Baby & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Lil Baby & Drake: Anniversary Tour", 199.99m, 199.99m },
                    { new Guid("5887c9f9-0d38-4734-b920-f19b2cc8b6ee"), "Miley Cyrus", new DateTime(2026, 2, 10, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9060), "The electrifying Miley Cyrus brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Miley Cyrus: The Experience", 129.99m, 129.99m },
                    { new Guid("58a49bd2-ddf1-477b-87be-a5995f5af29d"), "Miley Cyrus & Beyoncé", new DateTime(2027, 11, 20, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2863), "An unforgettable night with Miley Cyrus & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Miley Cyrus & Beyoncé: Stadium Tour", 199.99m, 199.99m },
                    { new Guid("58ef4467-e322-4f3a-b2d2-3001c1207555"), "Elton John & Drake", new DateTime(2029, 9, 4, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6742), "Elton John & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Elton John & Drake: Greatest Hits Tour", 99.99m, 99.99m },
                    { new Guid("596fbc7f-1b63-44a5-9494-b19db5e88ffb"), "Kygo & BTS", new DateTime(2028, 10, 6, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4817), "Join Kygo & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Kygo & BTS: Comeback Tour", 129.99m, 129.99m },
                    { new Guid("5a64ae9a-0b02-40a7-b93b-4615305c9b4f"), "Alan Walker & Ed Sheeran", new DateTime(2027, 3, 1, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1287), "Join Alan Walker & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Alan Walker & Ed Sheeran: Comeback Tour", 79.99m, 79.99m },
                    { new Guid("5b145460-204f-48e1-adc4-0754ead45026"), "Ava Max & Beyoncé", new DateTime(2027, 12, 17, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3070), "The electrifying Ava Max & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Ava Max & Beyoncé: The Experience", 99.99m, 99.99m },
                    { new Guid("5b6fb50e-c170-4ba6-aa4a-e4ddb5703c35"), "David Guetta & Beyoncé", new DateTime(2027, 11, 23, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2877), "Experience the magic of David Guetta & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "David Guetta & Beyoncé: Farewell Tour", 19.99m, 19.99m },
                    { new Guid("5bc66044-5440-4ca8-8922-e6c02a2a1673"), "Doja Cat & BTS", new DateTime(2028, 8, 4, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4453), "Experience the magic of Doja Cat & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Doja Cat & BTS: Unplugged", 109.99m, 109.99m },
                    { new Guid("5bf4acdb-05ff-4ec3-860d-5ef8cd019ba8"), "Beyoncé & Ed Sheeran", new DateTime(2026, 8, 12, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(107), "An unforgettable night with Beyoncé & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Beyoncé & Ed Sheeran: Summer Festival", 169.99m, 169.99m },
                    { new Guid("5cad066b-1b97-4397-b5e8-1c28fd305266"), "Alicia Keys & Beyoncé", new DateTime(2028, 2, 6, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3368), "Experience the magic of Alicia Keys & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Alicia Keys & Beyoncé: Unplugged", 79.99m, 79.99m },
                    { new Guid("5d774431-7464-428f-beb4-fd7bdaa92994"), "Marshmello & Drake", new DateTime(2029, 7, 24, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6512), "The electrifying Marshmello & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Marshmello & Drake: The Experience", 149.99m, 149.99m },
                    { new Guid("5ed021c4-9029-47e0-aa25-6090efc02d18"), "The Chainsmokers & Ed Sheeran", new DateTime(2026, 11, 16, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(692), "Join The Chainsmokers & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "The Chainsmokers & Ed Sheeran: Live at Home", 109.99m, 109.99m },
                    { new Guid("5ee075ec-7a8d-4d23-8fdb-09f49b32de7a"), "DaBaby & Beyoncé", new DateTime(2027, 12, 23, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3100), "Experience the magic of DaBaby & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "DaBaby & Beyoncé: Unplugged", 119.99m, 119.99m },
                    { new Guid("5f84a2f3-1ca1-46a4-b5c1-26218b724f83"), "Kehlani & BTS", new DateTime(2029, 1, 10, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5378), "The electrifying Kehlani & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Kehlani & BTS: Legends Tour", 69.99m, 69.99m },
                    { new Guid("5fc3ca71-d2ee-4d74-a5c5-519eb5bfb62b"), "Olivia Rodrigo & BTS", new DateTime(2028, 8, 19, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4528), "Experience the magic of Olivia Rodrigo & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Olivia Rodrigo & BTS: Farewell Tour", 159.99m, 159.99m },
                    { new Guid("5fce1582-cbd2-43b9-9bce-6b1e4df714c4"), "Sam Smith & Beyoncé", new DateTime(2027, 12, 5, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2935), "An unforgettable night with Sam Smith & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Sam Smith & Beyoncé: World Tour", 59.99m, 59.99m },
                    { new Guid("5fef34c1-992c-4d24-a8d5-ec4044aa133c"), "Luke Combs", new DateTime(2026, 3, 12, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9230), "The electrifying Luke Combs brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Luke Combs: Legends Tour", 39.99m, 39.99m },
                    { new Guid("60880711-b993-4fe6-93db-d515d9049b38"), "Glass Animals", new DateTime(2026, 4, 5, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9373), "Join Glass Animals for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Glass Animals: Live at Home", 119.99m, 119.99m },
                    { new Guid("60eed1df-1e18-4706-a6b3-55ffc5f61243"), "Offset", new DateTime(2026, 7, 7, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9896), "Offset returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Offset: The Sessions", 49.99m, 49.99m },
                    { new Guid("62a47ca3-5a5c-4419-87f4-7923a1f9e313"), "Anitta & Beyoncé", new DateTime(2028, 3, 10, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3578), "Join Anitta & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Anitta & Beyoncé: Reunion Tour", 189.99m, 189.99m },
                    { new Guid("62b993f5-476e-4a85-9d0d-1f6953407347"), "Ava Max & BTS", new DateTime(2028, 11, 5, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4987), "Join Ava Max & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Ava Max & BTS: Live at Home", 39.99m, 39.99m },
                    { new Guid("63944325-a563-4a0d-885e-c12e6806f7f1"), "Coldplay", new DateTime(2025, 11, 6, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8481), "Join Coldplay for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Coldplay: Reunion Tour", 189.99m, 189.99m },
                    { new Guid("6444a912-7824-4118-b60c-182209d0e962"), "Troye Sivan", new DateTime(2026, 6, 4, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9714), "Join Troye Sivan for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Troye Sivan: Comeback Tour", 129.99m, 129.99m },
                    { new Guid("6446a763-2875-469f-bb6b-117f98891e10"), "Zara Larsson", new DateTime(2026, 4, 17, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9430), "Experience the magic of Zara Larsson in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Zara Larsson: Farewell Tour", 159.99m, 159.99m },
                    { new Guid("649f1d57-7cff-45e7-8105-c5bd175e6924"), "J Balvin & Beyoncé", new DateTime(2027, 8, 25, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2330), "Experience the magic of J Balvin & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "J Balvin & Beyoncé: Farewell Tour", 99.99m, 99.99m },
                    { new Guid("6531282a-0652-4540-bdd8-a8f5ba404291"), "Halsey & BTS", new DateTime(2028, 8, 13, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4500), "The electrifying Halsey & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Halsey & BTS: Acoustic Night", 139.99m, 139.99m },
                    { new Guid("65f47a51-35c1-4d47-b0a6-650d3f72cd94"), "Taylor Swift", new DateTime(2026, 8, 6, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(77), "Taylor Swift returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Taylor Swift: Greatest Hits Tour", 149.99m, 149.99m },
                    { new Guid("66232a6b-a66f-4170-bedf-f7532c760b5c"), "Billie Eilish", new DateTime(2025, 10, 7, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8264), "Join Billie Eilish for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Billie Eilish: Live at Home", 89.99m, 89.99m },
                    { new Guid("6665c92f-5708-4f40-9dc2-cf242d779165"), "Charlie Puth & Drake", new DateTime(2029, 9, 10, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6770), "An unforgettable night with Charlie Puth & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Charlie Puth & Drake: Summer Festival", 119.99m, 119.99m },
                    { new Guid("67027da6-3d0c-4bc3-9793-05872d9fa8d6"), "Nicky Jam & Ed Sheeran", new DateTime(2027, 4, 18, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1570), "Nicky Jam & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Nicky Jam & Ed Sheeran: Anniversary Tour", 49.99m, 49.99m },
                    { new Guid("67140273-0d17-46f5-9841-cc304fa32262"), "Jonas Brothers & BTS", new DateTime(2028, 9, 21, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4719), "Join Jonas Brothers & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Jonas Brothers & BTS: Live at Home", 79.99m, 79.99m },
                    { new Guid("67c907ac-fe4c-4d30-ae68-b9f11475768b"), "Harry Styles & Drake", new DateTime(2029, 4, 28, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6014), "An unforgettable night with Harry Styles & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Harry Styles & Drake: Summer Festival", 49.99m, 49.99m },
                    { new Guid("68d2f51e-c712-4920-b410-539877ae1efe"), "Anne-Marie & BTS", new DateTime(2029, 3, 8, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5710), "Anne-Marie & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Anne-Marie & BTS: Greatest Hits Tour", 69.99m, 69.99m },
                    { new Guid("696eb979-6608-4abe-a221-1b225fc4f783"), "Tame Impala", new DateTime(2026, 3, 24, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9313), "Tame Impala returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Tame Impala: Greatest Hits Tour", 79.99m, 79.99m },
                    { new Guid("699c87e6-2081-42e2-8edc-9a5b9cf7d4e9"), "Dua Lipa", new DateTime(2025, 10, 28, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8436), "The electrifying Dua Lipa brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Dua Lipa: Legends Tour", 159.99m, 159.99m },
                    { new Guid("69bad7ec-adee-45da-b69d-c696593d6cac"), "Martin Garrix & Ed Sheeran", new DateTime(2027, 1, 18, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1060), "Martin Garrix & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Martin Garrix & Ed Sheeran: Anniversary Tour", 129.99m, 129.99m },
                    { new Guid("69e211f1-15b6-4cdf-bb79-c73702be5d14"), "Ed Sheeran", new DateTime(2026, 8, 9, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(92), "The electrifying Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Ed Sheeran: The Experience", 159.99m, 159.99m },
                    { new Guid("6a2ab17e-56c8-4454-a91e-02129445a752"), "Glass Animals & BTS", new DateTime(2028, 12, 2, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5143), "Experience the magic of Glass Animals & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Glass Animals & BTS: Live in Concert", 129.99m, 129.99m },
                    { new Guid("6a3b87fd-4e7c-4d88-8a05-6bc0e37993f6"), "Robin Schulz & Ed Sheeran", new DateTime(2027, 5, 21, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1783), "The electrifying Robin Schulz & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Robin Schulz & Ed Sheeran: Acoustic Night", 159.99m, 159.99m },
                    { new Guid("6ae7d192-cfd4-4379-8c56-e2435d81d8d4"), "Katy Perry & Drake", new DateTime(2029, 5, 31, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6198), "Experience the magic of Katy Perry & Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Katy Perry & Drake: Live in Concert", 159.99m, 159.99m },
                    { new Guid("6bfb1957-9859-4c2d-97f4-8203c3710175"), "Sia & BTS", new DateTime(2028, 9, 15, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4690), "An unforgettable night with Sia & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Sia & BTS: Summer Festival", 59.99m, 59.99m },
                    { new Guid("6c4d4dc0-1917-4677-9689-898742c1260c"), "Tyler, The Creator & Ed Sheeran", new DateTime(2027, 4, 12, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1538), "Experience the magic of Tyler, The Creator & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Tyler, The Creator & Ed Sheeran: Farewell Tour", 29.99m, 29.99m },
                    { new Guid("6c8c4183-6ad0-4bff-917c-8cdf7b4816d9"), "Niall Horan & Drake", new DateTime(2029, 9, 22, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6844), "The electrifying Niall Horan & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Niall Horan & Drake: Acoustic Night", 159.99m, 159.99m },
                    { new Guid("6da0e172-4020-4192-add2-9555b0483771"), "Billie Eilish & Drake", new DateTime(2029, 4, 25, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5998), "The electrifying Billie Eilish & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Billie Eilish & Drake: The Experience", 39.99m, 39.99m },
                    { new Guid("6dbe3815-b16c-4cb8-9aa8-edb3eec82484"), "Travis Scott", new DateTime(2025, 11, 21, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8571), "Join Travis Scott for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Travis Scott: Live at Home", 49.99m, 49.99m },
                    { new Guid("6de1db8f-f421-431a-8b84-5167eb4464f9"), "The Chainsmokers & BTS", new DateTime(2028, 8, 25, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4557), "The Chainsmokers & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "The Chainsmokers & BTS: Anniversary Tour", 179.99m, 179.99m },
                    { new Guid("6f0c0882-c528-49be-b8f8-ff4c103189ac"), "Lana Del Rey", new DateTime(2026, 3, 3, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9187), "Experience the magic of Lana Del Rey in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Lana Del Rey: Farewell Tour", 199.99m, 199.99m },
                    { new Guid("6fbfee98-200d-42e8-a605-5256fb692ae2"), "Camila Cabello & Ed Sheeran", new DateTime(2026, 10, 23, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(552), "The electrifying Camila Cabello & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Camila Cabello & Ed Sheeran: Legends Tour", 29.99m, 29.99m },
                    { new Guid("70273272-0f3b-4d53-8757-f99bfb42e7d4"), "Charlie Puth & Ed Sheeran", new DateTime(2027, 1, 12, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1028), "Experience the magic of Charlie Puth & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Charlie Puth & Ed Sheeran: Farewell Tour", 109.99m, 109.99m },
                    { new Guid("70b69969-081b-4992-adbe-520da62f5c64"), "Marshmello & Ed Sheeran", new DateTime(2026, 11, 25, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(739), "An unforgettable night with Marshmello & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Marshmello & Ed Sheeran: Stadium Tour", 139.99m, 139.99m },
                    { new Guid("70cb1b59-6a2a-4e39-9135-75aeec4f0581"), "Madison Beer & Beyoncé", new DateTime(2028, 5, 6, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3911), "Experience the magic of Madison Beer & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Madison Beer & Beyoncé: Unplugged", 189.99m, 189.99m },
                    { new Guid("711bc706-c902-4777-9810-71952df4d70e"), "NCT 127", new DateTime(2026, 6, 19, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9788), "Join NCT 127 for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "NCT 127: Reunion Tour", 179.99m, 179.99m },
                    { new Guid("7171f6c0-4f39-4f92-9799-85ca96839725"), "Blackpink", new DateTime(2026, 1, 11, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8880), "The electrifying Blackpink brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Blackpink: Acoustic Night", 29.99m, 29.99m },
                    { new Guid("71783ff9-7877-4899-93bb-834ba5beb908"), "The Weeknd", new DateTime(2025, 10, 4, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8250), "Experience the magic of The Weeknd in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "The Weeknd: Unplugged", 79.99m, 79.99m },
                    { new Guid("7204d1f2-c681-45b0-8657-7643a7e45be5"), "Lana Del Rey & Ed Sheeran", new DateTime(2027, 1, 21, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1074), "The electrifying Lana Del Rey & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Lana Del Rey & Ed Sheeran: Legends Tour", 139.99m, 139.99m },
                    { new Guid("747ae6a8-8cdd-4274-9147-14fb5cd7f28f"), "BLACKPINK ROSÉ & Beyoncé", new DateTime(2028, 5, 3, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3897), "An unforgettable night with BLACKPINK ROSÉ & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "BLACKPINK ROSÉ & Beyoncé: Summer Festival", 179.99m, 179.99m },
                    { new Guid("748f1579-5149-4c69-8195-6788373141f5"), "Anitta & BTS", new DateTime(2029, 1, 28, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5483), "An unforgettable night with Anitta & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Anitta & BTS: Summer Festival", 129.99m, 129.99m },
                    { new Guid("74b528c0-5b03-43b4-9216-e06cc9cfd104"), "Glass Animals & Beyoncé", new DateTime(2028, 1, 13, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3228), "Glass Animals & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Glass Animals & Beyoncé: Anniversary Tour", 189.99m, 189.99m },
                    { new Guid("74b6d9fa-fa99-4310-842d-354e8c2753d7"), "Maroon 5 & Beyoncé", new DateTime(2027, 8, 28, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2366), "Join Maroon 5 & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Maroon 5 & Beyoncé: Comeback Tour", 109.99m, 109.99m },
                    { new Guid("753e6a15-641f-44ce-8fe9-78da8a37c09f"), "Justin Bieber & BTS", new DateTime(2028, 6, 14, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4128), "The electrifying Justin Bieber & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Justin Bieber & BTS: The Experience", 129.99m, 129.99m },
                    { new Guid("756b79e8-51a2-4949-9e06-a11e40b1d898"), "Martin Garrix & Beyoncé", new DateTime(2027, 12, 8, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3022), "Experience the magic of Martin Garrix & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Martin Garrix & Beyoncé: Live in Concert", 69.99m, 69.99m },
                    { new Guid("7596d18e-2b90-4ba5-9a03-3d77ea34d790"), "Anne-Marie", new DateTime(2026, 7, 10, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9911), "The electrifying Anne-Marie brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Anne-Marie: Acoustic Night", 59.99m, 59.99m },
                    { new Guid("75c8aacb-ed4e-4c93-b971-c76acf191855"), "Lauv", new DateTime(2026, 7, 19, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9973), "Join Lauv for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Lauv: Comeback Tour", 89.99m, 89.99m },
                    { new Guid("7601a4eb-7f98-4e64-b4aa-ebe4d4d830fb"), "Lil Baby & Ed Sheeran", new DateTime(2027, 2, 5, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1147), "The electrifying Lil Baby & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Lil Baby & Ed Sheeran: The Experience", 189.99m, 189.99m },
                    { new Guid("76146ee4-c46f-4f01-852f-941cde949f21"), "Camila Cabello & Beyoncé", new DateTime(2027, 9, 12, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2442), "Join Camila Cabello & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Camila Cabello & Beyoncé: Reunion Tour", 159.99m, 159.99m },
                    { new Guid("7629c32d-a289-4096-aee9-8e2f31522de2"), "Troye Sivan & Beyoncé", new DateTime(2028, 3, 13, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3593), "Troye Sivan & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Troye Sivan & Beyoncé: Greatest Hits Tour", 199.99m, 199.99m },
                    { new Guid("77130c6b-fce7-4d57-b9c0-162be24995e0"), "Post Malone & Drake", new DateTime(2029, 5, 10, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6073), "The electrifying Post Malone & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Post Malone & Drake: Acoustic Night", 89.99m, 89.99m },
                    { new Guid("77f73100-3a60-4fef-abbb-8b973cba27f5"), "James Arthur & BTS", new DateTime(2029, 3, 20, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5769), "Join James Arthur & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "James Arthur & BTS: Live at Home", 109.99m, 109.99m },
                    { new Guid("79169e79-49c7-4998-a7c7-216026af4fba"), "Bad Bunny & Beyoncé", new DateTime(2027, 9, 6, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2413), "An unforgettable night with Bad Bunny & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Bad Bunny & Beyoncé: World Tour", 139.99m, 139.99m },
                    { new Guid("79f59bcb-922a-464d-9161-988c07335b3b"), "5 Seconds of Summer & Beyoncé", new DateTime(2028, 2, 9, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3384), "Join 5 Seconds of Summer & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "5 Seconds of Summer & Beyoncé: Live at Home", 89.99m, 89.99m },
                    { new Guid("7a801b92-e4c4-430e-aa42-37e8ff5ba870"), "Post Malone & Ed Sheeran", new DateTime(2026, 9, 11, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(288), "An unforgettable night with Post Malone & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Post Malone & Ed Sheeran: World Tour", 79.99m, 79.99m },
                    { new Guid("7b316ccb-222d-4a60-ad1c-97ac02ac9735"), "J Balvin & Drake", new DateTime(2029, 6, 3, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6212), "Join J Balvin & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "J Balvin & Drake: Reunion Tour", 169.99m, 169.99m },
                    { new Guid("7de8f470-e03c-41c5-8102-5676330563a1"), "Tones and I & Beyoncé", new DateTime(2028, 1, 10, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3214), "Join Tones and I & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Tones and I & Beyoncé: Comeback Tour", 179.99m, 179.99m },
                    { new Guid("7e73b207-16b3-42a8-90d7-69c17c7870d2"), "Nicky Jam & Beyoncé", new DateTime(2028, 3, 7, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3562), "Experience the magic of Nicky Jam & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Nicky Jam & Beyoncé: Live in Concert", 179.99m, 179.99m },
                    { new Guid("7e7d6547-cebb-46f4-80c2-ddd4268857d2"), "Adele", new DateTime(2025, 10, 1, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8235), "An unforgettable night with Adele showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Adele: Summer Festival", 69.99m, 69.99m },
                    { new Guid("7f16ea30-b447-4eda-90e6-14afc4ba3c5d"), "Justin Bieber & Drake", new DateTime(2029, 5, 4, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6044), "Join Justin Bieber & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Justin Bieber & Drake: Live at Home", 69.99m, 69.99m },
                    { new Guid("7f1ded22-965f-4ca0-a2b4-229006e30951"), "Maroon 5 & Ed Sheeran", new DateTime(2026, 10, 8, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(458), "The electrifying Maroon 5 & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Maroon 5 & Ed Sheeran: Acoustic Night", 169.99m, 169.99m },
                    { new Guid("7f49729e-b4ea-4b1f-a34d-851d5e0d5f20"), "Lauv & Ed Sheeran", new DateTime(2027, 6, 8, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1895), "An unforgettable night with Lauv & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Lauv & Ed Sheeran: World Tour", 29.99m, 29.99m },
                    { new Guid("7f7b56a5-0f40-4ca0-abeb-4e8e9be25215"), "The Script", new DateTime(2026, 8, 3, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(62), "Join The Script for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "The Script: Reunion Tour", 139.99m, 139.99m },
                    { new Guid("7f8521b4-0d48-4e93-abb9-f1348e60ab6d"), "Cardi B & BTS", new DateTime(2028, 8, 7, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4469), "Join Cardi B & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Cardi B & BTS: Live at Home", 119.99m, 119.99m },
                    { new Guid("7fe1259d-be30-43ae-9b9c-e29e0d047bbd"), "LISA & BTS", new DateTime(2029, 3, 29, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5846), "An unforgettable night with LISA & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "LISA & BTS: Stadium Tour", 139.99m, 139.99m },
                    { new Guid("801e2be3-dd1d-4ddd-8d79-9c52586ad8b2"), "Maluma", new DateTime(2026, 3, 27, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9329), "The electrifying Maluma brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Maluma: The Experience", 89.99m, 89.99m },
                    { new Guid("80916bc8-bcb9-4a6d-b5af-3cc9f8ac4a92"), "KAROL G & Beyoncé", new DateTime(2028, 1, 28, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3303), "KAROL G & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "KAROL G & Beyoncé: Greatest Hits Tour", 49.99m, 49.99m },
                    { new Guid("8192e64d-49c7-4a29-ba01-0c1c282b04e7"), "BTS", new DateTime(2025, 9, 25, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8202), "BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "BTS: Greatest Hits Tour", 49.99m, 49.99m },
                    { new Guid("81b4e51e-b4c6-498b-9dd5-914c90c7b67f"), "Ava Max", new DateTime(2026, 3, 9, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9216), "Ava Max returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Ava Max: Anniversary Tour", 29.99m, 29.99m },
                    { new Guid("82550119-6afd-41a4-87a3-584a453ac0f0"), "YUNGBLUD", new DateTime(2026, 5, 11, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9572), "The electrifying YUNGBLUD brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "YUNGBLUD: The Experience", 49.99m, 49.99m },
                    { new Guid("82f3e4d9-4431-4302-8c4d-744cea0b9170"), "SEVENTEEN & BTS", new DateTime(2029, 2, 24, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5651), "The electrifying SEVENTEEN & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "SEVENTEEN & BTS: Legends Tour", 29.99m, 29.99m },
                    { new Guid("8464c67a-a245-499b-a0ca-95adc371d632"), "OneRepublic & BTS", new DateTime(2028, 12, 11, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5189), "The electrifying OneRepublic & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "OneRepublic & BTS: The Experience", 159.99m, 159.99m },
                    { new Guid("848e20e1-6607-4594-ab20-73b27d909671"), "Machine Gun Kelly", new DateTime(2026, 5, 17, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9603), "Experience the magic of Machine Gun Kelly in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Machine Gun Kelly: Unplugged", 69.99m, 69.99m },
                    { new Guid("85351872-3172-4054-b432-7cafed6b96d8"), "Ava Max & Ed Sheeran", new DateTime(2027, 1, 27, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1103), "Experience the magic of Ava Max & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Ava Max & Ed Sheeran: Live in Concert", 159.99m, 159.99m },
                    { new Guid("853b80d0-f15d-4703-85f7-5f2bae8e8dad"), "Khalid & Drake", new DateTime(2029, 9, 7, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6757), "The electrifying Khalid & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Khalid & Drake: The Experience", 109.99m, 109.99m },
                    { new Guid("85a46e30-c3c9-4727-8d36-389c4ab1b573"), "Marshmello & Beyoncé", new DateTime(2027, 10, 15, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2650), "Marshmello & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Marshmello & Beyoncé: Anniversary Tour", 79.99m, 79.99m },
                    { new Guid("86d519ea-eebe-458f-8d9f-a64cea9035f6"), "Lil Baby", new DateTime(2026, 3, 18, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9261), "Experience the magic of Lil Baby in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Lil Baby: Live in Concert", 59.99m, 59.99m },
                    { new Guid("88174415-0ee1-4a73-8829-1547d1a03753"), "Marshmello & BTS", new DateTime(2028, 9, 3, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4631), "Experience the magic of Marshmello & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Marshmello & BTS: Live in Concert", 19.99m, 19.99m },
                    { new Guid("881c2e7a-268f-436e-8310-1dd0aaa67099"), "Imagine Dragons & BTS", new DateTime(2028, 7, 8, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4286), "Join Imagine Dragons & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Imagine Dragons & BTS: Comeback Tour", 19.99m, 19.99m },
                    { new Guid("88b2549d-5e44-46d8-9e36-886b2da1bb4c"), "Dua Lipa & Beyoncé", new DateTime(2027, 8, 7, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2240), "An unforgettable night with Dua Lipa & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Dua Lipa & Beyoncé: Summer Festival", 39.99m, 39.99m },
                    { new Guid("8b2cf93a-3076-4da6-aa3f-bdf0b6eb3173"), "DaBaby & Drake", new DateTime(2029, 10, 1, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6888), "Join DaBaby & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "DaBaby & Drake: Comeback Tour", 189.99m, 189.99m },
                    { new Guid("8b2fedbd-27d9-47db-a53d-d33ddb5cae50"), "Ariana Grande & Beyoncé", new DateTime(2027, 7, 29, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2196), "Join Ariana Grande & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Ariana Grande & Beyoncé: Reunion Tour", 199.99m, 199.99m },
                    { new Guid("8bd165f6-031b-4950-a248-34f5ac424515"), "Panic! At The Disco & Ed Sheeran", new DateTime(2027, 4, 9, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1522), "An unforgettable night with Panic! At The Disco & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Panic! At The Disco & Ed Sheeran: Stadium Tour", 19.99m, 19.99m },
                    { new Guid("8be47cdc-43f1-48d6-b07a-347ead4408c9"), "Charlie Puth & Beyoncé", new DateTime(2027, 12, 2, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2920), "The electrifying Charlie Puth & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Charlie Puth & Beyoncé: Legends Tour", 49.99m, 49.99m },
                    { new Guid("8e37250c-ffcc-41ca-9ccb-ae062e198c8d"), "Bad Bunny & Ed Sheeran", new DateTime(2026, 10, 17, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(502), "Join Bad Bunny & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Bad Bunny & Ed Sheeran: Comeback Tour", 199.99m, 199.99m },
                    { new Guid("90f72e20-1458-41ed-8834-d6da14ac2f4c"), "Offset & BTS", new DateTime(2029, 3, 5, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5696), "Join Offset & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Offset & BTS: Reunion Tour", 59.99m, 59.99m },
                    { new Guid("9126c2da-52b6-4012-9afb-bb8d02173fef"), "Future & BTS", new DateTime(2028, 9, 24, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4735), "Future & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Future & BTS: The Sessions", 89.99m, 89.99m },
                    { new Guid("92214b97-6801-4863-8f86-635fb3758bed"), "YUNGBLUD & Ed Sheeran", new DateTime(2027, 3, 31, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1449), "Join YUNGBLUD & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "YUNGBLUD & Ed Sheeran: Live at Home", 179.99m, 179.99m },
                    { new Guid("9221c2a1-4e6e-417e-810c-c2d4dd05587e"), "Calvin Harris & Beyoncé", new DateTime(2027, 10, 9, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2598), "Experience the magic of Calvin Harris & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Calvin Harris & Beyoncé: Farewell Tour", 59.99m, 59.99m },
                    { new Guid("9228b689-0ff1-4515-9636-a63d7cedc2e0"), "Adele & BTS", new DateTime(2028, 5, 30, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4053), "The electrifying Adele & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Adele & BTS: Legends Tour", 79.99m, 79.99m },
                    { new Guid("925b6c49-4bd2-402a-b29f-1a964ff95814"), "Drake", new DateTime(2025, 9, 28, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8220), "The electrifying Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Drake: The Experience", 59.99m, 59.99m },
                    { new Guid("925f2acc-fff1-493f-9c14-d7295319cbda"), "Maroon 5 & BTS", new DateTime(2028, 7, 17, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4333), "An unforgettable night with Maroon 5 & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Maroon 5 & BTS: World Tour", 49.99m, 49.99m },
                    { new Guid("92840db6-ee55-4bb2-8e2b-99dcb9bb9c3a"), "G-Eazy & Beyoncé", new DateTime(2028, 3, 19, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3626), "An unforgettable night with G-Eazy & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "G-Eazy & Beyoncé: Summer Festival", 29.99m, 29.99m },
                    { new Guid("9333d294-bb8c-4ccf-8be6-4bac505c37e6"), "Blackpink & Beyoncé", new DateTime(2027, 10, 21, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2680), "An unforgettable night with Blackpink & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Blackpink & Beyoncé: World Tour", 99.99m, 99.99m },
                    { new Guid("9340b9df-3bda-4f8a-9ab0-5020afaeb6ad"), "Machine Gun Kelly & Ed Sheeran", new DateTime(2027, 4, 6, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1478), "The electrifying Machine Gun Kelly & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Machine Gun Kelly & Ed Sheeran: Acoustic Night", 199.99m, 199.99m },
                    { new Guid("93fa4cfa-706c-4703-96b4-a0112d6bc259"), "Lady Gaga & Beyoncé", new DateTime(2027, 7, 23, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2145), "An unforgettable night with Lady Gaga & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Lady Gaga & Beyoncé: World Tour", 179.99m, 179.99m },
                    { new Guid("9423dbd9-0446-405f-88f5-75fa95de793a"), "Lizzo & Ed Sheeran", new DateTime(2026, 11, 28, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(754), "Experience the magic of Lizzo & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Lizzo & Ed Sheeran: Farewell Tour", 149.99m, 149.99m },
                    { new Guid("9521e066-42a8-49c3-8264-5135de1dea97"), "Offset & Beyoncé", new DateTime(2028, 4, 15, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3784), "The electrifying Offset & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Offset & Beyoncé: Legends Tour", 119.99m, 119.99m },
                    { new Guid("95f0065c-baac-4f7a-8720-771b9d5ff7fb"), "Offset & Ed Sheeran", new DateTime(2027, 5, 27, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1813), "Experience the magic of Offset & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Offset & Ed Sheeran: Farewell Tour", 179.99m, 179.99m },
                    { new Guid("97577af2-afff-4ca3-9e72-76df0d283443"), "OneRepublic & Beyoncé", new DateTime(2028, 1, 22, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3272), "Experience the magic of OneRepublic & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "OneRepublic & Beyoncé: Live in Concert", 29.99m, 29.99m },
                    { new Guid("985ecc25-d366-46db-b763-03e9a5b1b856"), "Cardi B & Ed Sheeran", new DateTime(2026, 10, 29, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(583), "Experience the magic of Cardi B & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Cardi B & Ed Sheeran: Live in Concert", 49.99m, 49.99m },
                    { new Guid("99a8a7db-a3a7-4dce-89c3-7d897ad11509"), "NCT 127 & Ed Sheeran", new DateTime(2027, 5, 9, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1723), "An unforgettable night with NCT 127 & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "NCT 127 & Ed Sheeran: Summer Festival", 119.99m, 119.99m },
                    { new Guid("9b3f738f-4dd1-47e7-a8e8-341c527e40c9"), "Jack Harlow & Ed Sheeran", new DateTime(2027, 2, 8, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1161), "An unforgettable night with Jack Harlow & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Jack Harlow & Ed Sheeran: Summer Festival", 199.99m, 199.99m },
                    { new Guid("9b6c99f7-bc5a-4f74-bd79-09e89678ff89"), "The Script & BTS", new DateTime(2029, 4, 1, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5860), "Experience the magic of The Script & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "The Script & BTS: Farewell Tour", 149.99m, 149.99m },
                    { new Guid("9c3bba5e-8f3e-4778-a903-bf55994f8afc"), "Katy Perry & Ed Sheeran", new DateTime(2026, 10, 2, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(427), "Join Katy Perry & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Katy Perry & Ed Sheeran: Live at Home", 149.99m, 149.99m },
                    { new Guid("9c75e58c-ac98-4235-a9f8-479f068fc690"), "Ed Sheeran & Beyoncé", new DateTime(2027, 6, 29, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2025), "Join Ed Sheeran & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Ed Sheeran & Beyoncé: Live at Home", 99.99m, 99.99m },
                    { new Guid("9c9b4d62-c153-458e-bffe-2b6c9afa4c0f"), "Nicky Jam & BTS", new DateTime(2029, 1, 25, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5468), "The electrifying Nicky Jam & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Nicky Jam & BTS: The Experience", 119.99m, 119.99m },
                    { new Guid("9d04ec85-b14c-4217-b4b4-33397891d299"), "Nicki Minaj & Ed Sheeran", new DateTime(2027, 3, 25, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1421), "An unforgettable night with Nicki Minaj & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Nicki Minaj & Ed Sheeran: Summer Festival", 159.99m, 159.99m },
                    { new Guid("9d4505b9-f728-40b6-8368-efa59a6554ee"), "Elton John", new DateTime(2026, 2, 16, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9088), "Experience the magic of Elton John in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Elton John: Unplugged", 149.99m, 149.99m },
                    { new Guid("9d894930-9f48-4f56-9e88-fab403d28185"), "Maroon 5", new DateTime(2025, 11, 18, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8557), "Experience the magic of Maroon 5 in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Maroon 5: Unplugged", 39.99m, 39.99m },
                    { new Guid("9db56131-3562-44e2-b91d-bb54f4249ac1"), "Jack Harlow & Drake", new DateTime(2029, 10, 7, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6917), "The electrifying Jack Harlow & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Jack Harlow & Drake: Legends Tour", 19.99m, 19.99m },
                    { new Guid("9e18871d-b88e-4923-8c4f-ff2d326bc888"), "G-Eazy & Ed Sheeran", new DateTime(2027, 4, 30, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1627), "Join G-Eazy & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "G-Eazy & Ed Sheeran: Reunion Tour", 89.99m, 89.99m },
                    { new Guid("9e7ca4db-c9ee-4aa5-aa02-2961497c4645"), "Bruno Mars & Drake", new DateTime(2029, 5, 13, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6088), "An unforgettable night with Bruno Mars & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Bruno Mars & Drake: Stadium Tour", 99.99m, 99.99m },
                    { new Guid("9f829696-72be-4355-aaae-a7aecada6a61"), "LISA & Ed Sheeran", new DateTime(2027, 6, 20, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1955), "The electrifying LISA & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "LISA & Ed Sheeran: The Experience", 69.99m, 69.99m },
                    { new Guid("a00fd1b1-9e92-4a28-8fb4-326c36d2fafa"), "Beyoncé", new DateTime(2027, 7, 2, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2040), "Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Beyoncé: The Sessions", 109.99m, 109.99m },
                    { new Guid("a053b7ce-91c3-436c-8479-24bef7254641"), "SZA & Drake", new DateTime(2029, 7, 21, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6498), "SZA & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "SZA & Drake: Greatest Hits Tour", 139.99m, 139.99m },
                    { new Guid("a064b179-0d23-4050-91c1-01dfea8a712d"), "The Script & Ed Sheeran", new DateTime(2027, 6, 23, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1970), "An unforgettable night with The Script & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "The Script & Ed Sheeran: Summer Festival", 79.99m, 79.99m },
                    { new Guid("a16746cf-de38-4d95-b5f0-50dae62421f5"), "The Kid LAROI", new DateTime(2026, 1, 29, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9000), "An unforgettable night with The Kid LAROI showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "The Kid LAROI: World Tour", 89.99m, 89.99m },
                    { new Guid("a28d8b02-48e3-4363-9112-14921df50126"), "Tyler, The Creator & BTS", new DateTime(2029, 1, 19, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5437), "Join Tyler, The Creator & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Tyler, The Creator & BTS: Reunion Tour", 99.99m, 99.99m },
                    { new Guid("a33b165f-d6ea-4d73-b899-7911a5b65ca6"), "Miley Cyrus & Ed Sheeran", new DateTime(2026, 12, 31, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(946), "Join Miley Cyrus & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Miley Cyrus & Ed Sheeran: Live at Home", 69.99m, 69.99m },
                    { new Guid("a3fd9d0f-3421-473a-897e-880e29966abd"), "Ed Sheeran & Drake", new DateTime(2029, 4, 7, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5890), "Ed Sheeran & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Ed Sheeran & Drake: Anniversary Tour", 169.99m, 169.99m },
                    { new Guid("a405785f-6123-46b1-bfdc-09dce3cbe863"), "Cardi B & Drake", new DateTime(2029, 6, 27, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6354), "An unforgettable night with Cardi B & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Cardi B & Drake: Stadium Tour", 59.99m, 59.99m },
                    { new Guid("a661a632-8aa2-40d8-96cd-8943191ad0be"), "Olivia Rodrigo & Beyoncé", new DateTime(2027, 9, 30, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2554), "Olivia Rodrigo & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Olivia Rodrigo & Beyoncé: The Sessions", 29.99m, 29.99m },
                    { new Guid("a6c75b9c-7b47-4f21-a91d-e1c43e8f777f"), "SEVENTEEN & Ed Sheeran", new DateTime(2027, 5, 18, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1768), "SEVENTEEN & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "SEVENTEEN & Ed Sheeran: The Sessions", 149.99m, 149.99m },
                    { new Guid("a818355a-a3d6-4407-944f-84df5be56407"), "James Arthur & Beyoncé", new DateTime(2028, 4, 30, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3880), "The electrifying James Arthur & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "James Arthur & Beyoncé: The Experience", 169.99m, 169.99m },
                    { new Guid("a81d5d54-7b7a-4889-b463-41eae8a1c40d"), "Halsey & Ed Sheeran", new DateTime(2026, 11, 4, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(614), "Halsey & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Halsey & Ed Sheeran: Greatest Hits Tour", 69.99m, 69.99m },
                    { new Guid("a92aefc1-f835-41c1-86c0-b46456b27c8a"), "Megan Thee Stallion & Beyoncé", new DateTime(2027, 11, 11, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2816), "Join Megan Thee Stallion & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Megan Thee Stallion & Beyoncé: Live at Home", 169.99m, 169.99m },
                    { new Guid("a9dd68fb-fa2c-4529-97e7-a328433f203c"), "Lewis Capaldi & Beyoncé", new DateTime(2027, 9, 27, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2537), "Join Lewis Capaldi & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Lewis Capaldi & Beyoncé: Live at Home", 19.99m, 19.99m },
                    { new Guid("aaabd613-3bef-488b-b777-d7ca894b432e"), "Rosalía", new DateTime(2026, 3, 30, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9345), "An unforgettable night with Rosalía showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Rosalía: Summer Festival", 99.99m, 99.99m },
                    { new Guid("aabcd256-c407-4fea-8024-f8a6c7a8f6f1"), "Maluma & Drake", new DateTime(2029, 10, 13, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6991), "Experience the magic of Maluma & Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Maluma & Drake: Live in Concert", 39.99m, 39.99m },
                    { new Guid("aac789ae-c519-48dc-b299-487d41a0ddc3"), "Lil Baby & BTS", new DateTime(2028, 11, 14, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5033), "An unforgettable night with Lil Baby & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Lil Baby & BTS: Stadium Tour", 69.99m, 69.99m },
                    { new Guid("aad4f2d8-94d4-4aba-9823-8ec000df8534"), "The Weeknd & Beyoncé", new DateTime(2027, 7, 14, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2100), "Join The Weeknd & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "The Weeknd & Beyoncé: Comeback Tour", 149.99m, 149.99m },
                    { new Guid("ab337a81-3455-4b83-8c5e-83103eaa8e25"), "Sam Smith & Ed Sheeran", new DateTime(2027, 1, 15, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1044), "Join Sam Smith & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Sam Smith & Ed Sheeran: Comeback Tour", 119.99m, 119.99m },
                    { new Guid("ab4c1e9e-228f-4677-8b48-4094556246f3"), "Adele & Drake", new DateTime(2029, 4, 19, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5946), "Join Adele & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Adele & Drake: Reunion Tour", 19.99m, 19.99m },
                    { new Guid("ac77b06a-c723-4864-af06-bd07bea97997"), "Demi Lovato & Ed Sheeran", new DateTime(2027, 2, 26, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1272), "Experience the magic of Demi Lovato & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Demi Lovato & Ed Sheeran: Farewell Tour", 69.99m, 69.99m },
                    { new Guid("aca0b815-1983-4fa0-a0f9-747871edd03f"), "SEVENTEEN", new DateTime(2026, 6, 28, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9830), "An unforgettable night with SEVENTEEN showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "SEVENTEEN: Summer Festival", 19.99m, 19.99m },
                    { new Guid("ada95914-e51a-43e3-95f0-3b8f88dc1d20"), "Sia & Beyoncé", new DateTime(2027, 10, 27, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2710), "Join Sia & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Sia & Beyoncé: Reunion Tour", 119.99m, 119.99m },
                    { new Guid("adfedcfb-19f7-49b5-b305-ce87edf9ad22"), "Doja Cat & Drake", new DateTime(2029, 6, 24, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6339), "The electrifying Doja Cat & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Doja Cat & Drake: Acoustic Night", 49.99m, 49.99m },
                    { new Guid("aea373ff-3bdb-4317-bd6e-2399ac0dcb18"), "KAROL G & BTS", new DateTime(2028, 12, 17, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5219), "Experience the magic of KAROL G & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "KAROL G & BTS: Unplugged", 179.99m, 179.99m },
                    { new Guid("af4a647c-44fa-4d89-8717-4c3b85f502dc"), "Blackpink & BTS", new DateTime(2028, 9, 9, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4660), "Blackpink & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Blackpink & BTS: Greatest Hits Tour", 39.99m, 39.99m },
                    { new Guid("b130e551-026f-49a6-8631-ca77358d196e"), "Rihanna", new DateTime(2025, 11, 3, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8467), "Experience the magic of Rihanna in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Rihanna: Live in Concert", 179.99m, 179.99m },
                    { new Guid("b16f2b44-0b24-412d-a057-045af62ef83f"), "Lizzo & Beyoncé", new DateTime(2027, 10, 18, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2665), "The electrifying Lizzo & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Lizzo & Beyoncé: Legends Tour", 89.99m, 89.99m },
                    { new Guid("b17c69ad-04a8-4125-af43-8eb4f298e83d"), "Meghan Trainor & BTS", new DateTime(2029, 2, 12, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5556), "An unforgettable night with Meghan Trainor & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Meghan Trainor & BTS: Stadium Tour", 179.99m, 179.99m },
                    { new Guid("b1f17cd1-d916-49a6-af35-acd7c2adda3a"), "Lauv & BTS", new DateTime(2029, 3, 17, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5755), "Experience the magic of Lauv & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Lauv & BTS: Unplugged", 99.99m, 99.99m },
                    { new Guid("b26c265c-2234-4a00-9377-510aa51a85f6"), "Lil Nas X & Drake", new DateTime(2029, 7, 12, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6429), "An unforgettable night with Lil Nas X & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Lil Nas X & Drake: World Tour", 109.99m, 109.99m },
                    { new Guid("b35da37d-5dfa-46f0-88db-b67d8a92dbb8"), "Jonas Brothers & Ed Sheeran", new DateTime(2026, 12, 13, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(828), "Experience the magic of Jonas Brothers & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Jonas Brothers & Ed Sheeran: Live in Concert", 199.99m, 199.99m },
                    { new Guid("b365d380-162e-48f4-932c-03eec8638b27"), "Panic! At The Disco & Beyoncé", new DateTime(2028, 2, 27, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3476), "Panic! At The Disco & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Panic! At The Disco & Beyoncé: Anniversary Tour", 149.99m, 149.99m },
                    { new Guid("b38155eb-04ed-4ac1-832b-ab14b5ff0491"), "Lana Del Rey & Drake", new DateTime(2029, 9, 19, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6830), "Lana Del Rey & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Lana Del Rey & Drake: The Sessions", 149.99m, 149.99m },
                    { new Guid("b510267c-9e61-44d4-99b1-bcc08e0c5326"), "Glass Animals & Ed Sheeran", new DateTime(2027, 2, 23, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1256), "An unforgettable night with Glass Animals & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Glass Animals & Ed Sheeran: Stadium Tour", 59.99m, 59.99m },
                    { new Guid("b539aa30-4634-4d7f-a8ed-49ab6163d5f8"), "Zedd & Ed Sheeran", new DateTime(2027, 6, 2, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1866), "Zedd & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Zedd & Ed Sheeran: Anniversary Tour", 199.99m, 199.99m },
                    { new Guid("b56890a5-eb79-446a-adf7-962567d94647"), "Juice WRLD & Beyoncé", new DateTime(2027, 11, 14, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2832), "Juice WRLD & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Juice WRLD & Beyoncé: The Sessions", 179.99m, 179.99m },
                    { new Guid("b5877e39-758a-4028-9a27-b3d886b1f6b6"), "Bruno Mars & BTS", new DateTime(2028, 6, 23, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4173), "Join Bruno Mars & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Bruno Mars & BTS: Live at Home", 159.99m, 159.99m },
                    { new Guid("b5dcc107-213f-41b6-bccb-099cc8ca8be9"), "Selena Gomez & Ed Sheeran", new DateTime(2026, 12, 10, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(813), "An unforgettable night with Selena Gomez & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Selena Gomez & Ed Sheeran: World Tour", 189.99m, 189.99m },
                    { new Guid("b63f557f-37f0-493d-9cd6-941447320b6b"), "Imagine Dragons & Ed Sheeran", new DateTime(2026, 9, 29, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(412), "Experience the magic of Imagine Dragons & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Imagine Dragons & Ed Sheeran: Unplugged", 139.99m, 139.99m },
                    { new Guid("b6f2cd98-b8f7-4e4b-a882-28863be59251"), "Little Mix & Ed Sheeran", new DateTime(2027, 3, 28, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1435), "Experience the magic of Little Mix & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Little Mix & Ed Sheeran: Unplugged", 169.99m, 169.99m },
                    { new Guid("b7d232de-3e0c-405f-9baf-f7c6fd708002"), "OneRepublic & Ed Sheeran", new DateTime(2027, 3, 4, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1301), "OneRepublic & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "OneRepublic & Ed Sheeran: Anniversary Tour", 89.99m, 89.99m },
                    { new Guid("b9068a09-6635-47b8-b4d6-b1998ac94ba9"), "Imagine Dragons & Beyoncé", new DateTime(2027, 8, 19, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2302), "The electrifying Imagine Dragons & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Imagine Dragons & Beyoncé: Acoustic Night", 79.99m, 79.99m },
                    { new Guid("b93a563d-0d74-47f6-bdb2-82ad22d7bd8e"), "Beyoncé & Drake", new DateTime(2029, 4, 10, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5904), "The electrifying Beyoncé & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Beyoncé & Drake: Legends Tour", 179.99m, 179.99m },
                    { new Guid("b95723b8-9f75-4ba3-bb68-629ac21380ff"), "Billie Eilish & Ed Sheeran", new DateTime(2026, 8, 27, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(181), "An unforgettable night with Billie Eilish & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Billie Eilish & Ed Sheeran: Stadium Tour", 29.99m, 29.99m },
                    { new Guid("b9ab382b-6363-4987-94b8-38d49a72df15"), "Miley Cyrus & Drake", new DateTime(2029, 8, 29, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6712), "Experience the magic of Miley Cyrus & Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Miley Cyrus & Drake: Live in Concert", 79.99m, 79.99m },
                    { new Guid("b9e807f2-47e8-4118-8d6f-08cfec9f9319"), "LISA & Beyoncé", new DateTime(2028, 5, 9, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3926), "Join LISA & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "LISA & Beyoncé: Live at Home", 199.99m, 199.99m },
                    { new Guid("ba313f8a-fcff-48cd-9f92-f696a0477019"), "Bad Bunny & Drake", new DateTime(2029, 6, 15, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6271), "Experience the magic of Bad Bunny & Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Bad Bunny & Drake: Unplugged", 19.99m, 19.99m },
                    { new Guid("ba5371e6-bf03-4178-9f65-74f84654fdeb"), "Twenty One Pilots & Drake", new DateTime(2029, 6, 30, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6369), "Experience the magic of Twenty One Pilots & Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Twenty One Pilots & Drake: Farewell Tour", 69.99m, 69.99m },
                    { new Guid("ba5fb1e1-7d2c-4abc-af88-c2bfb5400999"), "Mabel", new DateTime(2026, 6, 7, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9730), "Mabel returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Mabel: Anniversary Tour", 139.99m, 139.99m },
                    { new Guid("ba8db4f2-d6b0-4be9-9294-b64222c38709"), "Tame Impala & Drake", new DateTime(2029, 10, 10, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6973), "An unforgettable night with Tame Impala & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Tame Impala & Drake: World Tour", 29.99m, 29.99m },
                    { new Guid("bb126abc-22ff-4170-a618-a9992da6b839"), "KAROL G & Ed Sheeran", new DateTime(2027, 3, 10, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1331), "An unforgettable night with KAROL G & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "KAROL G & Ed Sheeran: World Tour", 109.99m, 109.99m },
                    { new Guid("bc08acd0-a20f-4c75-bf9b-bcbe0cd84e95"), "Khalid & Ed Sheeran", new DateTime(2027, 1, 9, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(991), "An unforgettable night with Khalid & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Khalid & Ed Sheeran: Stadium Tour", 99.99m, 99.99m },
                    { new Guid("bc13d639-6fad-49e1-9738-0acf668a2e6f"), "Eminem", new DateTime(2025, 11, 24, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8586), "Eminem returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Eminem: The Sessions", 59.99m, 59.99m },
                    { new Guid("bc2dd774-afe5-4614-9ce4-84f1d5e84117"), "Tame Impala & Ed Sheeran", new DateTime(2027, 2, 11, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1196), "Experience the magic of Tame Impala & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Tame Impala & Ed Sheeran: Unplugged", 19.99m, 19.99m },
                    { new Guid("bc468210-b887-4a0f-87e0-c66caa49d572"), "5 Seconds of Summer & BTS", new DateTime(2028, 12, 29, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5317), "An unforgettable night with 5 Seconds of Summer & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "5 Seconds of Summer & BTS: Stadium Tour", 29.99m, 29.99m },
                    { new Guid("bd838b2b-d820-40e9-9b68-60eaef46daad"), "Twenty One Pilots", new DateTime(2025, 12, 12, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8678), "The electrifying Twenty One Pilots brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Twenty One Pilots: Legends Tour", 119.99m, 119.99m },
                    { new Guid("be5321d2-47b6-47a4-b151-beb09222dde3"), "Robin Schulz & BTS", new DateTime(2029, 2, 27, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5666), "An unforgettable night with Robin Schulz & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Robin Schulz & BTS: World Tour", 39.99m, 39.99m },
                    { new Guid("be7bf81c-103a-4d47-8c89-bb1d6450ad1f"), "Sia & Ed Sheeran", new DateTime(2026, 12, 7, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(799), "The electrifying Sia & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Sia & Ed Sheeran: Legends Tour", 179.99m, 179.99m },
                    { new Guid("be9e8daa-4a67-4914-8ef0-d1d6202c454c"), "Rosalía & BTS", new DateTime(2028, 11, 26, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5113), "The electrifying Rosalía & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Rosalía & BTS: Legends Tour", 109.99m, 109.99m },
                    { new Guid("beb76f89-1093-45cf-83e2-6dd7f66893aa"), "Beyoncé & BTS", new DateTime(2028, 5, 21, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3985), "Experience the magic of Beyoncé & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Beyoncé & BTS: Farewell Tour", 49.99m, 49.99m },
                    { new Guid("bf305b31-7bce-4c42-9bd2-5a3a0f378f05"), "Maroon 5 & Drake", new DateTime(2029, 6, 6, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6228), "Maroon 5 & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Maroon 5 & Drake: Greatest Hits Tour", 179.99m, 179.99m },
                    { new Guid("c01d13a1-b17e-49cd-9a37-d83360ef6fbc"), "Alan Walker", new DateTime(2026, 4, 11, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9402), "The electrifying Alan Walker brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Alan Walker: Acoustic Night", 139.99m, 139.99m },
                    { new Guid("c0644c18-2338-4a47-9fde-1186a50e14ae"), "David Guetta", new DateTime(2026, 2, 13, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9074), "An unforgettable night with David Guetta showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "David Guetta: Summer Festival", 139.99m, 139.99m },
                    { new Guid("c15f369d-fab0-42ef-a4a8-14cf781063a9"), "SZA & BTS", new DateTime(2028, 8, 31, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4616), "An unforgettable night with SZA & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "SZA & BTS: World Tour", 199.99m, 199.99m },
                    { new Guid("c1738e76-3906-4670-9b4b-8ea10efb7e52"), "Sam Smith", new DateTime(2026, 2, 25, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9156), "The electrifying Sam Smith brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Sam Smith: Acoustic Night", 179.99m, 179.99m },
                    { new Guid("c1af6b47-f778-4ace-b806-6b613959fb17"), "The Script & Beyoncé", new DateTime(2028, 5, 12, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3941), "The Script & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "The Script & Beyoncé: The Sessions", 19.99m, 19.99m },
                    { new Guid("c27f9865-bea8-47d1-a136-0f991daa8604"), "Kendrick Lamar & BTS", new DateTime(2028, 6, 29, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4241), "The electrifying Kendrick Lamar & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Kendrick Lamar & BTS: Acoustic Night", 179.99m, 179.99m },
                    { new Guid("c297369f-b4af-4c54-a803-4d135556297c"), "Twenty One Pilots & BTS", new DateTime(2028, 8, 10, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4485), "Twenty One Pilots & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Twenty One Pilots & BTS: The Sessions", 129.99m, 129.99m },
                    { new Guid("c2dd055b-8cca-465d-bc59-a51e925721f7"), "Tones and I", new DateTime(2026, 4, 2, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9360), "Experience the magic of Tones and I in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Tones and I: Unplugged", 109.99m, 109.99m },
                    { new Guid("c3567330-1f4c-4094-9b72-eab213bcacbf"), "Ariana Grande & Drake", new DateTime(2029, 5, 7, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6058), "Ariana Grande & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Ariana Grande & Drake: The Sessions", 79.99m, 79.99m },
                    { new Guid("c494bba3-3f60-449a-b64d-b92ecb280a01"), "Young Thug & Ed Sheeran", new DateTime(2027, 6, 5, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1881), "The electrifying Young Thug & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Young Thug & Ed Sheeran: Legends Tour", 19.99m, 19.99m },
                    { new Guid("c6592853-74b8-45df-a844-2b02f2c7b341"), "Camila Cabello", new DateTime(2025, 12, 3, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8631), "Experience the magic of Camila Cabello in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Camila Cabello: Farewell Tour", 89.99m, 89.99m },
                    { new Guid("c7018f4f-be0f-4e69-8288-01a5461c482b"), "Fall Out Boy & Beyoncé", new DateTime(2028, 4, 3, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3722), "An unforgettable night with Fall Out Boy & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Fall Out Boy & Beyoncé: Stadium Tour", 79.99m, 79.99m },
                    { new Guid("c7523161-18ba-4046-a606-3e806fa93822"), "BTS & Ed Sheeran", new DateTime(2026, 8, 15, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(121), "Experience the magic of BTS & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "BTS & Ed Sheeran: Unplugged", 179.99m, 179.99m },
                    { new Guid("c8195177-0095-4e49-8061-e0d0112d11ee"), "Ariana Grande & BTS", new DateTime(2028, 6, 17, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4142), "An unforgettable night with Ariana Grande & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Ariana Grande & BTS: Summer Festival", 139.99m, 139.99m },
                    { new Guid("c927ea42-a37f-4bbe-a88a-f8c9e6941b0a"), "Justin Bieber & Ed Sheeran", new DateTime(2026, 9, 5, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(256), "Justin Bieber & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Justin Bieber & Ed Sheeran: Anniversary Tour", 59.99m, 59.99m },
                    { new Guid("c962865e-fd5e-4fe3-be64-1093fee2e40d"), "Tame Impala & BTS", new DateTime(2028, 11, 20, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5062), "Join Tame Impala & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Tame Impala & BTS: Comeback Tour", 89.99m, 89.99m },
                    { new Guid("ca2f63e0-6546-4439-8604-7b4e9a680a0c"), "Maluma & Beyoncé", new DateTime(2028, 1, 4, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3160), "An unforgettable night with Maluma & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Maluma & Beyoncé: Stadium Tour", 159.99m, 159.99m },
                    { new Guid("cae3835c-5e78-4df3-9ea8-ccc0c26cdd6f"), "Little Mix & Beyoncé", new DateTime(2028, 2, 15, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3414), "The electrifying Little Mix & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Little Mix & Beyoncé: Acoustic Night", 109.99m, 109.99m },
                    { new Guid("cb992983-5d86-4839-a61d-8e41380dd806"), "Future & Drake", new DateTime(2029, 8, 14, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6615), "Experience the magic of Future & Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Future & Drake: Farewell Tour", 29.99m, 29.99m },
                    { new Guid("cc19591b-a5f2-44b9-b5a4-94c8829ded05"), "Kehlani & Beyoncé", new DateTime(2028, 2, 21, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3446), "Experience the magic of Kehlani & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Kehlani & Beyoncé: Farewell Tour", 129.99m, 129.99m },
                    { new Guid("cc27653c-27e6-41f1-8b21-0c7fad3471d1"), "Travis Scott & Drake", new DateTime(2029, 6, 9, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6242), "The electrifying Travis Scott & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Travis Scott & Drake: The Experience", 189.99m, 189.99m },
                    { new Guid("cd2ecb64-7ba0-49f5-a48e-fafe4f92bb4c"), "Travis Scott & Ed Sheeran", new DateTime(2026, 10, 11, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(473), "An unforgettable night with Travis Scott & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Travis Scott & Ed Sheeran: Stadium Tour", 179.99m, 179.99m },
                    { new Guid("cd36973e-2ac5-4002-b6f3-ea9d173177e3"), "BTS", new DateTime(2028, 5, 24, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4000), "Join BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "BTS: Comeback Tour", 59.99m, 59.99m },
                    { new Guid("cd5480c3-a17d-492b-a9ac-e58009f39cbc"), "Kendrick Lamar & Beyoncé", new DateTime(2027, 8, 10, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2255), "Experience the magic of Kendrick Lamar & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Kendrick Lamar & Beyoncé: Unplugged", 49.99m, 49.99m },
                    { new Guid("cdd7656e-4965-4575-9fa8-f7313cfcd509"), "Taylor Swift & Drake", new DateTime(2029, 4, 4, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5876), "Join Taylor Swift & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Taylor Swift & Drake: Comeback Tour", 159.99m, 159.99m },
                    { new Guid("cefadec6-58fc-494a-ad84-014e6a18ce9e"), "Avicii & Beyoncé", new DateTime(2028, 3, 31, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3707), "The electrifying Avicii & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Avicii & Beyoncé: Acoustic Night", 69.99m, 69.99m },
                    { new Guid("cf2b0c85-ef3f-4a58-8e74-ca2b4a8285e4"), "DaBaby & Ed Sheeran", new DateTime(2027, 2, 2, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1133), "DaBaby & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "DaBaby & Ed Sheeran: Greatest Hits Tour", 179.99m, 179.99m },
                    { new Guid("d034edb0-3c86-4e9e-b281-6f15708ccc7d"), "Dua Lipa & BTS", new DateTime(2028, 6, 26, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4187), "Dua Lipa & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Dua Lipa & BTS: The Sessions", 169.99m, 169.99m },
                    { new Guid("d083d7b0-6ad3-428b-8080-4ef1e4e2964c"), "Anitta & Ed Sheeran", new DateTime(2027, 4, 21, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1584), "The electrifying Anitta & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Anitta & Ed Sheeran: Legends Tour", 59.99m, 59.99m },
                    { new Guid("d0ce860b-0bb9-4ac8-9200-153937b64794"), "Imagine Dragons & Drake", new DateTime(2029, 5, 28, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6183), "An unforgettable night with Imagine Dragons & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Imagine Dragons & Drake: World Tour", 149.99m, 149.99m },
                    { new Guid("d0f84b1d-fb24-49be-982a-01cc43842586"), "Lil Nas X & Ed Sheeran", new DateTime(2026, 11, 13, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(656), "Experience the magic of Lil Nas X & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Lil Nas X & Ed Sheeran: Unplugged", 99.99m, 99.99m },
                    { new Guid("d2062943-753e-4005-afec-9479038e5625"), "Nicki Minaj", new DateTime(2026, 5, 5, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9544), "Join Nicki Minaj for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Nicki Minaj: Reunion Tour", 29.99m, 29.99m },
                    { new Guid("d334d566-dca6-40a6-99cc-a36526e5c49b"), "BLACKPINK ROSÉ", new DateTime(2026, 7, 25, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4), "The electrifying BLACKPINK ROSÉ brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "BLACKPINK ROSÉ: Legends Tour", 109.99m, 109.99m },
                    { new Guid("d424fa97-96d6-4e88-9685-5aedc0c07016"), "Fall Out Boy & BTS", new DateTime(2029, 2, 21, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5636), "Fall Out Boy & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Fall Out Boy & BTS: Anniversary Tour", 19.99m, 19.99m },
                    { new Guid("d4535c0b-d0fc-44b9-b2b8-9afc97f29c20"), "Daddy Yankee & Drake", new DateTime(2029, 8, 2, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6557), "Join Daddy Yankee & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Daddy Yankee & Drake: Live at Home", 179.99m, 179.99m },
                    { new Guid("d49ed9be-56fa-4492-9b29-a1ec31c05a23"), "Bastille & Beyoncé", new DateTime(2028, 3, 4, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3544), "An unforgettable night with Bastille & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Bastille & Beyoncé: World Tour", 169.99m, 169.99m },
                    { new Guid("d5686553-3e12-4d3e-8443-8d559501a989"), "Eminem & BTS", new DateTime(2028, 7, 23, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4362), "Join Eminem & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Eminem & BTS: Reunion Tour", 69.99m, 69.99m },
                    { new Guid("d6512eaf-08a7-4bb7-8613-7246dd76a9f5"), "Elton John & Ed Sheeran", new DateTime(2027, 1, 6, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(975), "The electrifying Elton John & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Elton John & Ed Sheeran: Acoustic Night", 89.99m, 89.99m },
                    { new Guid("d69e8e68-0073-4709-ac94-2ca778aed9fb"), "Charlie Puth", new DateTime(2026, 2, 22, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9141), "Charlie Puth returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Charlie Puth: The Sessions", 169.99m, 169.99m },
                    { new Guid("d7051755-3ec3-49f3-a2e9-1a1cfa0ff4b5"), "Bruno Mars & Beyoncé", new DateTime(2027, 8, 4, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2226), "The electrifying Bruno Mars & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Bruno Mars & Beyoncé: The Experience", 29.99m, 29.99m },
                    { new Guid("d723c3b3-dfc8-4a36-b322-854bcdbd63f8"), "G-Eazy & BTS", new DateTime(2029, 2, 6, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5527), "G-Eazy & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "G-Eazy & BTS: The Sessions", 159.99m, 159.99m },
                    { new Guid("d72885f3-a37c-4ba9-9c70-75cf2e411a91"), "Meghan Trainor & Ed Sheeran", new DateTime(2027, 5, 6, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1657), "The electrifying Meghan Trainor & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Meghan Trainor & Ed Sheeran: The Experience", 109.99m, 109.99m },
                    { new Guid("d7a186d2-dcf5-4ef5-92f3-fc7c2f2b08e3"), "Harry Styles & Ed Sheeran", new DateTime(2026, 8, 30, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(227), "Experience the magic of Harry Styles & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Harry Styles & Ed Sheeran: Farewell Tour", 39.99m, 39.99m },
                    { new Guid("d85029f4-b16c-4dd4-8a44-f768cb2eae2c"), "Lady Gaga & Drake", new DateTime(2029, 5, 1, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6029), "Experience the magic of Lady Gaga & Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Lady Gaga & Drake: Unplugged", 59.99m, 59.99m },
                    { new Guid("d8f52509-2cb2-4111-9b57-510f632d5d55"), "Dan + Shay & Beyoncé", new DateTime(2028, 3, 22, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3640), "Experience the magic of Dan + Shay & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Dan + Shay & Beyoncé: Unplugged", 39.99m, 39.99m },
                    { new Guid("d9229e25-01fd-47a0-b891-2fd385fb581b"), "Shawn Mendes & Drake", new DateTime(2029, 6, 18, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6286), "Join Shawn Mendes & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Shawn Mendes & Drake: Live at Home", 29.99m, 29.99m },
                    { new Guid("d934b968-b935-4414-a955-6b5afd77c281"), "Alicia Keys", new DateTime(2026, 4, 29, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9514), "An unforgettable night with Alicia Keys showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Alicia Keys: World Tour", 199.99m, 199.99m },
                    { new Guid("d9707293-9d92-49d1-8570-bb98ef832b4d"), "Mabel & BTS", new DateTime(2029, 2, 3, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5512), "Join Mabel & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Mabel & BTS: Live at Home", 149.99m, 149.99m },
                    { new Guid("d980eea6-5739-4b84-b103-6a55593076ab"), "Jason Derulo", new DateTime(2026, 7, 4, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9881), "Join Jason Derulo for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Jason Derulo: Live at Home", 39.99m, 39.99m },
                    { new Guid("d9a20a30-c5ee-4687-9df5-d840ad97a5b3"), "J Balvin", new DateTime(2025, 11, 15, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8542), "An unforgettable night with J Balvin showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "J Balvin: Summer Festival", 29.99m, 29.99m },
                    { new Guid("da2356df-fbdf-4c50-80c0-bc47118bb854"), "Coldplay & Beyoncé", new DateTime(2027, 8, 16, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2287), "Coldplay & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Coldplay & Beyoncé: The Sessions", 69.99m, 69.99m },
                    { new Guid("da6c24b8-4f15-42bb-ac40-20abe82ccb17"), "Meghan Trainor & Beyoncé", new DateTime(2028, 3, 25, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3655), "Join Meghan Trainor & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Meghan Trainor & Beyoncé: Live at Home", 49.99m, 49.99m },
                    { new Guid("da85e6f1-a53b-4183-b475-5742d37dc926"), "Post Malone", new DateTime(2025, 10, 22, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8404), "Join Post Malone for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Post Malone: Comeback Tour", 139.99m, 139.99m },
                    { new Guid("db0e4f26-2fc3-4261-b345-0f062dc3a1e5"), "Sia", new DateTime(2026, 1, 17, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8910), "Experience the magic of Sia in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Sia: Farewell Tour", 49.99m, 49.99m },
                    { new Guid("dba4d6d4-4950-4f74-a0e1-43f5a978c2f8"), "Lewis Capaldi & BTS", new DateTime(2028, 8, 16, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4514), "An unforgettable night with Lewis Capaldi & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Lewis Capaldi & BTS: Stadium Tour", 149.99m, 149.99m },
                    { new Guid("dbdf2266-248a-48b4-9e27-97d715c53472"), "Selena Gomez", new DateTime(2026, 1, 20, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8956), "Join Selena Gomez for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Selena Gomez: Comeback Tour", 59.99m, 59.99m },
                    { new Guid("dc1f6b03-fa87-41f6-bbe4-588d851af74c"), "Mabel & Beyoncé", new DateTime(2028, 3, 16, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3610), "The electrifying Mabel & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Mabel & Beyoncé: The Experience", 19.99m, 19.99m },
                    { new Guid("dc55fe1c-8356-4a68-a013-0477ba996542"), "Jonas Brothers & Drake", new DateTime(2029, 8, 11, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6601), "An unforgettable night with Jonas Brothers & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Jonas Brothers & Drake: Stadium Tour", 19.99m, 19.99m },
                    { new Guid("dc9c291d-965d-4072-becb-65f6efcf1128"), "Tiësto & Ed Sheeran", new DateTime(2027, 3, 16, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1374), "Join Tiësto & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Tiësto & Ed Sheeran: Reunion Tour", 129.99m, 129.99m },
                    { new Guid("dcb0bafc-684a-482a-ae8a-dcb5f197caaa"), "Zara Larsson & BTS", new DateTime(2028, 12, 14, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5204), "An unforgettable night with Zara Larsson & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Zara Larsson & BTS: Summer Festival", 169.99m, 169.99m },
                    { new Guid("de3b3f9a-85c9-4366-959d-ed127fc0aaa4"), "Khalid & Beyoncé", new DateTime(2027, 11, 29, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2906), "Khalid & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Khalid & Beyoncé: Anniversary Tour", 39.99m, 39.99m },
                    { new Guid("df032ab9-bce9-4769-8514-13722a5b190f"), "Bruno Mars", new DateTime(2025, 10, 25, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8419), "Bruno Mars returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Bruno Mars: Anniversary Tour", 149.99m, 149.99m },
                    { new Guid("df2b1a84-829f-47bd-9139-029bff95746d"), "Harry Styles", new DateTime(2025, 10, 10, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8288), "Harry Styles returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Harry Styles: The Sessions", 99.99m, 99.99m },
                    { new Guid("df6938bf-c039-4f64-a056-f0900d6da41c"), "Kygo & Beyoncé", new DateTime(2027, 11, 17, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2849), "The electrifying Kygo & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Kygo & Beyoncé: Acoustic Night", 189.99m, 189.99m },
                    { new Guid("df7826de-4b30-4519-82db-76be57f170f9"), "Lizzo & BTS", new DateTime(2028, 9, 6, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4646), "Join Lizzo & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Lizzo & BTS: Reunion Tour", 29.99m, 29.99m },
                    { new Guid("dfdab141-0386-4e6f-a41d-964289c44f1b"), "DaBaby", new DateTime(2026, 3, 15, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9246), "An unforgettable night with DaBaby showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "DaBaby: World Tour", 49.99m, 49.99m },
                    { new Guid("dffcf564-d6a2-4408-b67f-17656a80c7fd"), "Bastille & BTS", new DateTime(2029, 1, 22, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5454), "Bastille & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Bastille & BTS: Greatest Hits Tour", 109.99m, 109.99m },
                    { new Guid("e02f87b4-badc-4629-82dd-6b44a360b5b1"), "Lady Gaga", new DateTime(2025, 10, 13, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8329), "The electrifying Lady Gaga brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Lady Gaga: Acoustic Night", 109.99m, 109.99m },
                    { new Guid("e152ef7a-dd09-4630-82c3-748acb516f7a"), "Avicii", new DateTime(2026, 6, 22, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9802), "Avicii returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Avicii: Greatest Hits Tour", 189.99m, 189.99m },
                    { new Guid("e1638cf0-5711-4533-bcf3-2c3a0d43ba2e"), "James Arthur", new DateTime(2026, 7, 22, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9988), "James Arthur returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "James Arthur: Anniversary Tour", 99.99m, 99.99m },
                    { new Guid("e21dc632-4231-4cd9-83aa-2ed38aeff6f2"), "Lizzo", new DateTime(2026, 1, 8, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8866), "Lizzo returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Lizzo: The Sessions", 19.99m, 19.99m },
                    { new Guid("e241832c-65c1-4182-bcff-9bf3ad410e73"), "Bruno Mars & Ed Sheeran", new DateTime(2026, 9, 14, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(304), "Experience the magic of Bruno Mars & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Bruno Mars & Ed Sheeran: Live in Concert", 89.99m, 89.99m },
                    { new Guid("e263d78c-52d8-4a82-a3c1-020bfdba676c"), "Lana Del Rey & Beyoncé", new DateTime(2027, 12, 11, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3040), "Join Lana Del Rey & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Lana Del Rey & Beyoncé: Reunion Tour", 79.99m, 79.99m },
                    { new Guid("e2a6df74-436b-4add-b752-6f0526800f34"), "Alicia Keys & BTS", new DateTime(2028, 12, 26, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5283), "The electrifying Alicia Keys & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Alicia Keys & BTS: Acoustic Night", 19.99m, 19.99m },
                    { new Guid("e34b1326-f051-4291-a48f-0634435d5770"), "Young Thug & BTS", new DateTime(2029, 3, 14, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5741), "An unforgettable night with Young Thug & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Young Thug & BTS: Summer Festival", 89.99m, 89.99m },
                    { new Guid("e40b4d1a-bff2-4f59-87de-52a1dee238c5"), "Machine Gun Kelly & BTS", new DateTime(2029, 1, 13, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5393), "An unforgettable night with Machine Gun Kelly & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Machine Gun Kelly & BTS: World Tour", 79.99m, 79.99m },
                    { new Guid("e4f816cd-7423-4692-a8d5-a0a25de354e8"), "The Kid LAROI & Drake", new DateTime(2029, 8, 17, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6630), "Join The Kid LAROI & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "The Kid LAROI & Drake: Comeback Tour", 39.99m, 39.99m },
                    { new Guid("e51c6da9-d976-4550-ac43-74a65a6542f5"), "Kendrick Lamar & Ed Sheeran", new DateTime(2026, 9, 20, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(332), "Kendrick Lamar & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Kendrick Lamar & Ed Sheeran: Greatest Hits Tour", 109.99m, 109.99m },
                    { new Guid("e5aca64d-c800-4996-acda-bf987a25e7af"), "Doja Cat & Ed Sheeran", new DateTime(2026, 10, 26, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(567), "An unforgettable night with Doja Cat & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Doja Cat & Ed Sheeran: World Tour", 39.99m, 39.99m },
                    { new Guid("e5ca2693-284a-47d2-ae08-8637ec50a161"), "Nicki Minaj & BTS", new DateTime(2029, 1, 1, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5333), "Experience the magic of Nicki Minaj & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Nicki Minaj & BTS: Farewell Tour", 39.99m, 39.99m },
                    { new Guid("e654c146-0e73-44ce-9ff2-9827e5a1d35b"), "SZA & Beyoncé", new DateTime(2027, 10, 12, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2635), "Join SZA & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "SZA & Beyoncé: Comeback Tour", 69.99m, 69.99m },
                    { new Guid("e68fcf89-f63b-4d91-b499-2dbefc0f46ab"), "Anne-Marie & Beyoncé", new DateTime(2028, 4, 18, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3799), "An unforgettable night with Anne-Marie & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Anne-Marie & Beyoncé: World Tour", 129.99m, 129.99m },
                    { new Guid("e6f92ea8-5ff4-4046-bda8-9e769c6902eb"), "Kygo & Ed Sheeran", new DateTime(2026, 12, 28, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(932), "Experience the magic of Kygo & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Kygo & Ed Sheeran: Unplugged", 59.99m, 59.99m },
                    { new Guid("e72def9c-c065-46f0-8816-1c89872be31d"), "Blackpink & Drake", new DateTime(2029, 7, 30, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6541), "Experience the magic of Blackpink & Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Blackpink & Drake: Unplugged", 169.99m, 169.99m },
                    { new Guid("e73c1b9e-0ebb-4d30-809e-736875710e9f"), "Niall Horan & Ed Sheeran", new DateTime(2027, 1, 24, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1089), "An unforgettable night with Niall Horan & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Niall Horan & Ed Sheeran: World Tour", 149.99m, 149.99m },
                    { new Guid("e76293ea-ad2d-4375-8d18-e5a59e6d6906"), "BTS & Beyoncé", new DateTime(2027, 7, 5, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2056), "The electrifying BTS & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "BTS & Beyoncé: Acoustic Night", 119.99m, 119.99m },
                    { new Guid("e76da7a9-6bdc-44b6-87c7-cbed8d50d668"), "DaBaby & BTS", new DateTime(2028, 11, 11, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5019), "The electrifying DaBaby & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "DaBaby & BTS: Acoustic Night", 59.99m, 59.99m },
                    { new Guid("e7ab10d0-7305-4e3b-924e-da37ed0f3ea4"), "Drake & BTS", new DateTime(2028, 5, 27, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4017), "Drake & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Drake & BTS: Anniversary Tour", 69.99m, 69.99m },
                    { new Guid("e938607d-fcc7-4f8b-ae8c-e60eae7cc8b5"), "Young Thug & Beyoncé", new DateTime(2028, 4, 24, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3828), "Join Young Thug & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Young Thug & Beyoncé: Reunion Tour", 149.99m, 149.99m },
                    { new Guid("e9496cfe-f477-4caa-a278-edb268ca888b"), "Coldplay & Ed Sheeran", new DateTime(2026, 9, 26, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(397), "An unforgettable night with Coldplay & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Coldplay & Ed Sheeran: Summer Festival", 129.99m, 129.99m },
                    { new Guid("e9733f25-a566-4bf5-9461-ec3303c26a9e"), "Alan Walker & BTS", new DateTime(2028, 12, 8, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5175), "Alan Walker & BTS returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Alan Walker & BTS: Greatest Hits Tour", 149.99m, 149.99m },
                    { new Guid("e9df1d80-edee-4e4e-be52-fb8bbeeb330d"), "Elton John & Beyoncé", new DateTime(2027, 11, 26, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2891), "Join Elton John & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Elton John & Beyoncé: Comeback Tour", 29.99m, 29.99m },
                    { new Guid("eac9a326-0bc3-4c0d-83cc-5d277451ae1c"), "BLACKPINK ROSÉ & Ed Sheeran", new DateTime(2027, 6, 14, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1925), "Join BLACKPINK ROSÉ & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "BLACKPINK ROSÉ & Ed Sheeran: Reunion Tour", 49.99m, 49.99m },
                    { new Guid("ec691ee7-b335-4f47-b4a8-d8d815d41f64"), "BTS & Drake", new DateTime(2029, 4, 13, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5918), "An unforgettable night with BTS & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "BTS & Drake: World Tour", 189.99m, 189.99m },
                    { new Guid("ecd49f5f-20d3-4a45-8953-b98fd83a5998"), "SZA", new DateTime(2026, 1, 2, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8836), "Experience the magic of SZA in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "SZA: Unplugged", 189.99m, 189.99m },
                    { new Guid("ed567ef1-6816-45dd-b4e2-074e7afc7a62"), "James Arthur & Ed Sheeran", new DateTime(2027, 6, 11, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1910), "Experience the magic of James Arthur & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "James Arthur & Ed Sheeran: Live in Concert", 39.99m, 39.99m },
                    { new Guid("edc55a47-e31c-49a8-aa64-4397d4b93f87"), "Olivia Rodrigo & Drake", new DateTime(2029, 7, 9, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6414), "The electrifying Olivia Rodrigo & Drake brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Olivia Rodrigo & Drake: Legends Tour", 99.99m, 99.99m },
                    { new Guid("eddbd83f-5090-4262-8b8f-abe37f24b0bf"), "Halsey", new DateTime(2025, 12, 15, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8743), "An unforgettable night with Halsey showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Halsey: World Tour", 129.99m, 129.99m },
                    { new Guid("ee1e589e-8b5a-44e4-85be-8b8ce1aa8a28"), "YUNGBLUD & Beyoncé", new DateTime(2028, 2, 18, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3430), "An unforgettable night with YUNGBLUD & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "YUNGBLUD & Beyoncé: Stadium Tour", 119.99m, 119.99m },
                    { new Guid("ee2a51c6-0568-4854-867b-09ffd7c25012"), "Sam Smith & Drake", new DateTime(2029, 9, 13, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6784), "Experience the magic of Sam Smith & Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Sam Smith & Drake: Unplugged", 129.99m, 129.99m },
                    { new Guid("ef744f4f-3519-4fa1-8c6c-d5397ccd0be3"), "David Guetta & BTS", new DateTime(2028, 10, 12, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4847), "The electrifying David Guetta & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "David Guetta & BTS: Legends Tour", 149.99m, 149.99m },
                    { new Guid("ef7fe1e7-54fc-4b30-b2b8-5127d23bf38e"), "Zedd & Beyoncé", new DateTime(2028, 4, 21, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3814), "Experience the magic of Zedd & Beyoncé in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Zedd & Beyoncé: Live in Concert", 139.99m, 139.99m },
                    { new Guid("ef823f34-204c-4667-8272-f36fbce5f248"), "Lewis Capaldi & Ed Sheeran", new DateTime(2026, 11, 7, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(627), "The electrifying Lewis Capaldi & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Lewis Capaldi & Ed Sheeran: The Experience", 79.99m, 79.99m },
                    { new Guid("f021aeca-5e8f-4fd1-8ce4-eef4f288bb61"), "Shawn Mendes", new DateTime(2025, 11, 30, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8616), "An unforgettable night with Shawn Mendes showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Shawn Mendes: Stadium Tour", 79.99m, 79.99m },
                    { new Guid("f0238df9-1dac-4391-8e89-6a4057343a07"), "Alan Walker & Beyoncé", new DateTime(2028, 1, 19, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3258), "An unforgettable night with Alan Walker & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Alan Walker & Beyoncé: World Tour", 19.99m, 19.99m },
                    { new Guid("f0f53aba-cd31-4c35-ac95-56d718bc8b5f"), "Tyler, The Creator", new DateTime(2026, 5, 23, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9632), "Tyler, The Creator returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Tyler, The Creator: The Sessions", 89.99m, 89.99m },
                    { new Guid("f12a9681-4158-4e35-b7ab-10b8dd2f4e5a"), "Kygo", new DateTime(2026, 2, 7, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9046), "Kygo returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Kygo: Greatest Hits Tour", 119.99m, 119.99m },
                    { new Guid("f1f538db-01d0-4199-aff6-615a0fcd96cd"), "Rihanna & Drake", new DateTime(2029, 5, 22, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6154), "Rihanna & Drake returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Rihanna & Drake: Anniversary Tour", 129.99m, 129.99m },
                    { new Guid("f246f740-d359-4ca1-9507-ed2c876902d4"), "Katy Perry", new DateTime(2025, 11, 12, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8510), "The electrifying Katy Perry brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Katy Perry: The Experience", 19.99m, 19.99m },
                    { new Guid("f2fe8968-ed37-459a-bf30-25ee94f54367"), "Troye Sivan & BTS", new DateTime(2029, 1, 31, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5498), "Experience the magic of Troye Sivan & BTS in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Troye Sivan & BTS: Unplugged", 139.99m, 139.99m },
                    { new Guid("f335aaab-c5d2-424c-b94a-d0582e10006b"), "Cardi B & Beyoncé", new DateTime(2027, 9, 18, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2472), "The electrifying Cardi B & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Cardi B & Beyoncé: The Experience", 179.99m, 179.99m },
                    { new Guid("f36899bc-929e-476e-9b69-5f14ba2ca7c8"), "Martin Garrix", new DateTime(2026, 2, 28, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(9170), "An unforgettable night with Martin Garrix showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Martin Garrix: Stadium Tour", 189.99m, 189.99m },
                    { new Guid("f4e5edd8-12af-4064-a374-8cacd25484a9"), "Taylor Swift & BTS", new DateTime(2028, 5, 15, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3955), "The electrifying Taylor Swift & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Taylor Swift & BTS: Acoustic Night", 29.99m, 29.99m },
                    { new Guid("f543b26a-afb8-4bf2-ba39-e2ddd674c947"), "Tones and I & Ed Sheeran", new DateTime(2027, 2, 20, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1242), "The electrifying Tones and I & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Tones and I & Ed Sheeran: Acoustic Night", 49.99m, 49.99m },
                    { new Guid("f57b1a79-92d9-4869-977c-72468838cd78"), "Twenty One Pilots & Beyoncé", new DateTime(2027, 9, 21, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2487), "An unforgettable night with Twenty One Pilots & Beyoncé showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Twenty One Pilots & Beyoncé: Summer Festival", 189.99m, 189.99m },
                    { new Guid("f684b15d-90d1-4078-8c97-e5bd0408e126"), "Dua Lipa & Drake", new DateTime(2029, 5, 16, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6102), "Experience the magic of Dua Lipa & Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Dua Lipa & Drake: Farewell Tour", 109.99m, 109.99m },
                    { new Guid("f8052128-7dbe-43fc-b7d2-7e624b5dc238"), "Harry Styles & BTS", new DateTime(2028, 6, 8, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4099), "Join Harry Styles & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Harry Styles & BTS: Reunion Tour", 109.99m, 109.99m },
                    { new Guid("f8c63b36-3965-4a1c-bb80-5919968a19e7"), "Jason Derulo & Ed Sheeran", new DateTime(2027, 5, 24, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1798), "An unforgettable night with Jason Derulo & Ed Sheeran showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Jason Derulo & Ed Sheeran: Stadium Tour", 169.99m, 169.99m },
                    { new Guid("f94dffdc-4f62-4a39-9620-107e4e938c9f"), "Rihanna & Beyoncé", new DateTime(2027, 8, 13, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2272), "Join Rihanna & Beyoncé for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Rihanna & Beyoncé: Live at Home", 59.99m, 59.99m },
                    { new Guid("f9e952a5-fa8f-4f59-9221-497a03b99493"), "Rihanna & BTS", new DateTime(2028, 7, 2, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(4256), "An unforgettable night with Rihanna & BTS showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Rihanna & BTS: Stadium Tour", 189.99m, 189.99m },
                    { new Guid("fa5c1ebc-054a-49e5-82ec-c1a0de6689ee"), "Calvin Harris & Ed Sheeran", new DateTime(2026, 11, 19, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(707), "Calvin Harris & Ed Sheeran returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Calvin Harris & Ed Sheeran: The Sessions", 119.99m, 119.99m },
                    { new Guid("fa7b7e20-bbc1-4b98-bae4-3185b4a77704"), "Rihanna & Ed Sheeran", new DateTime(2026, 9, 23, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(380), "The electrifying Rihanna & Ed Sheeran brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Rihanna & Ed Sheeran: The Experience", 119.99m, 119.99m },
                    { new Guid("fadc78da-564e-456f-8a34-ec57dd43ed72"), "NCT 127 & Beyoncé", new DateTime(2028, 3, 28, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3670), "NCT 127 & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "NCT 127 & Beyoncé: The Sessions", 59.99m, 59.99m },
                    { new Guid("fbfad259-b640-4a66-896a-2ff6b034b2a5"), "Madison Beer & BTS", new DateTime(2029, 3, 26, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5832), "The electrifying Madison Beer & BTS brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Madison Beer & BTS: Acoustic Night", 129.99m, 129.99m },
                    { new Guid("fc5eeded-eb25-496a-a091-f54b7ba1383e"), "Billie Eilish & Beyoncé", new DateTime(2027, 7, 17, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(2115), "Billie Eilish & Beyoncé returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!", "/img/guitar.jpg", false, "Billie Eilish & Beyoncé: Anniversary Tour", 159.99m, 159.99m },
                    { new Guid("fc655f0d-ed3a-4772-9778-cd336fbb2cc1"), "Luke Combs & Drake", new DateTime(2029, 9, 28, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6873), "Experience the magic of Luke Combs & Drake in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Luke Combs & Drake: Farewell Tour", 179.99m, 179.99m },
                    { new Guid("fca2d609-3871-4b0f-afda-5e107be2f3eb"), "Lil Uzi Vert & BTS", new DateTime(2028, 12, 20, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(5233), "Join Lil Uzi Vert & BTS for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Lil Uzi Vert & BTS: Live at Home", 189.99m, 189.99m },
                    { new Guid("fdaf4d9f-ce89-4d44-a551-6a345810dbfe"), "Ariana Grande", new DateTime(2025, 10, 19, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8389), "Experience the magic of Ariana Grande in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Ariana Grande: Farewell Tour", 129.99m, 129.99m },
                    { new Guid("fdc0ce3c-fad0-4232-812f-30c295a5944c"), "Tame Impala & Beyoncé", new DateTime(2028, 1, 1, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(3144), "The electrifying Tame Impala & Beyoncé brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "Tame Impala & Beyoncé: Acoustic Night", 149.99m, 149.99m },
                    { new Guid("fe90a9aa-9813-4210-82c4-e8e2a1d26946"), "The Chainsmokers", new DateTime(2025, 12, 27, 13, 26, 39, 867, DateTimeKind.Local).AddTicks(8806), "The electrifying The Chainsmokers brings their high-energy performance to town with special guests and surprises throughout the night.", "/img/musical.jpg", false, "The Chainsmokers: The Experience", 169.99m, 169.99m },
                    { new Guid("fea090eb-773f-44e8-85c3-a2ead453b6ae"), "Lizzo & Drake", new DateTime(2029, 7, 27, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6526), "An unforgettable night with Lizzo & Drake showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Lizzo & Drake: Summer Festival", 159.99m, 159.99m },
                    { new Guid("febbf035-5443-4def-aa89-bdf3400bd7fd"), "Calvin Harris & Drake", new DateTime(2029, 7, 18, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(6459), "Join Calvin Harris & Drake for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Calvin Harris & Drake: Reunion Tour", 129.99m, 129.99m },
                    { new Guid("ff1b10e2-f718-4159-8a8a-b45aec088906"), "Future & Ed Sheeran", new DateTime(2026, 12, 16, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(873), "Join Future & Ed Sheeran for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.", "/img/dj.jpg", false, "Future & Ed Sheeran: Reunion Tour", 19.99m, 19.99m },
                    { new Guid("ff9a7d73-d8d0-4a80-ae75-dce6088150fe"), "Mabel & Ed Sheeran", new DateTime(2027, 4, 27, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(1613), "Experience the magic of Mabel & Ed Sheeran in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.", "/img/michael.jpg", false, "Mabel & Ed Sheeran: Live in Concert", 79.99m, 79.99m },
                    { new Guid("fff88098-f7ab-4491-98bf-6b8fe8d2b6e0"), "Madison Beer", new DateTime(2026, 7, 28, 13, 26, 39, 868, DateTimeKind.Local).AddTicks(18), "An unforgettable night with Madison Beer showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.", "/img/banjo.jpg", false, "Madison Beer: World Tour", 119.99m, 119.99m }
                });
        }
    }
}
