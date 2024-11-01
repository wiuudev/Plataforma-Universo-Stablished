public class MenuDataService
{
    private List<MainMenuItems> MenuData = new List<MainMenuItems>()
    {
        new MainMenuItems(
            menuTitle: "Início"
        ),
        new MainMenuItems(
            type: "link",
            path: "/home",
            title: "Dashboard",
            icon: "bx bx-home",
            badgeClass: "bg-warning-transparent",
            selected: false,
            active: true,
            dirChange: false
        ),
        new MainMenuItems(
            menuTitle: "ATALHOS DE PÁGINAS"
        ),
        new MainMenuItems(
            type: "sub",
            title: "Páginas",
            icon: "bx bx-file-blank",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                
                new MainMenuItems (
                    path: "/auditoria",
                    type: "link",
                    title: "Auditoria",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                
                new MainMenuItems (
                    path: "/diagnosticogerencial",
                    type: "link",
                    title: "Diagnóstico Gerencial",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                
                new MainMenuItems (
                    path: "/chat",
                    type: "link",
                    title: "Chat",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/contacts",
                    type: "link",
                    title: "Contatos",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/contact-us",
                    type: "link",
                    title: "Contate-nos",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                type: "sub",
                title: "Compras",
                selected: false,
                active: false,
                dirChange: false,
                children: new MainMenuItems[]
                {
                  new MainMenuItems (
                    path: "/checkout",
                    type: "link",
                    title: "Checkout",
                    selected: false,
                    active: false,
                    dirChange: false
                  ),
                }
            ),
       
                new MainMenuItems (
                    path: "/faq's",
                    type: "link",
                    title: "Perguntas frequentes",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    type: "link",
                    path: "/file-manager",
                    title: "Arquivos",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/landing",
                    type: "external",
                    title: "Página inicial",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/notifications",
                    type: "link",
                    title: "Notificações",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/profile",
                    type: "link",
                    title: "Perfil",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/terms_conditions",
                    type: "link",
                    title: "Termos e condições",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/timeline",
                    type: "link",
                    title: "Linha do tempo",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        new MainMenuItems (
            type: "link",
            title: "Tarefas",
            path: "/task-kanban-board",
            icon: "bx bx-task",
            badgeValue: "Novas",
            badgeClass: "bg-secondary-transparent",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            type: "sub",
            title: "Autenticação",
            icon: "bx bx-fingerprint",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems ( 
                    path: "/coming-soon",
                    type: "link",
                    title: "Em breve",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems ( 
                    type: "link",
                    title: "Criar senha",
                    path: "/create-password-basic",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems ( 
                    type: "link",
                    path: "/reset-password-basic",
                    title: "Redefinir senha",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems ( 
                    type: "link",
                    path: "/sign-up-basic",
                    title: "Cadastro",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems ( 
                    type: "link",
                    title: "Entrar",
                    path: "/sign-in-basic",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems ( 
                    path: "/under-maintenance",
                    type: "link",
                    title: "Em manutenção",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        new MainMenuItems (
            type: "sub",
            title: "Erros",
            icon: "bx bx-error",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/401-error",
                    type: "link",
                    title: "Erro 401",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/404-error",
                    type: "link",
                    title: "Erro 404",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/500-error",
                    type: "link",
                    title: "Erro 500",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        /*
        new MainMenuItems (
            menuTitle: "GENERAL"
        ),
        new MainMenuItems (
            type: "sub",
            title: "Ui Elements",
            icon: "bx bx-box",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/alerts",
                    type: "link",
                    title: "Alerts",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/badge",
                    type: "link",
                    title: "Badge",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/breadcrumb",
                    type: "link",
                    title: "Breadcrumb",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/buttons",
                    type: "link",
                    title: "Buttons",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/buttongroup",
                    type: "link",
                    title: "Button Group",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/cards",
                    type: "link",
                    title: "Cards",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/dropdowns",
                    type: "link",
                    title: "Dropdowns",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/images_figures",
                    type: "link",
                    title: "Images & Figures",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/links_interactions",
                    type: "link",
                    title: "Links & Interactions",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/listgroup",
                    type: "link",
                    title: "List Group",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/navs_tabs",
                    type: "link",
                    title: "Navs & Tabs",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/object-fit",
                    type: "link",
                    title: "Object Fit",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/pagination",
                    type: "link",
                    title: "Pagination",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/popovers",
                    type: "link",
                    title: "Popovers",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/progress",
                    type: "link",
                    title: "Progress",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/spinners",
                    type: "link",
                    title: "Spinners",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/toasts",
                    type: "link",
                    title: "Toasts",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/tooltips",
                    type: "link",
                    title: "Tooltips",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/typography",
                    type: "link",
                    title: "Typography",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        new MainMenuItems (
            type: "sub",
            title: "Utilities",
            icon: "bx bx-medal",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/avatars",
                    type: "link",
                    title: "Avatars",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/borders",
                    type: "link",
                    title: "Borders",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/breakpoints",
                    type: "link",
                    title: "Breakpoints",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/colors",
                    type: "link",
                    title: "Colors",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/columns",
                    type: "link",
                    title: "Columns",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/flex",
                    type: "link",
                    title: "Flex",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/gutters",
                    type: "link",
                    title: "Gutters",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/helpers",
                    type: "link",
                    title: "Helpers",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/position",
                    type: "link",
                    title: "Position",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/more",
                    type: "link",
                    title: "Additional Content",
                    selected: false,
                    active: false,
                    dirChange: false
                )
            }
        ),
        new MainMenuItems (
            type: "sub",
            title: "Forms",
            icon: "bx bx-file",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    type: "sub",
                    title: "Form Elements",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/form_inputs",
                            type: "link",
                            title: "Inputs",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form_check_radios",
                            type: "link",
                            title: "Checks & Radios",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form_input_group",
                            type: "link",
                            title: "Input Group",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form_select",
                            type: "link",
                            title: "Form Select",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form_range",
                            type: "link",
                            title: "Range Slider",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form_input_masks",
                            type: "link",
                            title: "Input Masks",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form_file_uploads",
                            type: "link",
                            title: "File Uploads",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form_dateTime_pickers",
                            type: "link",
                            title: "Date,Time Picker",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form_color_pickers",
                            type: "link",
                            title: "Color Picker",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems ( 
                    type: "sub",
                    title: "Form Wizards",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems ( 
                            path: "/form-wizard",
                            type: "link",
                            title: "Js",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems ( 
                            path: "/blazor-form-wizard",
                            type: "link",
                            title: "Blazor",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "/floating_labels",
                    type: "link",
                    title: "Floating Labels",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/form_layout",
                    type: "link",
                    title: "Form Layouts",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    type: "sub",
                    title: "Form Editor",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/quill_editor",
                            type: "link",
                            title: "Quill Editor",
                            selected: false,
                            active: false,
                            dirChange: false
                        )
                    }
                ),
                new MainMenuItems (
                    path: "/form_validation",
                    type: "link",
                    title: "Validations",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/form_select2",
                    type: "link",
                    title: "Select2",
                    selected: false,
                    active: false,
                    dirChange: false
                )
            }
        ),
        new MainMenuItems (
            type: "sub",
            title: "Advanced Ui",
            icon: "bx bx-party",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/accordions_collpase",
                    type: "link",
                    title: "Accordion & Collapse",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/carousel",
                    type: "link",
                    title: "Carousel",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/draggable-cards",
                    type: "link",
                    title: "Draggable Cards",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/modals_closes",
                    type: "link",
                    title: "Modals & Closes",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/navbar",
                    type: "link",
                    title: "Navbars",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/offcanvas",
                    type: "link",
                    title: "Offcanvas",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/placeholders",
                    type: "link",
                    title: "Placeholders",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/ratings",
                    type: "link",
                    title: "Ratings",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/slickcarousel",
                    type: "link",
                    title: "Slick Carousel",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/treeview",
                    type: "link",
                    title: "Treeview",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        new MainMenuItems (
            path: "/widgets",
            type: "link",
            title: "Widgets",
            icon: "bx bx-gift",
            badgeValue: "Hot",
            badgeClass: "bg-danger-transparent",
            selected: false,
            active: false,
            dirChange: false
        ), */
        };

    public List<MainMenuItems> GetMenuData()
   {
        return MenuData;
    }
}
