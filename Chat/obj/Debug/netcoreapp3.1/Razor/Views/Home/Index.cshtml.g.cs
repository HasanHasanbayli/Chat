#pragma checksum "C:\Users\Hasan Hasanbayli\Desktop\Chat\Chat\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40d4ab511fe78ff495207c015109357e27b4b077"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\Hasan Hasanbayli\Desktop\Chat\Chat\Views\_ViewImports.cshtml"
using Chat.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hasan Hasanbayli\Desktop\Chat\Chat\Views\_ViewImports.cshtml"
using Chat.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40d4ab511fe78ff495207c015109357e27b4b077", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea9095843343c70b187561ea2b7dc4966bbfeebc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Hasan Hasanbayli\Desktop\Chat\Chat\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<aside class=""sidebar"">
    <div class=""tab-content"">
        <!-- Chat Tab Content Start -->
        <div class=""tab-pane active"" id=""chats-content"">
            <div class=""d-flex flex-column h-100"">
                <div class=""hide-scrollbar h-100"" id=""chatContactsList"">

                    <!-- Chat Header Start -->
                    <div class=""sidebar-header sticky-top p-2"">

                        <div class=""d-flex justify-content-between align-items-center"">
                            <!-- Chat Tab Pane Title Start -->
                            <h5 class=""font-weight-semibold mb-0"">Chats</h5>
                            <!-- Chat Tab Pane Title End -->

                            <ul class=""nav flex-nowrap"">

                                <li class=""nav-item list-inline-item mr-1"">
                                    <a class=""nav-link text-muted px-1"" href=""#"" title=""Notifications""
                                       role=""button"" data-toggle=""modal"" data-target=""#n");
            WriteLiteral(@"otificationModal"">
                                        <!-- Default :: Inline SVG -->
                                        <svg class=""hw-20"" fill=""none"" viewBox=""0 0 24 24""
                                             stroke=""currentColor"">
                                            <path stroke-linecap=""round"" stroke-linejoin=""round""
                                                  stroke-width=""2""
                                                  d=""M15 17h5l-1.405-1.405A2.032 2.032 0 0118 14.158V11a6.002 6.002 0 00-4-5.659V5a2 2 0 10-4 0v.341C7.67 6.165 6 8.388 6 11v3.159c0 .538-.214 1.055-.595 1.436L4 17h5m6 0v1a3 3 0 11-6 0v-1m6 0H9"" />
                                        </svg>

                                        <!-- Alternate :: External File link -->
                                        <!-- <img src=""./../assets/media/heroicons/outline/bell.svg"" alt="""" class=""injectable hw-20""> -->
                                    </a>
                                </li>

   ");
            WriteLiteral(@"                             <li class=""nav-item list-inline-item d-block d-xl-none mr-1"">
                                    <a class=""nav-link text-muted px-1"" href=""#"" title=""Appbar""
                                       data-toggle-appbar="""">
                                        <!-- Default :: Inline SVG -->
                                        <svg class=""hw-20"" fill=""none"" stroke-linecap=""round""
                                             stroke-linejoin=""round"" stroke-width=""2"" viewBox=""0 0 24 24""
                                             stroke=""currentColor"">
                                            <path d=""M4 6a2 2 0 012-2h2a2 2 0 012 2v2a2 2 0 01-2 2H6a2 2 0 01-2-2V6zM14 6a2 2 0 012-2h2a2 2 0 012 2v2a2 2 0 01-2 2h-2a2 2 0 01-2-2V6zM4 16a2 2 0 012-2h2a2 2 0 012 2v2a2 2 0 01-2 2H6a2 2 0 01-2-2v-2zM14 16a2 2 0 012-2h2a2 2 0 012 2v2a2 2 0 01-2 2h-2a2 2 0 01-2-2v-2z"">
                                            </path>
                                        </svg>

         ");
            WriteLiteral(@"                               <!-- Alternate :: External File link -->
                                        <!-- <img class=""hw-20"" src=""./../assets/media/heroicons/outline/view-grid.svg"" alt="""" class=""injectable hw-20""> -->
                                    </a>
                                </li>

                                <li class=""nav-item list-inline-item mr-0"">
                                    <div class=""dropdown"">
                                        <a class=""nav-link text-muted px-1"" href=""#"" role=""button""
                                           title=""Details"" data-toggle=""dropdown"" aria-haspopup=""true""
                                           aria-expanded=""false"">
                                            <!-- Default :: Inline SVG -->
                                            <svg class=""hw-20"" fill=""none"" viewBox=""0 0 24 24""
                                                 stroke=""currentColor"">
                                                <path str");
            WriteLiteral(@"oke-linecap=""round"" stroke-linejoin=""round""
                                                      stroke-width=""2""
                                                      d=""M12 5v.01M12 12v.01M12 19v.01M12 6a1 1 0 110-2 1 1 0 010 2zm0 7a1 1 0 110-2 1 1 0 010 2zm0 7a1 1 0 110-2 1 1 0 010 2z"" />
                                            </svg>

                                            <!-- Alternate :: External File link -->
                                            <!-- <img src=""./../assets/media/heroicons/outline/dots-vertical.svg"" alt="""" class=""injectable hw-20""> -->
                                        </a>

                                        <div class=""dropdown-menu dropdown-menu-right"">
                                            <a class=""dropdown-item"" href=""#"" role=""button"" data-toggle=""modal""
                                               data-target=""#startConversation"">New Chat</a>
                                            <a class=""dropdown-item"" href=""#"" role=""button""");
            WriteLiteral(@" data-toggle=""modal""
                                               data-target=""#createGroup"">Create Group</a>
                                            <a class=""dropdown-item"" href=""#"" role=""button"" data-toggle=""modal""
                                               data-target=""#inviteOthers"">Invite Others</a>
                                        </div>
                                    </div>
                                </li>
                            </ul>
                        </div>


                        <!-- Sidebar Header Start -->
                        <div class=""sidebar-sub-header"">
                            <!-- Sidebar Header Dropdown Start -->
                            <div class=""dropdown mr-2"">
                                <!-- Dropdown Button Start -->
                                <button class=""btn btn-outline-default dropdown-toggle"" type=""button""
                                        data-chat-filter-list="""" data-toggle=""dropdown"" aria-has");
            WriteLiteral(@"popup=""true""
                                        aria-expanded=""false"">
                                    All Chats
                                </button>
                                <!-- Dropdown Button End -->
                                <!-- Dropdown Menu Start -->
                                <div class=""dropdown-menu"">
                                    <a class=""dropdown-item"" data-chat-filter="""" data-select=""all-chats""
                                       href=""#"">All Chats</a>
                                    <a class=""dropdown-item"" data-chat-filter="""" data-select=""friends""
                                       href=""#"">Friends</a>
                                    <a class=""dropdown-item"" data-chat-filter="""" data-select=""groups""
                                       href=""#"">Groups</a>
                                    <a class=""dropdown-item"" data-chat-filter="""" data-select=""unread""
                                       href=""#"">Unread</a>
           ");
            WriteLiteral(@"                         <a class=""dropdown-item"" data-chat-filter="""" data-select=""archived""
                                       href=""#"">Archived</a>
                                </div>
                                <!-- Dropdown Menu End -->
                            </div>
                            <!-- Sidebar Header Dropdown End -->
                            <!-- Sidebar Search Start -->
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40d4ab511fe78ff495207c015109357e27b4b07711808", async() => {
                WriteLiteral(@"
                                <div class=""input-group"">
                                    <input type=""text""
                                           class=""form-control search border-right-0 transparent-bg pr-0""
                                           placeholder=""Search users..."">
                                    <div class=""input-group-append"">
                                        <div class=""input-group-text transparent-bg border-left-0""
                                             role=""button"">
                                            <!-- Default :: Inline SVG -->
                                            <svg class=""text-muted hw-20"" fill=""none"" viewBox=""0 0 24 24""
                                                 stroke=""currentColor"">
                                                <path stroke-linecap=""round"" stroke-linejoin=""round""
                                                      stroke-width=""2""
                                                      d=""M21 21l");
                WriteLiteral(@"-6-6m2-5a7 7 0 11-14 0 7 7 0 0114 0z"" />
                                            </svg>

                                            <!-- Alternate :: External File link -->
                                            <!-- <img class=""injectable hw-20"" src=""./../assets/media/heroicons/outline/search.svg"" alt=""""> -->
                                        </div>
                                    </div>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <!-- Sidebar Search End -->
                        </div>
                        <!-- Sidebar Header End -->
                    </div>
                    <!-- Chat Header End -->
                    <!-- Chat Contact List Start -->
                    <ul class=""contacts-list"" id=""chatContactTab"" data-chat-list="""">
                        <!-- Chat Item Start -->
                        <li class=""contacts-item friends"">
                            <a class=""contacts-link"" href=""chat-1.html"">
                                <div class=""avatar avatar-online"">
                                    <img src=""../assets/media/avatar/2.png""");
            BeginWriteAttribute("alt", " alt=\"", 9885, "\"", 9891, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""contacts-content"">
                                    <div class=""contacts-info"">
                                        <h6 class=""chat-name text-truncate"">Catherine Richardson</h6>
                                        <div class=""chat-time"">Just now</div>
                                    </div>
                                    <div class=""contacts-texts"">
                                        <p class=""text-truncate"">
                                            I’m sorry, I didn’t catch that. Could you
                                            please repeat?
                                        </p>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <!-- Chat Item End -->
                        <!-- Chat Item Start -->
                        <li class=""contacts-item grou");
            WriteLiteral(@"ps"">
                            <a class=""contacts-link"" href=""chat-2.html"">
                                <div class=""avatar bg-success text-light"">
                                    <span>
                                        <!-- Default :: Inline SVG -->
                                        <svg class=""hw-24"" fill=""none"" viewBox=""0 0 24 24""
                                             stroke=""currentColor"">
                                            <path stroke-linecap=""round"" stroke-linejoin=""round""
                                                  stroke-width=""2""
                                                  d=""M17 20h5v-2a3 3 0 00-5.356-1.857M17 20H7m10 0v-2c0-.656-.126-1.283-.356-1.857M7 20H2v-2a3 3 0 015.356-1.857M7 20v-2c0-.656.126-1.283.356-1.857m0 0a5.002 5.002 0 019.288 0M15 7a3 3 0 11-6 0 3 3 0 016 0zm6 3a2 2 0 11-4 0 2 2 0 014 0zM7 10a2 2 0 11-4 0 2 2 0 014 0z"" />
                                        </svg>

                                        <!-- Alternate");
            WriteLiteral(@" :: External File link -->
                                        <!-- <img class=""injectable"" src=""./../assets/media/heroicons/outline/user-group.svg"" alt=""""> -->
                                    </span>
                                </div>
                                <div class=""contacts-content"">
                                    <div class=""contacts-info"">
                                        <h6 class=""chat-name"">Themeforest Group</h6>
                                        <div class=""chat-time""><span>10:20 pm</span></div>
                                    </div>
                                    <div class=""contacts-texts"">
                                        <p class=""text-truncate"">
                                            <span>Jeny: </span>That’s pretty common. I
                                            heard that a lot of people had the same experience.
                                        </p>
                                        <div class=""d-inl");
            WriteLiteral(@"ine-flex align-items-center ml-1"">
                                            <!-- Default :: Inline SVG -->
                                            <svg class=""hw-16 text-muted"" viewBox=""0 0 20 20""
                                                 fill=""currentColor"">
                                                <path fill-rule=""evenodd""
                                                      d=""M5 9V7a5 5 0 0110 0v2a2 2 0 012 2v5a2 2 0 01-2 2H5a2 2 0 01-2-2v-5a2 2 0 012-2zm8-2v2H7V7a3 3 0 016 0z""
                                                      clip-rule=""evenodd"" />
                                            </svg>

                                            <!-- Alternate :: External File link -->
                                            <!-- <img class=""injectable hw-16 text-muted"" src=""./../assets/media/heroicons/solid/lock-closed.svg"" alt=""""> -->
                                        </div>
                                    </div>
                                </div>
");
            WriteLiteral(@"                            </a>
                        </li>
                        <!-- Chat Item End -->
                        <!-- Chat Item Start -->
                        <li class=""contacts-item friends unread"">
                            <a class=""contacts-link"" href=""#"">
                                <div class=""avatar avatar-offline bg-info text-light"">
                                    <span>EW</span>
                                </div>
                                <div class=""contacts-content"">
                                    <div class=""contacts-info"">
                                        <h6 class=""chat-name"">Eva Walker</h6>
                                        <div class=""chat-time"">09:36 am</div>
                                    </div>
                                    <div class=""contacts-texts"">
                                        <p class=""text-truncate"">
                                            You’re kidding! I drive a motorcycle as w");
            WriteLiteral(@"ell.
                                            What type of bike do you have?
                                        </p>
                                        <div class=""badge badge-rounded badge-primary ml-1"">2</div>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <!-- Chat Item End -->
                        <!-- Chat Item Start -->
                        <li class=""contacts-item friends"">
                            <a class=""contacts-link"" href=""#"">
                                <div class=""avatar avatar-busy"">
                                    <img src=""../assets/media/avatar/3.png""");
            BeginWriteAttribute("alt", " alt=\"", 15753, "\"", 15759, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""contacts-content"">
                                    <div class=""contacts-info"">
                                        <h6 class=""chat-name"">Christopher Garcia</h6>
                                        <div class=""chat-time""><span>Yesterday</span></div>
                                    </div>
                                    <div class=""contacts-texts"">
                                        <!-- Default :: Inline SVG -->
                                        <svg class=""hw-20 text-muted"" viewBox=""0 0 20 20"" fill=""currentColor"">
                                            <path fill-rule=""evenodd""
                                                  d=""M4 3a2 2 0 00-2 2v10a2 2 0 002 2h12a2 2 0 002-2V5a2 2 0 00-2-2H4zm12 12H4l4-8 3 6 2-4 3 6z""
                                                  clip-rule=""evenodd"" />
                                        </svg>

                                     ");
            WriteLiteral(@"   <!-- Alternate :: External File link -->
                                        <!-- <img class=""injectable text-muted"" src=""./../assets/media/heroicons/solid/photograph.svg"" alt=""""> -->
                                        <p class=""text-truncate"">Photo</p>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <!-- Chat Item End -->
                        <!-- Chat Item Start -->
                        <li class=""contacts-item unread"">
                            <a class=""contacts-link"" href=""#"">
                                <div class=""avatar avatar-online"">
                                    <img src=""../assets/media/avatar/4.png""");
            BeginWriteAttribute("alt", " alt=\"", 17566, "\"", 17572, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""contacts-content"">
                                    <div class=""contacts-info"">
                                        <h6 class=""chat-name"">Christina Turner</h6>
                                        <div class=""chat-time"">
                                            <span>31/05/20</span>
                                        </div>
                                    </div>
                                    <div class=""contacts-texts"">
                                        <p class=""text-truncate"">
                                            I’m working hard in Maths, Physics and
                                            Chemistry. I have planning to appear in I.I.T. after XII.
                                        </p>
                                        <div class=""badge badge-rounded badge-primary ml-1"">10</div>
                                    </div>
                               ");
            WriteLiteral(@" </div>
                            </a>
                        </li>
                        <!-- Chat Item End -->
                        <!-- Chat Item Start -->
                        <li class=""contacts-item friends"">
                            <a class=""contacts-link"" href=""#"">
                                <div class=""avatar avatar-offline"">
                                    <img src=""../assets/media/avatar/5.png""");
            BeginWriteAttribute("alt", " alt=\"", 19037, "\"", 19043, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""contacts-content"">
                                    <div class=""contacts-info"">
                                        <h6 class=""chat-name"">Tammy Martinez</h6>
                                        <div class=""chat-time"">
                                            <span>24/04/20</span>
                                        </div>
                                    </div>
                                    <div class=""contacts-texts"">
                                        <!-- Default :: Inline SVG -->
                                        <svg class=""hw-20 text-muted"" viewBox=""0 0 20 20"" fill=""currentColor"">
                                            <path fill-rule=""evenodd""
                                                  d=""M6 2a2 2 0 00-2 2v12a2 2 0 002 2h8a2 2 0 002-2V7.414A2 2 0 0015.414 6L12 2.586A2 2 0 0010.586 2H6zm2 10a1 1 0 10-2 0v3a1 1 0 102 0v-3zm2-3a1 1 0 011 1v5a1 1 0 11-2 0v-5a1 ");
            WriteLiteral(@"1 0 011-1zm4-1a1 1 0 10-2 0v7a1 1 0 102 0V8z""
                                                  clip-rule=""evenodd"" />
                                        </svg>

                                        <!-- Alternate :: External File link -->
                                        <!-- <img class=""injectable text-muted"" src=""./../assets/media/heroicons/solid/document-report.svg"" alt=""""> -->
                                        <p class=""text-truncate"">project_guidelines.docs</p>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <!-- Chat Item End -->
                        <!-- Chat Item Start -->
                        <li class=""contacts-item friends"">
                            <a class=""contacts-link"" href=""#"">
                                <div class=""avatar avatar-online"">
                                    <img src=""../assets/media/avatar/6.png""");
            BeginWriteAttribute("alt", "\r\n                                         alt=\"", 21082, "\"", 21130, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""contacts-content"">
                                    <div class=""contacts-info"">
                                        <h6 class=""chat-name"">Bonnie Torres</h6>
                                        <div class=""chat-time""><span>20/04/20</span></div>
                                    </div>
                                    <div class=""contacts-texts"">
                                        <p class=""text-truncate"">Catch you later! Bye-bye!</p>
                                        <div class=""d-inline-flex align-items-center ml-1"">
                                            <!-- Default :: Inline SVG -->
                                            <svg class=""hw-16 text-muted"" viewBox=""0 0 20 20""
                                                 fill=""currentColor"">
                                                <path fill-rule=""evenodd""
                                                      d=""M9.38");
            WriteLiteral(@"3 3.076A1 1 0 0110 4v12a1 1 0 01-1.707.707L4.586 13H2a1 1 0 01-1-1V8a1 1 0 011-1h2.586l3.707-3.707a1 1 0 011.09-.217zM12.293 7.293a1 1 0 011.414 0L15 8.586l1.293-1.293a1 1 0 111.414 1.414L16.414 10l1.293 1.293a1 1 0 01-1.414 1.414L15 11.414l-1.293 1.293a1 1 0 01-1.414-1.414L13.586 10l-1.293-1.293a1 1 0 010-1.414z""
                                                      clip-rule=""evenodd"" />
                                            </svg>
                                            <!-- Alternate :: External File link -->
                                            <!-- <img class=""injectable hw-16 text-muted"" src=""./../assets/media/heroicons/solid/volume-off.svg"" alt=""""> -->
                                        </div>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <!-- Chat Item End -->
                        <!-- Chat Item Start -->
                        <li class=""con");
            WriteLiteral("tacts-item friends\">\r\n                            <a class=\"contacts-link\" href=\"#\">\r\n                                <div class=\"avatar avatar-offline\">\r\n                                    <img src=\"../assets/media/avatar/7.png\"");
            BeginWriteAttribute("alt", "\r\n                                         alt=\"", 23409, "\"", 23457, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""contacts-content"">
                                    <div class=""contacts-info"">
                                        <h6 class=""chat-name"">Jacqueline James</h6>
                                        <div class=""chat-time""><span>15/02/20</span></div>
                                    </div>
                                    <div class=""contacts-texts"">
                                        <!-- Default :: Inline SVG -->
                                        <svg class=""hw-16 text-muted"" viewBox=""0 0 20 20"" fill=""currentColor"">
                                            <path d=""M14.414 7l3.293-3.293a1 1 0 00-1.414-1.414L13 5.586V4a1 1 0 10-2 0v4.003a.996.996 0 00.617.921A.997.997 0 0012 9h4a1 1 0 100-2h-1.586z"" />
                                            <path d=""M2 3a1 1 0 011-1h2.153a1 1 0 01.986.836l.74 4.435a1 1 0 01-.54 1.06l-1.548.773a11.037 11.037 0 006.105 6.105l.774-1.548a1 1 0 011.059-.");
            WriteLiteral(@"54l4.435.74a1 1 0 01.836.986V17a1 1 0 01-1 1h-2C7.82 18 2 12.18 2 5V3z"" />
                                        </svg>

                                        <!-- Alternate :: External File link -->
                                        <!-- <img class=""injectable hw-16 text-muted"" src=""./../assets/media/heroicons/solid/phone-incoming.svg"" alt=""""> -->
                                        <p class=""text-truncate"">Missed call</p>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <!-- Chat Item End -->
                        <!-- Chat Item Start -->
                        <li class=""contacts-item archived"">
                            <a class=""contacts-link"" href=""#"">
                                <div class=""avatar avatar-away"">
                                    <img src=""../assets/media/avatar/8.png""");
            BeginWriteAttribute("alt", " alt=\"", 25443, "\"", 25449, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""contacts-content"">
                                    <div class=""contacts-info"">
                                        <h6 class=""chat-name"">Annie Richardson</h6>
                                        <div class=""chat-time""><span>26/12/19</span></div>
                                    </div>
                                    <div class=""contacts-texts"">
                                        <p class=""text-truncate"">
                                            I think I have everything I need, thank you!
                                        </p>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <!-- Chat Item End -->
                    </ul>
                    <!-- Chat Contact List End -->
                </div>
            </div>
        </div>
        <!-- Chats Tab Con");
            WriteLiteral(@"tent End -->
    </div>
</aside>
<main class=""main"">
    <!-- Chats Page Start -->
    <div class=""chats"">
        <div class=""d-flex flex-column justify-content-center text-center h-100 w-100"">
            <div class=""container"">
                <div class=""avatar avatar-lg mb-2"">
                    <img class=""avatar-img"" src=""../assets/media/avatar/4.png""");
            BeginWriteAttribute("alt", " alt=\"", 26844, "\"", 26850, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>

                <h5>Welcome, Christina!</h5>
                <p class=""text-muted"">Please select a chat to Start messaging.</p>

                <button class=""btn btn-outline-primary no-box-shadow"" type=""button"" data-toggle=""modal""
                        data-target=""#startConversation"">
                    Start a conversation
                </button>
            </div>
        </div>
    </div>
    <!-- Chats Page End -->
</main>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
