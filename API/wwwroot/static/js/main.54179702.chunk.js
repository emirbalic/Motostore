(this.webpackJsonpclient=this.webpackJsonpclient||[]).push([[0],{62:function(e,t,c){},69:function(e,t,c){"use strict";c.r(t);var n=c(0),r=c.n(n),a=c(49),i=c.n(a),s=(c(62),c(14)),o=c(53),j=c(98),d=c(111),h=c(101),b=c(100),l=c(102),u=c(104),x=c(96),O=c(106),p=c(107),g=c(105),f=c(108),m=c(99),v=c(1);function k(e){var t=e.product;return Object(v.jsxs)(l.a,{children:[Object(v.jsx)(u.a,{avatar:Object(v.jsx)(x.a,{sx:{bgcolor:"secondary.dark"},children:t.name.charAt(0).toUpperCase()}),title:t.name,titleTypographyProps:{sx:{fontWeight:"bold",color:"primary.dark"}}}),Object(v.jsx)(O.a,{sx:{height:140,backgroundSize:"contain",bgcolor:"primary.light"},image:t.pictureUrl,title:t.name}),Object(v.jsxs)(p.a,{children:[Object(v.jsxs)(g.a,{gutterBottom:!0,color:"secondary",variant:"h5",children:["$",(t.price/100).toFixed(2)]}),Object(v.jsxs)(g.a,{variant:"body2",color:"text.secondary",children:[t.brand," / ",t.type]})]}),Object(v.jsxs)(f.a,{children:[Object(v.jsx)(m.a,{size:"small",children:"Add to cart"}),Object(v.jsx)(m.a,{size:"small",children:"View"})]})]})}function y(e){var t=e.products;return Object(v.jsx)(b.a,{container:!0,spacing:6,children:t.map((function(e){return Object(v.jsx)(b.a,{item:!0,xs:3,children:Object(v.jsx)(k,{product:e})},e.id)}))})}function C(){var e=Object(n.useState)([]),t=Object(s.a)(e,2),c=t[0],r=t[1];return Object(n.useEffect)((function(){fetch("/api/products").then((function(e){return e.json()})).then((function(e){return r(e)}))}),[]),Object(v.jsx)(v.Fragment,{children:Object(v.jsx)(y,{products:c})})}var F=c(109),S=c(110),T=c(95);function E(e){var t=e.darkMode,c=e.handleThemeChange;return Object(v.jsx)(F.a,{position:"static",sx:{mb:4},children:Object(v.jsxs)(S.a,{children:[Object(v.jsx)(g.a,{variant:"h6",children:"RE-STORE"}),Object(v.jsx)(T.a,{checked:t,onChange:c})]})})}var w=function(){var e=Object(n.useState)(!1),t=Object(s.a)(e,2),c=t[0],r=t[1],a=c?"dark":"light",i=Object(o.a)({palette:{mode:a,background:{default:"light"===a?"#eaeaea":"#121212"}}});return Object(v.jsxs)(j.a,{theme:i,children:[Object(v.jsx)(d.a,{}),Object(v.jsx)(E,{darkMode:c,handleThemeChange:function(){r(!c)}}),Object(v.jsx)(h.a,{children:Object(v.jsx)(C,{})})]})},z=function(e){e&&e instanceof Function&&c.e(3).then(c.bind(null,112)).then((function(t){var c=t.getCLS,n=t.getFID,r=t.getFCP,a=t.getLCP,i=t.getTTFB;c(e),n(e),r(e),a(e),i(e)}))};i.a.render(Object(v.jsx)(r.a.StrictMode,{children:Object(v.jsx)(w,{})}),document.getElementById("root")),z()}},[[69,1,2]]]);
//# sourceMappingURL=main.54179702.chunk.js.map