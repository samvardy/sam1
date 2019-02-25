<![CDATA[/* 
-----------------------------------------------
Blogger Template Style
Name:        adnor One
Author :     http://www.Adnor company.com
License:     Premium Version
----------------------------------------------- */
/* Variable definitions
-----------------------
<Variable name="body.background" description="Background" type="background" color="#f0f0f0" default="$(color) url(http://1.bp.blogspot.com/-eaKdOOTPFg4/Wa6BGUOr5jI/AAAAAAAAD0U/SvDwHkUHrlYoRDGXuUEoM8YjXM7uo4DaACK4BGAYYCw/s1600/background-4.jpg) repeat fixed top left" value="$(color) url(http://1.bp.blogspot.com/-eaKdOOTPFg4/Wa6BGUOr5jI/AAAAAAAAD0U/SvDwHkUHrlYoRDGXuUEoM8YjXM7uo4DaACK4BGAYYCw/s1600/background-4.jpg) repeat fixed top left"/>
<Group description="Main Settings" selector="body">
<Variable name="maincolor" description="Primary Color" type="color" default="#0088ff"  value="#0088ff"/>
<Variable name="darkcolor" description="Primary Text Color" type="color" default="#000000"  value="#000000"/>
</Group>
-----------------------
*/
/*****************************************
reset.css
******************************************/
html, body, .section, .widget, div, span, applet, object, iframe,
h1, h2, h3, h4, h5, h6, p, blockquote, pre,
a, abbr, acronym, address, big, cite, code,
del, dfn, em, font, img, ins, kbd, q, s, samp,
small, strike, strong, sub, sup, tt, var,
dl, dt, dd, ol, ul, li,
fieldset, form, label, legend,
table, caption, tbody, tfoot, thead, tr, th, td, figure {    margin: 0;    padding: 0;}
html {   overflow-x: hidden;}
a {text-decoration:none;color:#000;}
article,aside,details,figcaption,figure,
footer,header,hgroup,menu,nav,section {     display:block;}
table {    border-collapse: separate;    border-spacing: 0;}
caption, th, td {    text-align: left;    font-weight: normal;}
blockquote:before, blockquote:after,
q:before, q:after {    content: "";}
.quickedit, .home-link{display:none;}
blockquote, q {    quotes: "" "";}
sup{    vertical-align: super;    font-size:smaller;}
code{    font-family: 'Courier New', Courier, monospace;    font-size:12px;    color:#272727;}
::-moz-selection{background-color:$maincolor;color:#fff}
::selection{background-color:$maincolor;color:#fff}
a img{	border: none;}
ol, ul { padding:0;  margin:0;  text-align: left;  }
ol li { list-style-type: decimal;  padding:0 0 5px;  }
ul li { list-style-type: disc;  padding: 0 0 5px;  }
ul ul, ol ol { padding: 0; }
.section, .widget, .widget ul {
    margin: 0;
    padding: 0;
}
abbr.published.timeago {
    text-decoration: none;
}
#navbar-iframe, .navbar, .Attribution, .post-author-widget, .post-author-social {   height:0px;   visibility:hidden;   display:none   }
.feed-links, .post-footer-line.post-footer-line-1, .post-footer-line.post-footer-line-2 , .post-footer-line.post-footer-line-3 {
display: none;
}
.item-control {
display: none !important;
}
h2.date-header, h4.date-header {display:none;margin:1.5em 0 .5em}
h1, h2, h3, h4, h5, h6 {
font-family: inherit;
font-weight: 400;
color: #2e2e2e;
}
img {
    max-width: 100%;
    vertical-align: middle;
    border: 0;
}
.widget iframe, .widget img {
    max-width: 100%;
}
.status-msg-border {
border: 1px solid #ff545a;
background:$maincolor;
}
.status-msg-body {
    color: $darkcolor;
    font-family: inherit;
    letter-spacing: 0px;
    font-weight: 400;
}
* {
    outline: 0;
    transition: all .2s ease;
    -webkit-transition: all .2s ease;
    -moz-transition: all .2s ease;
    -o-transition: all .2s ease;
}
/*****************************************
Custom css starts
******************************************/
body {
color: #2e2e2e;
font-family:Montserrat;
font-size: 14px;
font-weight: normal;
line-height: 21px;
background:$(body.background);
text-align:left;
}
/* ######## Wrapper Css ######################### */
#body-wrapper{max-width:100%;margin:0 auto;background-color:#FFF;box-shadow:0 0 5px RGBA(0, 0, 0, 0.2)}
.body-row{width:1170px}
#content-wrapper {
margin: 0 auto;
padding: 20px 0 40px;
overflow: hidden;
}
#main-wrapper {
float: left;
width:68%;
    max-width: 800px;
}
#sidebar-wrapper {
float: right;
width:30%;
    max-width: 340px;
}
/* ######## Top Header Bar Css ######################### */
.top-bar {
background: $darkcolor;
}
.top-bar-wrapper {
position: relative;
min-height:40px;
color: #aaaaaa;
margin:0 auto;
}
.top-bar-social {
float: left;
padding: 5px 0;
}
.top-bar-social li {
display: inline;
padding: 0;
float: left;
margin-right: 5px;
;
}
.top-bar-social .widget ul {
padding: 0;
}
.top-bar-social .LinkList ul {
text-align: center;
margin: 0;
}
.top-bar-social #social a {
display: block;
width: 30px;
height: 30px;
line-height: 30px;
font-size: 15px;
color: #eeeeee;
transition: background 0.3s linear;
-moz-transition: background 0.3s linear;
-webkit-transition: background 0.3s linear;
-o-transition: background 0.3s linear;
}
.top-bar-social #social a:before {
display: inline-block;
font: normal normal normal 22px/1 FontAwesome;
font-size: inherit;
font-style: normal;
font-weight: 400;
-webkit-font-smoothing: antialiased;
-moz-osx-font-smoothing: grayscale;
}
.top-bar-social .bloglovin:before{content:"\f004"}
.top-bar-social .facebook:before{content:"\f09a"}
.top-bar-social .twitter:before{content:"\f099"}
.top-bar-social .gplus:before{content:"\f0d5"}
.top-bar-social .rss:before{content:"\f09e"}
.top-bar-social .youtube:before{content:"\f167"}
.top-bar-social .skype:before{content:"\f17e"}
.top-bar-social .stumbleupon:before{content:"\f1a4"}
.top-bar-social .tumblr:before{content:"\f173"}
.top-bar-social .vine:before{content:"\f1ca"}
.top-bar-social .stack-overflow:before{content:"\f16c"}
.top-bar-social .linkedin:before{content:"\f0e1"}
.top-bar-social .dribbble:before{content:"\f17d"}
.top-bar-social .soundcloud:before{content:"\f1be"}
.top-bar-social .behance:before{content:"\f1b4"}
.top-bar-social .digg:before{content:"\f1a6"}
.top-bar-social .instagram:before{content:"\f16d"}
.top-bar-social .pinterest:before{content:"\f0d2"}
.top-bar-social .delicious:before{content:"\f1a5"}
.top-bar-social .codepen:before{content:"\f1cb"}
.top-bar-social ul#social a:hover {
color: $maincolor;
opacity: 1;
}
.top-bar-menu {
float: right;
}
.top-menu ul {
overflow: hidden;
list-style: none;
padding: 0;
margin: 0;
}
.top-menu ul li {
float: left;
display: inline-block;
list-style: none;
padding: 0;
}
.top-menu ul li a {
padding: 10px 16px;
display: block;
border: none !important;
text-decoration: none;
line-height: inherit;
font-size: 14px;
font-weight: normal;
color: #eeeeee;
text-transform: capitalize;
    font-family: inherit;
}
.top-menu ul li a:hover {
color:$maincolor;
}
/* ######## Search widget Css ######################### */
.header-search {
       position: relative;
    float: right;
    z-index: 999;
}
.header-search li {
    list-style: none
}
.header-search a.search {
    -webkit-transition: all .3s ease-out 0;
    -moz-transition: all .3s ease-out 0;
    transition: all .3s ease-out 0;
    cursor: pointer;
    display: block;
    height: 50px;
    text-align: center;
    position: relative;
    right: 0;
    top: 0;
    width: 50px;
    border-radius: 0;
 background-color: $darkcolor
}
.header-search a.search:hover {
    background-color: $maincolor
}
.header-search a.search:before {
    color: #E4E4E4;
    content: '\f002';
    font: normal normal normal 22px/1 FontAwesome;
    font-size: inherit;
    text-rendering: auto;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    line-height: 50px
}
.header-search a.active:before,
.header-search a.search:hover:before {
    color: #FFF
}
.header-search a.search.active {
    background-color: $maincolor;
    border-left: 0;
    border-radius: 0
}
.header-search a.search.active form {
    display: block
}
.header-search a.search form {
    display: none;
    position: absolute;
    right: 50px;
    top: 0;
    z-index: 2
}
.header-search a.search form input {
    box-shadow: none;
    height: 50px;
    padding: 0 12px;
    width: 160px;
    background-color:$darkcolor;
    color: #fff;
    margin-top: 0;
    border-radius: 0;
    border: 0;
    line-height: 50px
}
/* ######## Header Css ######################### */
.header-wrap {
background:#fff;
}
#header-wrappers {
color: #fff;
padding: 30px 0;
margin:0 auto;
}
#header-inner {
background-position: left;
background-repeat: no;
}
.headerleft img {
height: auto;
max-height: 100%;
margin:0
}
.headerleft h1,
.headerleft h1 a,
.headerleft h1 a:hover,
.headerleft h1 a:visited {
font-family:  Kalam;
color: $darkcolor;
font-size: 52px;
font-weight:bold;
line-height: 1.2em;
margin: 0;
padding: 0 0 5px;
text-decoration: none;
text-transform: uppercase;
}
.headerleft h3 {
font-weight: 400;
margin: 0;
padding: 0;
}
.headerleft .description {
color: #666;
    margin: 0;
    padding: 0 0 10px;
    text-transform: capitalize;
    text-align: center;
    text-indent: 0;
    font-size:13px;
font-style:italic;
line-height:1.5em;
}
.headerleft {
float: left;
margin: 0;
padding: 0;
width: auto;
}
.headerright {
float: right;
margin: 0;
padding: 1px 0 0;
width: 730px;
}
.headerleft .description span {
    border-top: 1px solid rgba(241, 241, 241, 0.25);
    padding: 5px 0 0;
}
/* ######## Navigation Menu Css ######################### */
.selectnav {
display:none;
}
.tm-menu {
    font-weight: 400;
    margin: 0 auto;
    height:50px;
}
ul#nav1 {
    list-style: none;
    margin: 0;
    padding: 0;
}
#menu .widget {
    display: none;
    float: left;
}
#menu {
    height: 50px;
    position: relative;
    text-align: center;
    z-index: 15;
