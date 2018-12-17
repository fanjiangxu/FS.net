$(function () {
    if ($("#categoryID").val() == "10") {
        window.location.href = "http://en.www.cofool.com/Stock/Simulate/Introduce";
    }

    var json = "[";
    $.each($(".competition_list li"), function (index, item) {
        if (json != "[") json += ",";
        ////介绍Url
        var introduceUrl = $(item).find(".homepage>a").attr("href");
        introduceUrl = "http://www.cofool.com" + introduceUrl;
        //排行榜Url
        var topUrl = $(item).find(".top>a").attr("href");
        topUrl = "http://www.cofool.com" + topUrl;
        //比赛ID
        var l = topUrl.split('/');
        var matchID = l[l.length - 1];
        var allStr = $(item).find(".course_info").first().context.innerText.toString().trim();
        allStr = allStr.replace("报名介绍排行榜", "");
        allStr = "{Name:'" + allStr;
        allStr = allStr.replace("参赛人数：", "',Num:").replace(/[\r\n]/g, "");
        allStr = allStr.replace("平均收益率：", ",RateStr:'").replace(/[\r\n]/g, "");
        allStr = allStr.replace("创建时间：", "',CreateTime:'").replace(/[\r\n]/g, "");
        allStr += "',MatchID:'" + matchID + "',";
        allStr += "IntroduceUrl:'" + introduceUrl + "',";
        allStr += "TopUrl:'" + topUrl + "'}";
        json += allStr;        
    })
    json += "]";
    json = $.trim(json).replace(/[\r\n]/g, "");
    if (json == "[]") {
        var nextCategoryID=parseInt($("#categoryID").val()) + 1;
        setTimeout(
       function () {
           window.location.href = "http://en.www.cofool.com/stock/simulate/index?" + "&pageIndex=" + $("#pageIndex").val() + "&categoryID=" + nextCategoryID + "&url=http://www.cofool.com/Group/more/category/" + nextCategoryID + "/page/" + $("#pageIndex").val();
       }, 3000);
        return false;
    }
    //保存到数据库
    $.ajax({
        url: "/Stock/Simulate/SaveMatch",
        type: "post",
        data: { data: json },
        dataType: "json",
        success: function (data) {
        }
    });
    setTimeout(
        function () {
            window.location.href = "/stock/simulate/index?" + "&pageIndex=" + $("#pageIndex").val() + "&categoryID=" + $("#categoryID").val() + "&url=http://www.cofool.com/Group/more/category/" + $("#categoryID").val() + "/page/" + $("#pageIndex").val();
    }, 6000);
});