(function ($) {
    $.getJSON("../SQLData/GetArticle.ashx", function (data) {
        console.log(data);
        $.each(data, function (i, obj) {
            $("#bloglist").append("<h2><a title=" + obj.ArticleTitle + " href='#' target='_blank'>" + obj.ArticleTitle + "</a></h2>");
            $("#bloglist").append("<ul style='margin-bottom:5px;'><li style='list-style-type: none;padding-bottom:-5px;'><p style='text-indent: 2em;height: 48px;overflow:hidden;'>" + obj.ArticleContent.substring(1, 100) + "...........</p></li>");
            $("#bloglist").append("<li style='list-style-type: none;padding: 0 0 0 20px;margin-bottom:10px;'><p class='readmore'><a title=" + obj.ArticleTitle + " href='#' target='_blank'>阅读全文&gt;&gt;</a></p></li>");
            $("#bloglist").append("<li style='list-style-type: none;'><p class='dateview'><span style='padding-left:20px;'>" + data_string(obj.PublishTime) + "</span><span>编辑： " + obj.userName + "</span><span> 个人博客：[<a href='#'>神仙博客网站</a>]</span></p></li></ul>");
        })
    })
    function data_string(str) {
        var d = eval('new ' + str.substr(1, str.length - 2));
        var ar_date = [d.getFullYear(), d.getMonth() + 1, d.getDate()];
        for (var i = 0; i < ar_date.length; i++) ar_date[i] = dFormat(ar_date[i]);
        return ar_date.join('-');

        function dFormat(i) { return i < 10 ? "0" + i.toString() : i; }
    }
})(jQuery)