margin:0 auto;
padding-right:50px;
display:inline-block;
}
.menu-wrap {
margin:0 auto;
position: relative;
    background: $darkcolor;
    height: 50px;
}
.tm-menu .hub-home {
float: left;
    display: inline-block;
    padding: 0!important;
    height: 50px;
    width: 50px;
    text-align: center;
border-radius:100%;
}

.tm-menu .hub-home a {
 font-size: 20px;
    line-height: 35px;
    max-height: 35px;
    width: 35px;
    margin: 2px;
    padding: 0!important;
    display: block;
    color: #fff;
    border: 5px solid $maincolor;
    border-radius: 100%;
    -webkit-transition: .3s ease-out;
    transition: .3s ease-out;
}

.tm-menu .hub-home:hover > a {
   background-color:$maincolor;
border-color:#fff;
}
#menu ul > li {
    position: relative;
    vertical-align: middle;
    display: inline-block;
    padding: 0;
    margin: 0;
}
#menu ul > li:hover > a {
   
}
#menu ul > li > a {
    color: #fff;
    font-size: 14px;
    font-weight: 600;
    line-height: 50px;
    display: inline-block;
    text-transform: uppercase;
    text-decoration: none;
    letter-spacing: 1px;
    margin: 0;
    padding: 0 12px;
    font-family: inherit;
}

#menu ul > li > ul > li:first-child > a {
    padding-left: 12px
}
#menu ul > li > ul {
    position: absolute;
    background: #4d4d4d;
    top: 100%;
    left: 0;
    min-width: 180px;
    padding: 0;
    z-index: 99;
    margin-top: 0;
    visibility: hidden;
    opacity: 0;
    -webkit-transform: translateY(10px);
    -moz-transform: translateY(10px);
    transform: translateY(10px)
}
#menu ul > li > ul > li > ul {
    position: absolute;
    top: 0;
    left: 180px;
    width: 180px;
    background: #5d5d5d;
    z-index: 99;
    margin-top: 0;
    margin-left: 0;
    padding: 0;
    border-left: 1px solid #6d6d6d;
    visibility: hidden;
    opacity: 0;
    -webkit-transform: translateY(10px);
    -moz-transform: translateY(10px);
    transform: translateY(10px)
}
#menu ul > li > ul > li {
    display: block;
    float: none;
    text-align: left;
    position: relative;
border-bottom: 1px solid;
    border-top: none;
    border-color: #8d8d8d;
}
#menu ul > li > ul > li:last-child {
    border: 0;
}
#menu ul li:after {
    content: "|";
    display: block;
    position: absolute;
    margin: auto;
    top: -20px;
    right: -5px;
    bottom: 0;
    width: 8px;
    height: 8px;
    text-align: center;
    font-weight: 400;
    font-size: 20px;
    text-rendering: auto;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    color: #5c5c5c;
}
#menu ul li.parent ul li:after, #menu ul li:last-child:after {
   display:none;
}
#menu ul > li:hover {
    background-color: $maincolor
}
#menu ul > li > ul > li a {
    font-size: 11px;
    display: block;
    color: #fff;
    line-height: 35px;
    text-transform: uppercase;
    text-decoration: none;
    margin: 0;
    padding: 0 12px;
    border-right: 0;
    border: 0
}
#menu ul > li.parent > a:after {
    content: '\f107';
    font-family: FontAwesome;
    float: right;
    margin-left: 5px
}
#menu ul > li:hover > ul,
#menu ul > li > ul > li:hover > ul {
    opacity: 1;
    visibility: visible;
    -webkit-transform: translateY(0);
    -moz-transform: translateY(0);
    transform: translateY(0)
}
#menu ul > li > ul > li.parent > a:after {
    content: '\f105';
    float: right
}
#menu ul ul {

}
/* ######## Ticker Css ######################### */
.news-tick-bar {
margin: 10px 0 0;
width:auto;
}
.ticker .title {
float: left;
height: 40px;
font-size: 15px;
color: #fff;
line-height: 40px;
font-weight: 400;
overflow: hidden;
padding: 0 10px;
background:$maincolor;
    font-family: inherit;
}
.ticker .title .fa {
margin-right: 10px;
    background: #fff;
    padding: 5px 6px;
    border-radius: 100%;
    color: $maincolor;
}
.ticker .widget-content {
height: 40px;
box-sizing: border-box;
overflow: hidden;
padding: 0 4px;
border: 1px solid rgba(14, 185, 117, 0.22);
}
.ticker .widget-content ul {
float:left;
}
.ticker .widget-content li {
float: left;
margin-left: 30px;
display: inline-block;
height: 38px;
line-height: 38px;
padding: 0
}
.ticker .widget {
height: 40px;
overflow: hidden;
background-color: #f7f7f7;
}
.tk-thumb {
float: left;
margin: 4px 14px 0 0
}
.tk-img {
position: relative;
display: block;
width: 35px;
height: 30px;
overflow: hidden
}
.ticker .post-tag {
display: inline-block;
background-color: $maincolor;
color: #fff;
margin-right: 10px;
font-weight: 400;
border-radius: 2px;
height: 18px;
line-height: 18px;
padding: 0 6px;
font-size: 10px;
text-transform: uppercase;
position: relative;
margin-top: 10px;
float: left
}
.ticker .tyard-title {
font-size: 14px;
font-weight: 400;
display: inline-block
}
.ticker .tyard-title a {
color: $darkcolor;
}
.ticker .tyard-title a:hover {
color: $maincolor;
}
.tickercontainer,
.tickercontainer .mask,
ul.newsticker {
-webkit-transition: all 0 linear;
-moz-transition: all 0 linear;
-o-transition: all 0 linear;
transition: all 0 linear;
list-style: none;
margin: 0
}
.tickercontainer {
margin: 0;
padding: 0;
overflow: hidden
}
.tickercontainer .mask {
position: relative;
overflow: hidden
}
.newsticker {
position: relative;
list-style-type: none;
margin: 0;
padding: 0
}
ul.newsticker {
-webkit-transition: all 0s linear;
-moz-transition: all 0s linear;
-o-transition: all 0s linear;
transition: all 0s linear;
position: relative;
list-style-type: none;
margin: 0;
padding: 0
}
.tickeroverlay-left {
display: none
}
.tickeroverlay-right {
display: none
}
/* ######## Slider Css ######################### */
.feat-slider-wrap {
    position: relative;
    margin: 15px auto 0;
}
.feat-slider-wrap h2.title {
display:none;
}
.ty-slide-show {
margin: 0 auto;
overflow: hidden;
}
.ty-slide-show ul {
padding:0;
list-style:none;
}
.ty-slide-show li {
list-style:none;
padding:0;
}
.ty-slide .ty-wow {
    overflow: hidden;
    border-bottom: 1px solid #F5F5F5;
    padding: 0;
position:relative;
}
.ty-slide .ty-wow:hover .ty-thumb-bonos img {
    transform: scale(1.1) rotate(-1deg);
    transition: all .3s ease-in-out;
}
.ty-slide .ty-thumb-bonos img {
    position: relative;
    float: left;
    margin: 0!important;
    width: 100%;
    height: 200px;
    overflow: hidden;
    display: block;
    vertical-align: middle;
object-fit:cover;
transition: all .3s ease-in-out;
}
.top-widget .ty-slide .ty-thumb-bonos img, .top-widget .ty-slide .ty-slide-con { 
height:350px;
}
.ty-slide .ty-slide-con {
       position: absolute;
    top: 0;
    text-align: center;
    display: table;
    width: 100%;
    height: 200px;
    z-index: 2;
    box-sizing: border-box;
    text-align: center;
    -webkit-transition: all 0.2s ease-in-out;
    -moz-transition: all 0.2s ease-in-out;
    -ms-transition: all 0.2s ease-in-out;
    -o-transition: all 0.2s ease-in-out;
    transition: all 0.2s ease-in-out;
}
.ty-slide .ty-slide-con-tab {
    display: table-cell;
    vertical-align: middle;
    padding: 10px;
    box-sizing: border-box;
}
.ty-slide .ty-slide-con-cell {
    position: relative;
    width: 80%;
    margin: 0 auto;
    padding: 20px 10px;
}
.ty-slide .ty-slide-con-tab .recent-summary {
    display: block;
    color: #dfdfdf;
    padding:5px 10px 10px;
line-height: 1.4;
font-size:13px;
line-height:1.5em;
}
.post-slider .ty-slide .ty-slide-con-tab .recent-summary {
    display: none;
}
.post-slider .ty-slide-con-tab .recent-date {
    display: block;
    margin-bottom: 10px;
}
.tyslide-more {
    background: $maincolor;
    padding: 5px 12px !important;
    display: inline-block;
    vertical-align: middle;
    margin: 0;
    font-size: 12px;
    text-transform: capitalize;
    border-radius: 2px;
    color: #f7f7f7;
    font-weight: 500;
    white-space: nowrap;
    font-family:inherit;
    position: absolute;
    bottom: -50px;
    left: 38%;
    -webkit-transition: .3s ease-out;
    transition: .3s ease-out;
}
.ty-slide .ty-wow:hover .tyslide-more {
bottom: 50px;
}
.ty-slide .ty-bonos-entry {
    overflow: hidden;
    line-height: 0;
    margin: 10px 0 10px;
    padding: 0 10px;
}
.ty-slide .ty-bonos-entry a {
    color: #fff;
    font-weight: 600;
letter-spacing:1px;
text-transform:capitalize;
    font-size: 18px;
    line-height: 1.5em;
-webkit-transition: all 0.2s ease-in-out;
-moz-transition: all 0.2s ease-in-out;
-ms-transition: all 0.2s ease-in-out;
-o-transition: all 0.2s ease-in-out;
transition: all 0.2s ease-in-out;
}
.ty-slide .ty-bonos-entry a:hover {
   
}
.yard-auth-ty {
   
}
.yard-auth-ty,
.ty-time {
    color: #bdbdbd;
    font-size: 12px;
    font-weight: 400;
}

.ty-wow .tyimg-lay {
    position: absolute;
    left: 0;
    right: 0;
    top: 0;
    bottom: 0;
    opacity: .5;
    content: '';
    transition: all .2s ease;
    background: #2c2f30;
}
.ty-slide:hover .tyimg-lay {
    opacity: .75;
}
.ty-slide-con-tab .recent-date {
    color: #fff;
}
.owl-carousel,.owl-carousel .owl-item{-webkit-tap-highlight-color:transparent;position:relative}.owl-carousel{display:none;width:100%;z-index:1}.owl-carousel .owl-stage{position:relative;-ms-touch-action:pan-Y;-moz-backface-visibility:hidden}.owl-carousel .owl-stage:after{content:".";display:block;clear:both;visibility:hidden;line-height:0;height:0}.owl-carousel .owl-stage-outer{position:relative;overflow:hidden;-webkit-transform:translate3d(0,0,0)}.owl-carousel .owl-item,.owl-carousel .owl-wrapper{-webkit-backface-visibility:hidden;-moz-backface-visibility:hidden;-ms-backface-visibility:hidden;-webkit-transform:translate3d(0,0,0);-moz-transform:translate3d(0,0,0);-ms-transform:translate3d(0,0,0)}.owl-carousel .owl-item{min-height:1px;float:left;-webkit-backface-visibility:hidden;-webkit-touch-callout:none}.owl-carousel .owl-item img{display:block;width:100%}.owl-carousel .owl-dots.disabled,.owl-carousel .owl-nav.disabled{display:none}.no-js .owl-carousel,.owl-carousel.owl-loaded{display:block}.owl-carousel .owl-dot,.owl-carousel .owl-nav .owl-next,.owl-carousel .owl-nav .owl-prev{cursor:pointer;cursor:hand;-webkit-user-select:none;-khtml-user-select:none;-moz-user-select:none;-ms-user-select:none;user-select:none}.owl-carousel.owl-loading{opacity:0;display:block}.owl-carousel.owl-hidden{opacity:0}.owl-carousel.owl-refresh .owl-item{visibility:hidden}.owl-carousel.owl-drag .owl-item{-webkit-user-select:none;-moz-user-select:none;-ms-user-select:none;user-select:none}.owl-carousel.owl-grab{cursor:move;cursor:grab}.owl-carousel.owl-rtl{direction:rtl}.owl-carousel.owl-rtl .owl-item{float:left}.owl-carousel .animated{animation-duration:1s;animation-fill-mode:both}.owl-carousel .owl-animated-in{z-index:0}.owl-carousel .owl-animated-out{z-index:1}.owl-carousel .fadeOut{animation-name:fadeOut}@keyframes fadeOut{0%{opacity:1}100%{opacity:0}}.owl-height{transition:height .5s ease-in-out}.owl-carousel .owl-item .owl-lazy{opacity:0;transition:opacity .4s ease}.owl-carousel .owl-item img.owl-lazy{transform-style:preserve-3d}.owl-carousel .owl-video-wrapper{position:relative;height:100%;background:#000}.owl-carousel .owl-video-play-icon{position:absolute;height:80px;width:80px;left:50%;top:50%;margin-left:-40px;margin-top:-40px;background:url(owl.video.play.png) no-repeat;cursor:pointer;z-index:1;-webkit-backface-visibility:hidden;transition:transform .1s ease}.owl-carousel .owl-video-play-icon:hover{-ms-transform:scale(1.3,1.3);transform:scale(1.3,1.3)}.owl-carousel .owl-video-playing .owl-video-play-icon,.owl-carousel .owl-video-playing .owl-video-tn{display:none}.owl-carousel .owl-video-tn{opacity:0;height:100%;background-position:center center;background-repeat:no-repeat;background-size:contain;transition:opacity .4s ease}.owl-carousel .owl-video-frame{position:relative;z-index:1;height:100%;width:100%}

.owl-theme .owl-dots,.owl-theme .owl-nav{text-align:center;-webkit-tap-highlight-color:transparent}.owl-theme .owl-nav{margin-top:10px}.owl-theme .owl-nav [class*=owl-]{color:#FFF;font-size:14px;margin:5px;padding:4px 7px;background:#D6D6D6;display:inline-block;cursor:pointer;border-radius:3px}.owl-theme .owl-nav [class*=owl-]:hover{background:#869791;color:#FFF;text-decoration:none}.owl-theme .owl-nav .disabled{opacity:.5;cursor:default}.owl-theme .owl-nav.disabled+.owl-dots{margin-top:10px}.owl-theme .owl-dots .owl-dot{display:inline-block;zoom:1}.owl-theme .owl-dots .owl-dot span{width:10px;height:10px;margin:5px 7px;background:#D6D6D6;display:block;-webkit-backface-visibility:visible;transition:opacity .2s ease;border-radius:30px}.owl-theme .owl-dots .owl-dot.active span,.owl-theme .owl-dots .owl-dot:hover span{background:#869791}
.owl-prev, .owl-next {
    top: 0;
    color: $maincolor;
    font-family: FontAwesome;
    position: absolute;
background:#F5f5f5;
    z-index: 1;
    display: block;
    cursor: pointer;
        padding: 10px;
    text-align: center;
    overflow: hidden;
transition: all .2s linear;
-moz-transition: all .2s linear;
-webkit-transition: all .2s linear;
-o-transition: all .2s linear;
}
.owl-prev:before {
    content: '\f0a5';
    font-family: fontawesome;
}
.owl-next:before {
    content: '\f0a4';
    font-family: fontawesome;
}
.owl-next {
    right: 0;
}
.owl-prev {
    left: 0;
}
.ty-slide:hover .owl-prev, .ty-slide:hover .owl-next {
background:$maincolor;
color:#fff;
}
/* ######## Sidebar Css ######################### */
.sidebar .widget {
margin-bottom: 20px;
position: relative;
}
.sidebar h2 {
position: relative;
    overflow: hidden;
    margin: 0;
    font-size: 18px;
    vertical-align: middle;
    padding: 10px;
    border-left: 4px solid $maincolor;
    font-weight: 700;
    background: $darkcolor;
    color: #fff;
}
.sidebar ul,.sidebar li{
list-style-type:none;
margin:0;
padding:0;
}
.sidebar .widget-content {
    padding: 10px 0;
}
/* Multi Tab Widget */
.menu-tab li a,
.sidetabs .section {
transition: all 0s ease;
-webkit-transition: all 0s ease;
-moz-transition: all 0s ease;
-o-transition: all 0s ease;
-ms-transition: all 0s ease
}
.menu-tab {
display: flex;
clear: both;
padding: 0;
margin: 0
}
.sidetabs .widget h2 {
display: none
}
.menu-tab li {
width: 33.3%;
float: left;
display: inline-block;
padding: 0;
position:relative;
}
.menu-tab li.active:after {
       content: "";
    border-top: 10px solid $maincolor;
    border-left: 10px solid transparent;
    border-right: 10px solid transparent;
    position: absolute;
    bottom: -8px;
    left: 14px;
}
.menu-tab li a {
    font-family: inherit;
height: 32px;
text-align: center;
padding: 0;
font-weight: 400;
display: block;
color: #fff;
background-color:$darkcolor;
font-size: 14px;
line-height: 32px;
letter-spacing: 1.5px;
text-transform: uppercase
}
.menu-tab li.active a {
color: #fff;
background-color:$maincolor;
}
.menu-tab li {
display: none
}
.hide-tab {
display: inline-block!important
}
#tabside3 {
    margin-bottom: 15px;
}
.sidetabs .widget-content {
    padding: 15px 0 0;
}
/* ######## Featured Widget Css ######################### */
.tyard-wrapper {
    margin: 0 0 10px;
}
.preload {
opacity:0;
}
.comload {
opacity:1;
}
.tyard .ty-first {
    width: 60%;
    position: relative;
    float: left;
    padding-right: 1.4%;
    box-sizing: border-box;
    overflow: hidden;
}
.tyard .ty-feat-image {
    width: 100%;
    position: relative;
    overflow: hidden;
}
.tyard .ty-first .tyard-thumb, .tyard .ty-img {
    height: 300px;
}
.templatesyard .ty-first .tyard-thumb {
    position: relative;
    width: 100%;
    height: 200px;
}
.tyard-thumb {
    overflow: hidden;
}
.tyard .ty-first .tyard-thumb, .tyard .ty-img {
    height: 300px !important;
}
.templatesyard .ty-img {
    width: 100%;
    height: 200px;
    position: relative;
    display: block;
}
.ty-first .ty-img:after {
    content: no-close-quote;
    position: absolute;
    left: 0;
    bottom: 0;
    width: 100%;
    height: 151px;
    background: url(http://3.bp.blogspot.com/-LnvazGBvKh8/VskckSkmzxI/AAAAAAAAC4s/erEgI6A_ih4/s1600-r/metabg.png) repeat-x;
    opacity: .8;
}
.templatesyard .ty-feat .ty-rest .yard-img:after {
    content: no-close-quote;
    position: absolute;
    left: 0;
    bottom: 0;
    width: 100%;
    height: 110px;
    background: url(http://3.bp.blogspot.com/-LnvazGBvKh8/VskckSkmzxI/AAAAAAAAC4s/erEgI6A_ih4/s1600-r/metabg.png) repeat-x;
    opacity: .8;
}
.ty-first .tyard-thumb .yard-label {
    position: absolute;
    top: 15px;
    left: 15px;
    z-index: 2;
}
.ty-first .tyard-thumb .yard-label a {
    background: $maincolor;
    color: #fff;
    text-transform: uppercase;
    height: 20px;
    line-height: 20px;
    display: inline-block;
    padding: 0 6px;
    font-size: 11px;
    font-weight: 400;
    border-radius: 2px;
}
.tyard .ty-first .ty-con-yard, .column .ty-first .ty-con-yard {
    position: absolute;
    bottom: 0;
    width: 100%;
    z-index: 2;
    padding: 15px;
    box-sizing: border-box;
}
.tyard .ty-first .ty-con-yard .tyard-title a, .column .ty-first .ty-con-yard .tyard-title a {
    display: block;
    font-size: 19px;
    color: #fff;
    font-weight: 400;
    line-height: 1.4em;
    margin-bottom: 5px;
}
.ty-con-yard .yard-auth-ty, .ty-con-yard .ty-time {
    color: #ccc;
}
.recent-summary {
    display: block;
    color: #ccc;
    padding: 10px 0;
}
.tyard .ty-feat .ty-rest {
   overflow: hidden;
    display: block;
     padding: 0;
    position: relative;
}
.tyard .ty-feat .ty-rest:last-child {
 padding-top: 10px;
    margin-top: 10px;
}
.templatesyard .ty-feat .ty-rest .tyard-thumb {
    width: 100%;
    height: 140px;
    vertical-align: middle;
}
.templatesyard .ty-feat .ty-rest .yard-img {
    width: 100%;
    height: 140px;
    position: relative;
    display: block;
}
.tyimg-lay {
    position: absolute;
    left: 0;
    top: 0;
    z-index: 1;
    width: 100%;
    height: 100%;
    background-color: rgba(40,35,40,0.05);
}
.templatesyard .ty-feat .ty-rest .yard-tent-ty {
   position: absolute;
    bottom: 0;
    width: 100%;
    z-index: 2;
    padding: 15px;
    box-sizing: border-box;
}
.tyard .ty-rest .yard-tent-ty .tyard-title {
    overflow: hidden;
    line-height: 0;
    margin: 0 0 2px;
    padding: 0;
}
.tyard .ty-rest .yard-tent-ty .tyard-title a {
    color: #fff;
    font-weight: 400;
    font-size: 13px;
    line-height: 1.5em;
}
/* ######## Post Css ######################### */
.breadcrumbs .fa-times:before {
    margin: 0 5px;
}
.breadcrumbs {
    margin: 0;
    font-size: 13px;
    padding: 0;
}
.breadcrumbs i {
    color: $maincolor;
    font-size: 8px !important;
float: left;
    line-height: 20px;
}
.breadcrumbs span a.bhome {
    color: $maincolor;
}
.breadcrumbs span,
.breadcrumbs span a {
    color: #000;
float: left;
}
.breadcrumbs span a:hover {
    color: $maincolor;
}
article {
    padding: 0;
overflow:hidden;
}
.post-outer {
    padding: 0 0 20px 0;
}
.post {
    display: block;
    overflow: hidden;
    word-wrap: break-word;
background: #ffffff;
}
 .item .post-head {
    position: relative;
    margin: 10px 0;
    border-bottom: 2px solid #eee;
    text-align: left;
    clear: both;
}
.post-head h1 {
    color: #000;
    font-size: 32px;
    font-weight: 400;
    line-height: 44px;
border-bottom: 2px solid #555;
display: inline-block;
    position: relative;
    top: 2px;
}
.post .retitle h2 {
   
}
.post .retitle h2 a {
color: #000;
font-size: 18px;
    line-height: 22px;
 font-weight:700;
}
.post .retitle h2 {
    padding: 0;
}


.retitle h2 {
    margin: 0 0 2px;
    display: block;
}
.post-body {
margin: 0px;
padding:10px;
font-size: 14px;
line-height: 26px;
box-sizing:border-box;
}
.post-home-image {
    float: left;
    width: 270px;
    height: 180px;
    margin-right: 20px;
position: relative;
}
.post-home-image .post-thumb {
    width: 100%;
    height: 180px;
    position: relative;
    display: block;
    overflow: hidden;
}
.post-home-image .post-thumb a {
    width: 100%;
    height: 180px;
    display: block;
    transition: all .3s ease-out!important;
    -webkit-transition: all .3s ease-out!important;
    -moz-transition: all .3s ease-out!important;
    -o-transition: all .3s ease-out!important;
}
.index .post-labels, .archive .post-labels {
position: absolute;
top: 10px;
left: 10px;
padding: 8px 12px 6px;
background: $maincolor;
color: #fff;
font-size: 12px;
text-transform: uppercase;
display: inline-block;
z-index: 9;
}
.index .post-labels a, .archive .post-labels a {
color: #fff;
}
.date-header {
    color: #bdbdbd;
    display: block;
    font-size: 12px;
    font-weight: 400;
    line-height: 1.3em;
    margin: 0!important;
    padding: 0;
}
.date-header a {
    color: #bdbdbd;
}
.date-header .read-more {
    background: $darkcolor;
    padding: 5px 12px !important;
    display: inline-block;
    vertical-align: middle;
    margin: 10px 0 0;
    font-size: 12px;
   text-transform: capitalize;
    border-radius: 2px;
    color: #f7f7f7;
    font-weight: bold;
white-space: nowrap;
font-family:inherit;
}
.read-more:hover {
    background: $maincolor;
color:#fff;
}
.post-header {
    padding: 10px;
margin-bottom: 10px;
}
#meta-post {
    border-top: 1px solid #f5f5f5;
    border-bottom: 1px solid #f5f5f5;
    padding: 5px 0;
}

.post-meta {
    color: #bdbdbd;
    display: block;
    font-size: 13px;
    font-weight: 400;
    line-height: 21px;
    margin: 0;
    padding: 0;
}
.post-meta a, .post-meta i {
    color: #CBCBCB;
}
.post-timestamp {
    margin-right: 5px;
}
.resumo {
    margin-top: 5px;
    color: #919191;
}
.resumo span {
    display: block;
   font-size: 13px;
    line-height: 1.5em;
text-align:justify;
}
.post-body img {
max-width: 100%;
padding: 10px 0;
position: relative;
margin:0 auto;
}
.post h3 {
font-size: 18px;
margin-top: 20px;
margin-bottom: 10px;
line-height: 1.1;
}
.second-meta {
    display: none;
}
.comment-link {
    white-space: normal;
}
#blog-pager {
clear: both;
text-align: center;
padding: 15px 0;
background: #ffffff;
color: #4d4d4d;
}
.displaypageNum a,
.showpage a,
.pagecurrent, .blog-pager-older-link, .blog-pager-newer-link {
padding: 5px 13px;
margin-right: 8px;
color: #fff;
background-color: $darkcolor;
border: 1px solid #2d2d2d;
display: inline-block;
line-height: 20px;
-moz-border-radius: 2px;
-webkit-border-radius: 2px;
border-radius: 2px;
margin-top: 10px;
}
.displaypageNum a i, .showpage a i {
    font-size: 11px;
}
.displaypageNum a:hover,
.showpage a:hover,
.pagecurrent, .blog-pager-older-link:hover, .blog-pager-newer-link:hover {
background: $maincolor;
text-decoration: none;
color: #fff;
}
.showpageOf {
display: none!important;
overflow: hidden;
}
#blog-pager .pages {
margin: 10px 0;
border: none;
}

.item .post-footer .label-head .label-title {
color: #fff;
    padding: 3px 8px;
    font-size: 13px;
margin-left: 2px;
background-color: $maincolor;
}
.item .post-footer .label-head a {
color: #fff;
margin-left: 2px;
    padding: 3px 8px;
    font-size: 13px;
background-color: $darkcolor;
}
.ty-post-share {
   margin: 10px 0 0;
    font-size: 12px;
    padding: 0;
}
.ty-post-share ul {
padding: 0;
    overflow: hidden;
    list-style: none;
}
.ty-post-share li {
    display: block;
    float: left;
    width: 25%;
    text-align: center;
}
.ty-post-share li.ty-twitter a {
    background: #4b96d7;
}
.ty-post-share li.ty-facebook a {
    background: #2a3e8c;
}
.ty-post-share li.ty-pinterest a {
    background: #ae0000;
}
.ty-post-share a {
    display: block;
    width: 100%;
    font-size: 12px;
    padding: 1em;
    color: #fff;
    background: #000;
    font-weight: bold;
    text-transform: uppercase;
    letter-spacing: 1px;
}
.ty-post-share a .fa {
    font-size: 18px;
    margin-left: 15px;
}
.share2 {font-size: 13px; color:$(maincolor); border: 1px solid; padding:4px; float: left; margin-left: 5px; padding-right: 7px; padding-left: 7px;font-weight: 800; letter-spacing: 0.6px;margin-top: 10px;}
.addthis_sharing_toolbox {clear:initial!important;margin-top: 10px;}
.post-share-link{border:1px solid #eee;border-radius:2px;display:block;box-sizing:border-box;font-size:16px;margin-top:10px;ms-border-radius:2px;o-border-radius:2px;outline:0;padding:10px;webkit-border-radius:2px;width:100%}
.ty-author-box {
border: 1px solid #f2f2f2;
background: #f8f8f8;
overflow: hidden;
padding: 10px;
margin: 10px 0;
}
.ty-author-box img {
float: left;
margin-right: 10px;
object-fit: cover;
}
.ty-author-box p {
padding: 0;
-webkit-margin-before: 0;
    -webkit-margin-after: 0;
}
.ty-author-box b {
    font-family: inherit;
font-weight: 700;
font-style: normal;
letter-spacing: 1px;
font-size: 20px;
}
.ty-author-box ul {
    overflow: hidden;
    padding: 0;
    margin: 6px;
}
.ty-author-box ul li:first-child {
    margin-left: 0;
}
.ty-author-box ul li {
  float: left;
    margin-left: 7px;
    text-align: center;
    font-size: .875rem;
    border-radius: 3px;
    list-style-type: none;
    padding: 0;
}
.ty-author-box ul li a {
    display: block;
        padding: 8px 10px;
 background: #eee;
}
.ty-author-box ul li a:hover {
background:$maincolor;
color:#fff;
}
#related-posts {
margin-bottom: 10px;
}
#related-posts .related-text {
display: none;
}
.related li{width:32%;position:relative;overflow:hidden;float:left;display:block;box-sizing:border-box;margin:0 0 0 2%;padding:0}
.related li:first-child,.related li:nth-child(4){margin-left:0}
.related li h3 {
margin-top:0;
}
.related-thumb {
width: 100%;
height: 120px;
overflow: hidden;
border-radius: 2px;
}
.related li .related-img {
width: 100%;
height: 120px;
display: block;
transition: all .3s ease-out!important;
-webkit-transition: all .3s ease-out!important;
-moz-transition: all .3s ease-out!important;
-o-transition: all .3s ease-out!important;
}
.related li .related-img:hover {
-webkit-transform: scale(1.1) rotate(-1.5deg)!important;
-moz-transform: scale(1.1) rotate(-1.5deg)!important;
transform: scale(1.1) rotate(-1.5deg)!important;
transition: all .3s ease-out!important;
-webkit-transition: all .3s ease-out!important;
-moz-transition: all .3s ease-out!important;
-o-transition: all .3s ease-out!important;
}
.related-title a {
font-size: 15px;
line-height: 1.35em;
padding: 10px 5px 10px 0;
font-weight: 400;
color: #010101;
display: block;
}
.related-title a:hover {
color: #777;
text-decoration: underline;
}
/* ######## Comment Form Widget ######################### */
.comment-form {
overflow:hidden;
}
iframe.blogger-iframe-colorize,
iframe.blogger-comment-from-post {
height: 283px!important
}
.comments-title {
position: relative;
clear: both;
z-index: 1;
margin: 0;
line-height: 33px
}
.comments-title h2 {
display: inline-block;
position: relative;
background-color: #fff;
color: #1c1c1c;
font-size: 18px;
letter-spacing: -.4px;
text-transform: uppercase;
font-weight: 700;
z-index: 1;
margin: 0;
padding-right: 15px
}
.comments-title:after {
content: "";
position: absolute;
z-index: 0;
top: 14px;
left: 0;
width: 100%;
height: 5px;
background-color: #F5F5F5
}
.comments {
clear: both;
margin: 0;
color: #1c1c1c;
background: #ffffff;
padding: 10px 0;
}
.comments h4 {
color: #000;
    font-size: 14px;
    padding: 5px 20px;
    font-weight: 700;
    letter-spacing: 1.5px;
    text-transform: Uppercase;
    position: relative;
    text-align: center;
    background: #ffffff;
    z-index: 1;
margin-bottom: 15px;

}
.comments h4:after {
    content: '';
    position: absolute;
    bottom: 0;
    left: 50%;
    width: 40px;
    height: 2px;
    background: #000;
    margin-left: -20px;
}
.comments .comments-content {
margin: 0;
padding: 0
}
.comments .comments-content .comment {
margin-bottom: 0;
padding-bottom: 8px
}
.comments .comments-content .comment:first-child {
padding-top: 0
}
.facebook-tab,
.fb_iframe_widget_fluid span,
.fb_iframe_widget iframe {
width: 100%!important
}
.comments .item-control {
position: static
}
.comments .avatar-image-container {
float: left;
overflow: hidden;
position: absolute
}
.comments .avatar-image-container,
.comments .avatar-image-container img {
height: 45px;
max-height: 45px;
width: 45px;
max-width: 45px;
border-radius: 0
}
.comments .comment-block {
overflow: hidden;
padding: 0 0 10px
}
.comments .comment-block,
.comments .comments-content .comment-replies {
margin-left: 60px;
margin-top: 0
}
.comments .comments-content .inline-thread {
padding: 0
}
.comments .comment-actions {
float: left;
width: 100%;
position: relative;
margin: 0
}
.comments .comments-content .comment-header {
font-size: 14px;
display: block;
overflow: hidden;
clear: both;
margin: 0 0 3px;
padding: 0 0 5px;
border-bottom: 1px dotted #f5f5f5
}
.comments .comments-content .user {
font-style: normal;
font-weight: 500;
display: block;
font-size: 16px
}
.comments .comments-content .icon.blog-author {
display: none
}
.comments .comments-content .comment-content {
float: left;
text-align: left;
font-size: 13px;
line-height: 1.4em;
color: #656565
}
.comments .comment .comment-actions a {
margin-right: 5px;
padding: 2px 5px;
color: #fff;
font-weight: 400;
background-color: #000;
font-size: 10px
}
.comments .comment .comment-actions a:hover {
color: #fff;
background-color: $maincolor;
text-decoration: none
}
.comments .comments-content .datetime {
color: #999;
float: left;
font-size: 11px;
position: relative;
font-style: italic;
margin: 2px 0 0;
display: block
}
.comments .comments-content .datetime:before {
content: '\f017';
font-family: fontawesome;
font-style: normal;
margin-right: 3px
}
.comments .comments-content .comment-header a {
color: inherit
}
.comments .comments-content .comment-header a:hover {
color:$maincolor
}
.comments .thread-toggle {
margin-bottom: 4px
}
.comments .thread-toggle .thread-arrow {
height: 7px;
margin: 0 3px 2px 0
}
.comments .thread-expanded {
padding: 8px 0 0
}
.comments .comments-content .comment-thread {
margin: 0
}
.comments .continue a {
padding: 0 0 0 60px;
font-weight: 400
}
.comments .comments-content .loadmore.loaded {
margin: 0;
padding: 0
}
.comments .comment-replybox-thread {
margin: 0
}
.blogger-tab{
display:block;
}
.cmm-tabs .content-tab {
background-color: transparent;
padding: 0;
}
.cmm-tabs-header {
margin-bottom: 10px;
border-bottom: 2px solid #eee;
position: relative;
}
.cmm-tabs-header h3 {
display: inline-block;
font-size: 18px;
margin: 0;
border-bottom: 2px solid #777;
color: #010101;
top: 2px;
font-weight: 500;
padding-bottom: 2px;
}
.cmm-tabs-header h3 h9 {
display: none;
}
.simplyTab .cmm-tabs-header .wrap-tab {

}
.cmm-tabs-header .wrap-tab a {
    height: auto;
    line-height: 1.2em;
    padding: 8px 5px;
    display: block;
    text-align: center;
}
.cmm-tabs-header .wrap-tab li {
float: left;
    width: 33%;
    padding: 0;
}
.facebook-tab,
.fb_iframe_widget_fluid span,
.fb_iframe_widget iframe {
width: 100%!important;
}
.cmm-tabs.simplyTab .content-tab {
background-color: transparent;
padding: 0;
margin-top: 20px;
}
.cmm-tabs.simplyTab .wrap-tab li a {
text-transform: uppercase;
color: #FFF;
font-weight: 500;
background-color: $darkcolor;
font-size: 12px;
}
.cmm-tabs.simplyTab .wrap-tab li a.activeTab {
background-color: $maincolor;
color:#fff;
}
.cmm-tabs.simplyTab .wrap-tab {

}
.cmm-tabs.simplyTab .wrap-tab li {
margin:0;
list-style: none;
}
.wrap-tab {
list-style: none;
}
.content-tab {
transition: all .0s ease;
-webkit-transition: all .0s ease;
-moz-transition: all .0s ease;
-o-transition: all .0s ease;
}
/* ######## Contact Popup ######################### */
#backgroundPopup {
z-index: 99;
position: fixed;
display: none;
height: 100%;
width: 100%;
background: $darkcolor;
top: 0px;
left: 0px;
}
#toPopup {
background: none repeat scroll 0 0 #FFF;
color: #333;
display: none;
left: 50%;
margin-left: -100px;
position: fixed;
top: 20%;
z-index: 9999;
}
div.loader {
background: url(http://1.bp.blogspot.com/-Mw8NDNJMTPs/Udeg0m7ASiI/AAAAAAAACqA/Jn9oUtdJWD8/s1600/loading.gif) no-repeat scroll 0 0 transparent;
height: 32px;
width: 32px;
display: none;
z-index: 9999;
top: 40%;
left: 50%;
position: absolute;
margin-left: -10px;
}
div.close {
    background: url(http://2.bp.blogspot.com/-LKgSryP94kU/Udeg0v9677I/AAAAAAAACp8/dgERlo3ULFU/s1600/closebox.png) no-repeat scroll 0 0 transparent;
    bottom: 20px;
    cursor: pointer;
    float: right;
    height: 30px;
    left: 20px;
    position: relative;
    width: 30px;
    z-index: 1;
}

.contact-form-name, .contact-form-email, .contact-form-email-message {
    background-color: #f3f3f3;
    border: 0;
    color: #111;
    margin-bottom: 5px;
    padding: 5px;
}
#popup_content h2 {
    text-align: center;
    padding: 0 0 0 15px;
    background-color: $maincolor;
color:#fff;
}
/*****************************************
Footer Bottom CSS
******************************************/
.bot-bar-menu {
    background-color: #222;
    padding: 5px 0;
overflow: hidden;
border-bottom: 3px solid $maincolor;
}
.bot-menu-wrap {
    margin: 0 auto;
}
.bot-menu {
    float: left;
}
.bot-menu ul {
overflow: hidden;
list-style: none;
padding: 0;
margin: 0;
}
.bot-menu ul li {
float: left;
display: inline-block;
list-style: none;
padding: 0;
}
.bot-menu ul li a {
padding: 10px 16px;
display: block;
border: none !important;
text-decoration: none;
line-height: inherit;
font-size: 14px;
font-weight: normal;
color: #eeeeee;
text-transform: uppercase;
font-family:inherit;
}
.bot-menu ul li a:hover {
color:$maincolor;
}
.bot-menu h2 {
display:none;
}
#lower {
margin:auto;
padding: 0px 0px 10px 0px;
width: 100%;
background:$darkcolor;
border-bottom: 1px solid #222222;
}
#lower-wrapper {
margin:auto;
padding: 20px 0px 20px 0px;
}
#lowerbar-wrapper {
float: left;
margin: 0px 5px auto;
padding-bottom: 20px;
width: 32%;
text-align: justify;
color:#ddd;
line-height: 1.6em;
word-wrap: break-word;
overflow: hidden;
max-width: 375px;
}
.lowerbar {margin: 0; padding: 0;}
.lowerbar .widget {margin: 0; padding: 10px 20px 0px 20px;box-sizing:border-box;}
.lowerbar h2 {
    position: relative;
    overflow: hidden;
    margin: 0;
    font-size: 18px;
    vertical-align: middle;
    padding: 0 0 10px 0;
    border-bottom:1px solid rgba(0, 200, 215, 0.18);
    font-weight: 700;
color:#fff;
    clear: both;
}
.lowerbar h2:after {
content: '';
    display: inline-block;
    position: absolute;
    height: 15px;
    top: 0;
    margin: 3px 0px 12px 10px;
    width: 100%;
    background: url(http://4.bp.blogspot.com/-R2WTW6O9E1o/VX7dqIGT1eI/AAAAAAAACc4/pyvQDMMLX3E/s1600/repeat-bg.png)repeat;
}
.lowerbar ul {
margin: 0 auto;
padding: 0;
list-style-type: none;
}
.lowerbar li {
display:block;
line-height: 1.6em;
margin-left: 0 !important;
list-style-type: none;
}
.lowerbar li a {
text-decoration:none; color: #DBDBDB;
}
.lowerbar li a:hover {
text-decoration:none;
}
.lowerbar li:hover {
display:block;
}
.lowerbar .PopularPosts ul li a, .lowerbar, .lowerbar .ty-bonus .ty-bonos-entry a, .lowerbar .tyard-komet a  {
color:#fff;
}
.lowerbar .PopularPosts .widget-content ul li {
border-bottom: 1px solid rgb(51, 51, 51);
border-top: 0;
}
.lowerbar .ty-bonus .ty-wow {
border-bottom: 1px solid rgb(51, 51, 51);
border-top: 0;
}
.lowerbar .PopularPosts .widget-content ul li:last-child {
border: 0;
}
.lowerbar .widget-content {
    padding: 10px 0;
}
/* ######## Footer Copyright Css ######################### */
#ty_footer {
    background: #2d2d2d;
    color: #fff;
    font-weight: 300;
    padding: 15px 0px;
}
.ty-copy-container {
    margin: 0 auto;
    overflow: hidden;
}
.ty_footer_copyright a {
    color:#fff;
}
.ty_footer_copyright {
text-align: left;
    display: inline-block;
    line-height: 30px;
}
.bottom-bar-social {
float: right;
padding: 0 0;
}
.bottom-bar-social li {
display: inline;
padding: 0;
float: left;
margin-right: 5px;
;
}
.bottom-bar-social .widget ul {
padding: 0;
}
.bottom-bar-social .LinkList ul {
text-align: center;
}
.bottom-bar-social #social a {
display: block;
width: 30px;
height: 30px;
line-height: 30px;
font-size: 15px;
color: #fff;
}
.bottom-bar-social #social a:before {
display: inline-block;
font: normal normal normal 22px/1 FontAwesome;
font-size: inherit;
font-style: normal;
font-weight: 400;
-webkit-font-smoothing: antialiased;
-moz-osx-font-smoothing: grayscale;
}
.bottom-bar-social .bloglovin:before{content:"\f004"}
.bottom-bar-social .facebook:before{content:"\f09a"}
.bottom-bar-social .twitter:before{content:"\f099"}
.bottom-bar-social .gplus:before{content:"\f0d5"}
.bottom-bar-social .rss:before{content:"\f09e"}
.bottom-bar-social .youtube:before{content:"\f167"}
.bottom-bar-social .skype:before{content:"\f17e"}
.bottom-bar-social .stumbleupon:before{content:"\f1a4"}
.bottom-bar-social .tumblr:before{content:"\f173"}
.bottom-bar-social .vine:before{content:"\f1ca"}
.bottom-bar-social .stack-overflow:before{content:"\f16c"}
.bottom-bar-social .linkedin:before{content:"\f0e1"}
.bottom-bar-social .dribbble:before{content:"\f17d"}
.bottom-bar-social .soundcloud:before{content:"\f1be"}
.bottom-bar-social .behance:before{content:"\f1b4"}
.bottom-bar-social .digg:before{content:"\f1a6"}
.bottom-bar-social .instagram:before{content:"\f16d"}
.bottom-bar-social .pinterest:before{content:"\f0d2"}
.bottom-bar-social .delicious:before{content:"\f1a5"}
.bottom-bar-social .codepen:before{content:"\f1cb"}
.bottom-bar-social ul#social a:hover {
color: $maincolor;
opacity: 1;
}
.go-to-top-parent {
       float: right;
}
.back-to-top, .topopup {
    color: #fff;
    border: 2px solid $maincolor;
    display: inline-block;
    border-radius: 100%;
    width: 32px;
    height: 32px;
    line-height: 32px;
    text-align: center;
}
.topopup {
    margin-right: 5px;
}
.back-to-top:hover, .topopup:hover {
background:$maincolor;
border-color:#fff;
}
/* ######## Custom Widget Css ######################### */
select#BlogArchive1_ArchiveMenu {
width: 100%;
padding: 10px;
border-color: #777;
}
#adwidegt1 .widget, #adwidegt2 .widget, #adwidegt3 .widget {
    width: 728px;
    max-height: 90px;
    padding: 0;
    max-width: 100%;
    box-sizing: border-box;
display:none;
}
#adwidegt1 .widget {
    margin: 15px auto 10px !important;
display:block !important;
}
#adwidegt2 .widget {
    margin: 15px auto 0 !important;
}
#adwidegt1 .widget h2, #adwidegt2 .widget h2, #adwidegt3 .widget h2 {
display:none;
visibility:hidden;
}
.ads-posting {
    margin: 10px 0 0;
}
.post-footer .ads-posting {
    margin: 15px 0 0;
}
.contact-form-name, .contact-form-email, .contact-form-email-message, .contact-form-widget {
max-width: none;
}
.contact-form-name, .contact-form-email, .contact-form-email-message {
background-color: #EBEBEB;
border: 1px solid #ccc;
}
.contact-form-widget .form {
    color: #666;
    font-size: 12px;
    font-weight: 400;
    margin-top: 20px;
    max-width: none;
    padding: 0 20px 20px;
    box-sizing: border-box;
}
.contact-form-button-submit {
max-width: none;
width: 100%;
height: 35px;
border:0;
background-image: none;
background-color: $maincolor !important;
cursor: pointer;
font-style: normal;
font-weight: 400;
}
.contact-form-name:focus, .contact-form-email:focus, .contact-form-email-message:focus {

}
.contact-form-name:hover, .contact-form-email:hover, .contact-form-email-message:hover {

}
.contact-form-button-submit:hover {
background-color: #303030;
background-image: none;
border: 0;
}
.sidebar .FollowByEmail > h3.title,
.sidebar .FollowByEmail .title-wrap {
margin-bottom: 0
}
#FollowByEmail1 {
    clear: both;
}
.FollowByEmail td {
width: 100%;
float: left;
box-sizing: border-box
}
.FollowByEmail .follow-by-email-inner .follow-by-email-submit {
margin-left: 0;
width: 100%;
border-radius: 0;
height: 30px;
font-size: 11px;
color: #fff;
background-color: $maincolor;
font-family: inherit;
text-transform: uppercase;
font-weight: 700;
letter-spacing: 1px
}
.FollowByEmail .follow-by-email-inner .follow-by-email-submit:hover {
background-color: #000
}
.FollowByEmail .follow-by-email-inner .follow-by-email-address {
padding-left: 10px;
height: 30px;
border: 1px solid #FFF;
margin-bottom: 5px;
box-sizing: border-box;
font-size: 11px;
font-family: inherit
}
.FollowByEmail .follow-by-email-inner .follow-by-email-address:focus {
border: 1px solid #FFF
}
.FollowByEmail .widget-content {
background-color: #2b2b2b;
box-sizing: border-box;
padding: 10px
}
.lowerbar .FollowByEmail .widget-content {
    margin-top: 10px;
}
.FollowByEmail .widget-content:before {
content: "Enter your email address to subscribe to this blog and receive notifications of new posts by email.";
font-size: 14px;
color: #f2f2f2;
line-height: 1.4em;
margin-bottom: 5px;
display: block;
padding: 0 2px
}
.ty-bonus .ty-wow {
    overflow: hidden;
    border-bottom: 1px solid #F5F5F5;
    padding: 10px 0;
}
.ty-bonus .ty-wow:first-child {
    padding-top: 0;
}
.ty-bonus .ty-wow:last-child {
    border-bottom: none;
}
.ty-bonus .ty-thumb-bonos {
    position: relative;
    float: left;
    margin: 0!important;
    width: 80px;
    height: 60px;
    overflow: hidden;
    display: block;
    vertical-align: middle;
}
.ty-bonus .ty-bonus-con {
    padding-left: 10px;
    display: table-cell;
}
.ty-bonus .ty-bonos-entry {
    overflow: hidden;
    line-height: 0;
    margin: 0 0 2px;
    padding: 0;
}
.ty-bonus .ty-bonos-entry a {
    color: $darkcolor;
    font-weight: 400;
    font-size: 13px;
    line-height: 1.5em;
}
.ty-bonus .ty-bonos-entry a:hover {
    color: $maincolor;
}
.ty-bonus .ty-thumb-bonos:hover .tyimg-lay {
    background-color: rgba(40, 35, 40, 0.3);
}
.yard-auth-ty {
    margin-right: 10px;
}
.yard-auth-ty::before {
    content: '\f007';
    font-family: fontawesome;
    color: #bbb;
    margin-right: 5px;
}
.yard-auth-ty,
.ty-time {
    color: #bdbdbd;
    font-size: 12px;
    font-weight: 400;
}
.ty-time:before {
    content: '\f133';
    font-family: fontawesome;
    color: #bbb;
    margin-right: 5px;
}
.sidebar .PopularPosts .widget-content ul li:first-child,
.sidebar .ty-bonus .ty-wow:first-child {
    padding-top: 0;
    border-top: 0;
}
.sidebar .PopularPosts .widget-content ul li:last-child,
.sidebar .ty-bonus .ty-wow:last-child {
    padding-bottom: 0;
}
.tyard-komet .ty-komet .ty-komet-tar {
    position: relative;
    overflow: hidden;
    padding: 0;
    width: 55px;
    height: 55px;
    float: left;
    margin: 0 0 0 10px;
}
.tyard-komet .ty-komet {
    background: none!important;
    clear: both;
    list-style: none;
    word-break: break-all;
    display: block;
    border-top: 1px solid #F5F5F5;
    border-bottom: 0 !important;
    overflow: hidden;
    margin: 0;
    padding: 10px 0;
}
.tyard-komet .ty-komet:first-child {
    padding-top: 0;
    border-top: 0;
}
.tyard-komet .ty-komet:last-child {
    padding-bottom: 0;
}
.tyard-komet .ty-komet span {
  color: #bdbdbd;
    display: block;
    line-height: 1.2em;
    text-transform: lowercase;
    font-size: 12px;
    font-style: italic;
    font-weight: 400;
    overflow: hidden;
    background: #f9f9f9;
    height: 38px;
    margin-top: 5px;
    box-sizing: border-box;
    padding: 5px 8px;
}
.yardimg-komet {
    width: 55px;
    height: 55px;
    float: left;
    margin: 0 0 0 10px;
}
.tyard-komet a {
    color: $darkcolor;
    position: relative;
    font-size: 13px;
    text-transform: capitalize;
    display: block;
    overflow: hidden;
    font-weight: 400;
}
.tyard-komet a:hover {
    color:$maincolor;
}
.tyard-komet {
    list-style: none;
    padding: 0;
}
.cloud-label-widget-content {
display: inline-block;
text-align: left;
}
.cloud-label-widget-content .label-size {
display: inline-block;
float: left;
font-size: 12px;
line-height: normal;
margin: 0 5px 5px 0;
opacity: 1
}
.cloud-label-widget-content .label-size a {
background: #efefef;
color: #000;
float: left;
font-weight: 400;
line-height: 100%;
margin: 0;
padding: 8px 10px;
text-transform: uppercase;
transition: all .6s;
letter-spacing: 1.5px;
font-family:inherit;
}
.cloud-label-widget-content .label-size a:hover,
.cloud-label-widget-content .label-size a:active {
background:$maincolor;
color: #fff;
}
.cloud-label-widget-content .label-size .label-count {
display:none;
}
.list-label-widget-content li {
display: block;
padding: 8px 0;
border-bottom: 1px solid #ececec;
position: relative
}
.list-label-widget-content li a:before {
content: '\203a';
position: absolute;
left: 0px;
top:5px;
font-size: 22px;
color: #10b765
}
.lowerbar .list-label-widget-content li a {
color:#fff;
}
.lowerbar .list-label-widget-content li {
border-bottom: 1px solid rgb(51, 51, 51);
border-top: 0;
}
.lowerbar .list-label-widget-content li:last-child {
border: 0;
}
.list-label-widget-content li a {
color: #282828;
font-size: 14px;
padding-left: 20px;
font-weight: 400;
text-transform: capitalize;
font-family:inherit;
letter-spacing: 1.5px;
}
.list-label-widget-content li span:last-child {
color: #f6b2ca;
font-size: 12px;
font-weight: 700;
position: absolute;
top: 9px;
left: 0
}
.PopularPosts .item-thumbnail {
margin: 0 15px 0 0 !important;
width: 80px;
height: 60px;
float: left;
overflow: hidden;
position: relative
}
.PopularPosts .item-thumbnail a {
position: relative;
display: block;
overflow: hidden;
line-height: 0
}
.PopularPosts ul li img {
width: 90px;
height: 65px;
object-fit: cover;
padding: 0;
transition: all .3s ease
}
.PopularPosts .widget-content ul li {
overflow: hidden;
padding: 10px 0;
border-top: 1px solid #f2f2f2
}
.sidebar .PopularPosts .widget-content ul li:first-child,
#sidetabs .PopularPosts .widget-content ul li:first-child {
padding-top: 0;
border-top: 0
}
.sidebar .PopularPosts .widget-content ul li:last-child,
.sidebar .ty-bonus .ty-wow:last-child,
.tab-widget .PopularPosts .widget-content ul li:last-child,
.tab-widget .ty-bonus .ty-wow:last-child {
padding-bottom: 0
}
.PopularPosts ul li a {
color: $darkcolor;
font-weight: 400;
font-size: 13px;
line-height: 1.4em;
transition: color .3s;
font-family: inherit;
letter-spacing:1.5px;
}
.PopularPosts ul li a:hover {
color: #a0d3db
}
.PopularPosts .item-title {
margin: 0 0 4px;
padding: 0;
line-height: 0
}
.item-snippet {
display: none;
font-size: 0;
padding-top: 0
}
.PopularPosts ul {
counter-reset: popularcount;
margin: 0;
padding: 0;
}
.PopularPosts .item-thumbnail::before {
background: rgba(0, 0, 0, 0.3);
bottom: 0px;
content: "";
height: 100px;
width: 100px;
left: 0px;
right: 0px;
margin: 0px auto;
position: absolute;
z-index: 3;
}
/* ######## Responsive Css ######################### */
@media only screen and (max-width: 1200px) {
.body-row {
width: 96% !important;
margin: 0 auto;
float: none;
}
.headerright, .headerleft {
    float: none;
    width: 100%;
    text-align: center;
    height: auto;
    margin: 0 auto;
    clear: both;
}
.headerleft img {
    margin: auto;
    padding-bottom: 15px;
}
.headerright {
    margin: 10px auto 0;
}
}
@media only screen and (max-width: 980px) {
#featured ul li {
width: 100%;
float: none;
margin: 0 auto 20px;
clear: both;
}
#main-wrapper, #sidebar-wrapper, #lowerbar-wrapper {
float: none;
clear: both;
width: 100%;
margin: 0 auto;
}
#main-wrapper {
max-width: 100%;
}
#sidebar-wrapper {
padding-top: 20px;
}
#nav1, #nav {
display: none;
}
.selectnav {
width: auto;
color: #222;
background: #f4f4f4;
border: 1px solid rgba(255,255,255,0.1);
position: relative;
border: 0;
padding: 6px 10px!important;
margin: 5px 0;
}
.selectnav {
display: block;
width: 100%;
max-width:200px;
}
.tm-menu .selectnav {
display:inline-block;
    margin: 10px 0 0 0;
}
#menu {
text-align:left;
}
}
@media screen and (max-width: 880px) {

.item #content-wrapper {
padding: 0 0 30px;
}
}
@media only screen and (max-width: 768px) {
.top-bar-social, .bottom-bar-social {
    float: none;
    width: 100%;
    clear: both;
    overflow: hidden;
}
.top-bar-menu {
    float: none;
    width: 100%;
    clear: both;
    margin-top: 0;
    margin-bottom: 10px;
text-align: center;
}
.top-bar-social li, .bottom-bar-social li {
    display: inline-block;
    float: none;
}
.selectnav {
    display: inline-block;
}
#search-bar {
    display: none;
}
.ops-404 {
width: 80%!important;
}
.title-404 {
font-size: 160px!important;
}
.tyard .ty-first {
    width: 100%;
    float: none;
    padding-right: 0;
margin-bottom: 10px;
}
.templatesyard .ty-feat .ty-rest .tyard-thumb, .templatesyard .ty-feat .ty-rest .yard-img {
height: 300px;
}
.post-home-image {
    float: none;
    width: 100%;
    margin-bottom: 20px;
    position: relative;
}
.post-home-image .post-thumb a, .post-home-image .post-thumb, .post-home-image {
height:250px;
}
#meta-post {
text-align: center;
}
.index .post, .archive .post {
text-align:center;
}
.ty_footer_copyright {
    text-align: center;
    display: block;
    clear: both;
}
}
@media only screen and (max-width: 767px) {
.topopup {
    display: none;
}
#contact-pop-up {
    display: none;
}
}
@media only screen and (max-width: 620px) {
.ty-post-share li {
    width: 50%;
}
.related li {
    width: 100%;
    margin-left: 0;
}
}
@media only screen and (max-width: 480px) {
.ticker .title, .tk-thumb, .ticker .post-tag {
    display: none;
}
.index .post h2,.archive .post h2 {
line-height: 34px;
font-size: 23px;
}
h1.post-title {
font-size: 22px;
margin-bottom: 10px;
}
#meta-post {
display: inline-block;
}
#meta-post .post-labels {
display: block;
margin: 0 0 10px;
clear: both;
}
.other-meta .other-meta-desc, .other-meta .other-meta-read {
float: none;
display: block;
text-align: center;
}
.share-title {
display: none;
}
.social-btns {
float: none;
text-align: center;
}
#sidebar-wrapper {
max-width: 100%;
}
.index .post-outer {
padding: 0 0 10px 0;
}
.ty-copy-container {
text-align: center;
}
.temp-cred {
float: none;
display: block;
clear: both;
margin: 5px 0 0;
}
.ty_footer_copyright {
float: none;
display: block;
clear: both;
}
}
@media only screen and (max-width: 360px) {
.title-404 {
font-size: 150px!important;
}
.Header .description p, .showpageOf{display:none}
}
@media only screen and (max-width: 300px) {
#sidebar-wrapper {display:none}
.related-thumb {
width: 100%;
float: none;
}
.archive .post h2,.index .post h2 {
line-height: 29px!important;
font-size: 15px!important;
}
article {
overflow: hidden;
}
#blog-pager {
padding: 0;
margin: 0;
}
.item #blog-pager {
    margin: 0 0 15px;
}
.index .resumo span,.archive .resumo span,.ty-author-box img, .breadcrumbs {
display: none;
}
.ty-author-box ul li a {
    padding: 0;
    background: none;
}
.ops-404 {
font-size: 20px!important;
}
.title-404 {
font-size: 120px!important;
}
h1.post-title {
font-size: 17px;
}
.top-bar-social #social a {
width: 24px;
height: 24px;
line-height: 24px;
}
.top-bar-menu, .ty-ran-yard {
display:none;
}
.ty-post-share li {
    width: 100%;
}
.comments .comments-content .comment-header {
width: 100%;
float: none;
clear: both;
margin: 0;
padding: 0;
}
.comments .comments-content .comment-header {
width: 100%;
float: none;
clear: both;
margin: 0px 0 0px -35px;
padding: 0;
}
}
]]></b:skin>
<style>
/*-------Typography and ShortCodes-------*/
.firstcharacter{float:left;color:#27ae60;font-size:75px;line-height:60px;padding-top:4px;padding-right:8px;padding-left:3px}.post-body h1,.post-body h2,.post-body h3,.post-body h4,.post-body h5,.post-body h6{margin-bottom:15px;color:#2c3e50}blockquote{font-style:italic;color:#888;border-left:5px solid #27ae60;margin-left:0;padding:10px 15px}blockquote:before{content:&#39;\f10d&#39;;display:inline-block;font-family:FontAwesome;font-style:normal;font-weight:400;line-height:1;-webkit-font-smoothing:antialiased;-moz-osx-font-smoothing:grayscale;margin-right:10px;color:#888}blockquote:after{content:&#39;\f10e&#39;;display:inline-block;font-family:FontAwesome;font-style:normal;font-weight:400;line-height:1;-webkit-font-smoothing:antialiased;-moz-osx-font-smoothing:grayscale;margin-left:10px;color:#888}.button{background-color:#2c3e50;float:left;padding:5px 12px;margin:5px;color:#fff;text-align:center;border:0;cursor:pointer;border-radius:3px;display:block;text-decoration:none;font-weight:400;transition:all .3s ease-out !important;-webkit-transition:all .3s ease-out !important}a.button{color:#fff}.button:hover{background-color:#27ae60;color:#fff}.button.small{font-size:12px;padding:5px 12px}.button.medium{font-size:16px;padding:6px 15px}.button.large{font-size:18px;padding:8px 18px}.small-button{width:100%;overflow:hidden;clear:both}.medium-button{width:100%;overflow:hidden;clear:both}.large-button{width:100%;overflow:hidden;clear:both}.demo:before{content:&quot;\f06e&quot;;margin-right:5px;display:inline-block;font-family:FontAwesome;font-style:normal;font-weight:400;line-height:normal;-webkit-font-smoothing:antialiased;-moz-osx-font-smoothing:grayscale}.download:before{content:&quot;\f019&quot;;margin-right:5px;display:inline-block;font-family:FontAwesome;font-style:normal;font-weight:400;line-height:normal;-webkit-font-smoothing:antialiased;-moz-osx-font-smoothing:grayscale}.buy:before{content:&quot;\f09d&quot;;margin-right:5px;display:inline-block;font-family:FontAwesome;font-style:normal;font-weight:400;line-height:normal;-webkit-font-smoothing:antialiased;-moz-osx-font-smoothing:grayscale}.visit:before{content:&quot;\f14c&quot;;margin-right:5px;display:inline-block;font-family:FontAwesome;font-style:normal;font-weight:400;line-height:normal;-webkit-font-smoothing:antialiased;-moz-osx-font-smoothing:grayscale}.widget .post-body ul,.widget .post-body ol{line-height:1.5;font-weight:400}.widget .post-body li{margin:5px 0;padding:0;line-height:1.5}.post-body ul li:before{content:&quot;\f105&quot;;margin-right:5px;font-family:fontawesome}pre{font-family:Monaco, &quot;Andale Mono&quot;, &quot;Courier New&quot;, Courier, monospace;background-color:#2c3e50;background-image:-webkit-linear-gradient(rgba(0, 0, 0, 0.05) 50%, transparent 50%, transparent);background-image:-moz-linear-gradient(rgba(0, 0, 0, 0.05) 50%, transparent 50%, transparent);background-image:-ms-linear-gradient(rgba(0, 0, 0, 0.05) 50%, transparent 50%, transparent);background-image:-o-linear-gradient(rgba(0, 0, 0, 0.05) 50%, transparent 50%, transparent);background-image:linear-gradient(rgba(0, 0, 0, 0.05) 50%, transparent 50%, transparent);-webkit-background-size:100% 50px;-moz-background-size:100% 50px;background-size:100% 50px;line-height:25px;color:#f1f1f1;position:relative;padding:0 7px;margin:15px 0 10px;overflow:hidden;word-wrap:normal;white-space:pre;position:relative}pre:before{content:&#39;Code&#39;;display:block;background:#F7F7F7;margin-left:-7px;margin-right:-7px;color:#2c3e50;padding-left:7px;font-weight:400;font-size:14px}pre code,pre .line-number{display:block}pre .line-number a{color:#27ae60;opacity:0.6}pre .line-number span{display:block;float:left;clear:both;width:20px;text-align:center;margin-left:-7px;margin-right:7px}pre .line-number span:nth-child(odd){background-color:rgba(0, 0, 0, 0.11)}pre .line-number span:nth-child(even){background-color:rgba(255, 255, 255, 0.05)}pre .cl{display:block;clear:both}#contact{background-color:#fff;margin:30px 0 !important}#contact .contact-form-widget{max-width:100% !important}#contact .contact-form-name,#contact .contact-form-email,#contact .contact-form-email-message{background-color:#FFF;border:1px solid #eee;border-radius:3px;padding:10px;margin-bottom:10px !important;max-width:100% !important}#contact .contact-form-name{width:47.7%;height:50px}#contact .contact-form-email{width:49.7%;height:50px}#contact .contact-form-email-message{height:150px}#contact .contact-form-button-submit{max-width:100%;width:100%;z-index:0;margin:4px 0 0;padding:10px !important;text-align:center;cursor:pointer;background:#27ae60;border:0;height:auto;-webkit-border-radius:2px;-moz-border-radius:2px;-ms-border-radius:2px;-o-border-radius:2px;border-radius:2px;text-transform:uppercase;-webkit-transition:all .2s ease-out;-moz-transition:all .2s ease-out;-o-transition:all .2s ease-out;-ms-transition:all .2s ease-out;transition:all .2s ease-out;color:#FFF}#contact .contact-form-button-submit:hover{background:#2c3e50}#contact .contact-form-email:focus,#contact .contact-form-name:focus,#contact .contact-form-email-message:focus{box-shadow:none !important}.alert-message{position:relative;display:block;background-color:#FAFAFA;padding:20px;margin:20px 0;-webkit-border-radius:2px;-moz-border-radius:2px;border-radius:2px;color:#2f3239;border:1px solid}.alert-message p{margin:0 !important;padding:0;line-height:22px;font-size:13px;color:#2f3239}.alert-message span{font-size:14px !important}.alert-message i{font-size:16px;line-height:20px}.alert-message.success{background-color:#f1f9f7;border-color:#e0f1e9;color:#1d9d74}.alert-message.success a,.alert-message.success span{color:#1d9d74}.alert-message.alert{background-color:#DAEFFF;border-color:#8ED2FF;color:#378FFF}.alert-message.alert a,.alert-message.alert span{color:#378FFF}.alert-message.warning{background-color:#fcf8e3;border-color:#faebcc;color:#8a6d3b}.alert-message.warning a,.alert-message.warning span{color:#8a6d3b}.alert-message.error{background-color:#FFD7D2;border-color:#FF9494;color:#F55D5D}.alert-message.error a,.alert-message.error span{color:#F55D5D}.fa-check-circle:before{content:&quot;\f058&quot;}.fa-info-circle:before{content:&quot;\f05a&quot;}.fa-exclamation-triangle:before{content:&quot;\f071&quot;}.fa-exclamation-circle:before{content:&quot;\f06a&quot;}.post-table table{border-collapse:collapse;width:100%}.post-table th{background-color:#eee;font-weight:bold}.post-table th,.post-table td{border:0.125em solid #333;line-height:1.5;padding:0.75em;text-align:left}@media (max-width: 30em){.post-table thead tr{position:absolute;top:-9999em;left:-9999em}.post-table tr{border:0.125em solid #333;border-bottom:0}.post-table tr + tr{margin-top:1.5em}.post-table tr,.post-table td{display:block}.post-table td{border:none;border-bottom:0.125em solid #333;padding-left:50%}.post-table td:before{content:attr(data-label);display:inline-block;font-weight:bold;line-height:1.5;margin-left:-100%;width:100%}}@media (max-width: 20em){.post-table td{padding-left:0.75em}.post-table td:before{display:block;margin-bottom:0.75em;margin-left:0}}
.FollowByEmail {
    clear: both;
}
.widget .post-body ol {
    padding: 0 0 0 15px;
}
.post-body ul li {
    list-style: none;
}
</style>

<![CDATA[
/*------Layout (No Edit)----------*/
body#layout #body-wrapper {
    padding: 0;
    width: 800px
}
body#layout .theme-opt {
    display: block !important;
}
body#layout .section h4 {
   color: #333!important;
text-align:center;
text-transform:uppercase;
letter-spacing:1.5px;
}
body#layout .top-bar-social, body#layout .top-bar-menu {
       width: 47.3%;
}
body#layout .headerleft {
    width: 250px;
}
body#layout .headerright {
    width: 460px;
}
body#layout .ticker .widget {
    height: auto;
    overflow: visible;
}
body#layout .ticker .widget-content {
    height: auto;
}
body#layout .post-author-widget, body#layout .post-author-social {
    display: block;
visibility:visible;
    height: auto;
  width: 42.43%;
float:left;
}
body#layout .post-author-social {
float:right;
}
body#layout .tm-menu {
    height: auto;
}
body#layout #menu {
  display: block;
visibility:visible;
    height: auto;
}
body#layout #menu .widget {
  display: block;
visibility:visible;
}
body#layout .preload {
opacity:1;
}
body#layout #content-wrapper {
margin: 0 auto;
padding:0;
}
body#layout #adwidegt1 .widget, body#layout #adwidegt2 .widget, body#layout #adwidegt3 .widget {
display:block;
}
body#layout #main-wrapper {
    float:left;
    width: 70%;
    margin: 0;
    padding: 0
}
body#layout .header-search {
    display: none;
}
body#layout #sidebar-wrapper {
    float: right;
    width: 30%;
    margin: 0;
    padding: 0;
}
body#layout .sidebar.section {
  background-color: #ff7f00!important;
border: 1px solid #ca7900;
}
body#layout .sidetabs .section {
 background-color: #ffd400 !important;
    border: 1px solid #dcbc20;
}
body#layout #sidebar-wrapper .section .widget-content {
   border-color: #5a7ea2!important
}
body#layout .section .draggable-widget .widget-wrap2 {
   background-color: #ff5722!important
}

body#layout #main-wrapper #main {
    margin-right: 4px;
   background-color: #5a7ea2;
border-color: #34495e
}
body#layout #main-wrapper #main h4 {
    color: #fff!important
}
body#layout .layout-widget-description {
    display: none!important
}
body#layout #Blog1 .widget-content {
    border-color: #34495e
}
body#layout .add_widget {
    background: #ebebeb;
    border: 1px solid #dddddd;
}
body#layout .menu-wrap {
    height: auto;
}
body#layout .menu-tab {
    display: none;
}
body#layout .FollowByEmail .widget-content:before {
    display: none;
}
body#layout .bottom-bar-social {
    display: block;
    float: none;
}
body#layout #lower, body#layout #lower-wrapper, body#layout #lowerbar-wrapper, body#layout #ty_footer, body#layout #header-wrappers {
    padding: 0;
}
body#layout .editlink {
background: #ff5722;
color: #fff !important;
padding: 0 3px;
line-height: 18px;
border: 1px solid #00b0bd;
border-radius: 3px;
text-transform: uppercase;
letter-spacing: 1px;
text-decoration: none !important;
}
body#layout .lowerbar {
    width: 28.07%;
    float: left;
}
/*------Layout (end)----------*/
]]>
