
var  publicUrl='http://static.cofool.com/public';

var stock = {

	//用户信息
	all_balance:'',
	balance:'',
	uid:'',
	gid:'',

	//交易属性
	data:'',
	priceIds : new Array("sell5", "sell4", "sell3", "sell2", "sell1", "buy1", "buy2", "buy3", "buy4", "buy5"),
	amountIds : new Array("sell5Amount", "sell4Amount", "sell3Amount", "sell2Amount", "sell1Amount", "buy1Amount", "buy2Amount", "buy3Amount", "buy4Amount", "buy5Amount"),
	hideArgs : new Array("nowprice","closePrice", "openPrice", "highPrice", "lowePrice","surgedLimit","declineLimit"),

	trade:function(options){
		var _this = stock;
		_this.uid = options.uid;
		_this.gid = options.gid;
		_this.web_id = options.web_id;
		_this.archive = options.archive;
		_this.ac = options.ac == undefined ? '' : options.ac;
		all_balance = options.all_balance == undefined ? 0 : options.all_balance;
		_this.changeItem(all_balance);
		_this.trigger();
		_this.page(all_balance);
		_this.zst();
	},

	//资金股票持仓流水
	changeItem:function(all_balance){

		$("#bottom a").click(function(){

			$(this).addClass('hover').siblings().removeClass('hover');
			var type = $(this).attr('type'),
				uid = stock.uid,
				gid = stock.gid,
				web_id =stock.web_id,
				archive = stock.archive,
				param = '';

			if($(this).attr('data-id')){
				uid = $(this).attr('data-id');
			}

			if(!type){
				layer.msg('操作有误！', {icon: 2});
				return false;
			}else if(type == 'history'){
				$(".search").show();
				param = {type:type,gid:gid,uid:uid,web_id:web_id,archive:archive,start:$("#start").val(),end:$("#end").val(),'_':Math.random()};
			}else{
				$(".search").hide();
				param = {type:type,gid:gid,uid:uid,web_id:web_id,archive:archive,all_balance:all_balance,'_':Math.random()};
			}

			var load = layer.load();

			$.post('http://www.cofool.com/Home/User/tradeItem.html',param,function(data){
				$("#table2").html(data);
				layer.close(load);
				stock.m1234();
				if(stock.ac == 'detail'){
					$('.cz').html('--');
				}
			},'text')
		
		});

		$("#bottom a").eq(0).click();
	},
	//搜索触发
	trigger:function(){
		$(".int").on('click',function(){
			$("#bottom a").eq(3).click();
		})
	},
	m1234:function(){
	
		$('.m12').mouseenter(function(){
		 	$(this).attr('src',publicUrl+'/images/m2.png');
		}).mouseleave(function(){
		   	$(this).attr('src',publicUrl+'/images/m1.png');
		});   

		$('.m34').mouseenter(function(){
		 	$(this).attr('src',publicUrl+'/images/m4.png');
		}).mouseleave(function(){
		   	$(this).attr('src',publicUrl+'/images/m3.png');
		});   
	},

	//走势图
	percentageText:function(a){
		var precision=2;
		if (a > 0) {
			return '<span style="color:#FD0100">' + Highcharts.numberFormat(a,precision) + "%</span>"
		} else if (a < 0) {
			return '<span style="color:#008200">' + Highcharts.numberFormat(a,precision) + "%</span>"
		}
		return '<span style="color:#333">' + Highcharts.numberFormat(a,precision) + "%</span>"
	},
	
	in_array:function(needle,haystack){
		// 得到needle的类型
		var type = typeof needle;
		if(type == 'string' || type =='number') {
			 for(var i in haystack){
				if(haystack[i] == needle){
				  return true;
				}
		   }
		}
	   return false;
	},

	    formatterDate : function(date) {
        var datetime = date.getFullYear()
                + "-"// "年"
                + ((date.getMonth() + 1) >= 10 ? (date.getMonth() + 1) : "0"
                        + (date.getMonth() + 1))
                + "-"// "月"
                + (date.getDate() <= 10 ? "0" + date.getDate() : date
                        .getDate());
        return datetime;
    },
    //分页
	page:function(all_balance){
		var _this = stock;
		$('#table2').on('click','.pagination a',function(){
			var type = $("#act").val(),
				uid = $("#uid").val(),
				gid = stock.gid,
				web_id =stock.web_id,
				archive = stock.archive,
				param = '';

		    if($(this).attr('data-p')){
			   var p =$(this).attr('data-p')
		    }else{
			   var p =parseInt($(this).html())
		    }

			if(type == 'history'){
				param = {p:p,type:type,uid:uid,gid:gid,web_id:web_id,archive:archive,start:$("#start").val(),end:$("#end").val()};
			}else if(type == 'position'){
				param = {p:p,type:type,uid:uid,gid:gid,web_id:web_id,archive:archive,all_balance:all_balance};
			}else{
				param = {p:p,type:type,uid:uid,gid:gid,web_id:web_id,archive:archive};
			}

			var load = layer.load(3);
			$.post('http://www.cofool.com//Home/User/tradeItem.html',param,function(data){
				$("#table2").html(data);
				layer.close(load);
				stock.m1234();
				if(stock.ac == 'detail'){
					$('.cz').html('--');
				}
			},'text')
		   	return false;
		})
	},
	trade_zst:function(){
		$.ajax({
			dataType: "json",
			url: 'http://www.cofool.com//Home/User/getTrend.html',
			data:{userId:stock.uid,web_id:stock.web_id,archive:stock.archive},
			cache: false,
			scriptCharset: "GB2312",
			success: function(data) {

				if (typeof(data)!="undefined"){	
					
					var xzongup = [],
						xzsup = [],
						xdate = [];
					if (data){	
						for (i = 0; i < data.length; i++) {
							var s1=data[i].zsdata,
								s2=data[i].zongup,
								s3=data[i].zsup;
							xdate.push(s1);
							xzongup.push([s1, s2]);
							xzsup.push([s1, s3]);
						}

					}
					
					if(!xzongup.length){
						$("#stock_chart img").attr('src',publicUrl+'/images/tu_hq.png');
					}else{
						$('#stock_chart').highcharts({
							title: {
								text: '总资产走势图',
					            style:{
					            	fontSize: '12px',
					            	color:'#777'
					            },
					            align: 'center' //center
							},
							credits: { 
								enabled: false  
							}, 
							xAxis: {
								 //range: 6 * 24 * 3600 * 1000 ,// 6天
								tickLength:false,
								labels: {
									formatter: function() {
										return '';
									 }
							   }
							},

							yAxis: {
								title: {
									text: null
								},
								plotLines: [{
									value: 0,
									color: '#808080'
								}],
								labels: {
									x: -6,
									formatter: function() {
										return  this.value + '%';
									}
								}
							},
		
							 tooltip: {
								shared: true,
								formatter: function() {
									//console.log(this.point)
									var s = '<span style="font-size: 12px">'+ xdate[this.x] + "</span><br/>";
									s += "个人资产涨幅: " + stock.percentageText(this.points[0].y,'') + "<br/>";
									s += "沪深300涨幅: " + stock.percentageText(this.points[1].y,'') + "<br/>";
									return s
								}
							},
							series: [{
								name: '资产涨幅',
								color :'#BF0B23',
								data: xzongup
							
							}, {
								name: '沪深300涨幅',
								data: xzsup
								//data: [-0.2, 0.8, 5.7, 11.3, 17.0, 22.0, 24.8, 24.1, 20.1, 14.1, 8.6, 2.5]
							}]
						});
					}
					
					
				}
			}
		});
	},
	zst:function(){

		var _this = stock;
		//走势图切换
		$(".search-left span").click(function(){
			$(this).addClass('hover').siblings().removeClass('hover');
			var i = $(this).index();

			if($(this).attr('data')){
				;
			}else{
				$(this).attr('data',1);
				if(i == 0){
					;
				}else if(i == 1){
					$('#sub-sch-menu li a').eq(0).click();
				}else if(i == 2){
					_this.trade_zst();
				}
			}
			$('.zst .p_zst').hide().eq(i).show();
		})

		/* 状态搜索子菜单 */
		$(".search-form").find(".drop-down").hover(function(){
			$("#sub-sch-menu").removeClass("hidden");
		},function(){
			$("#sub-sch-menu").addClass("hidden");
		});

		$('#sub-sch-menu li a').click(function(){
			var d = $(this).attr('data');
			$('.pzst').html($(this).text());
			$("#sub-sch-menu").addClass("hidden");	
			$.post('http://www.cofool.com/Home/User/zst.html',{d:d,userId:stock.uid,web_id:stock.web_id,archive:stock.archive,'_':Math.random()},function(data){
					var xzongup = [],
						xzsup = [],
						xcangwei = [],	
						xdate = [],
						xdayup = [];
					if (data){	
						for (i = 0; i < data.length; i++) {
							var s1=data[i].zsdata,
								s2=data[i].zongup,
								s3=data[i].zsup,
								s4=data[i].cangwei,
								s5=data[i].lastdayup;


							xdate.push(s1);
							xzongup.push([s1, s2]);
							xzsup.push([s1, s3]);
							xcangwei.push([s1, s4]);
							xdayup.push({
								    name:s1,
									y:Math.abs(s5),// the volume
									color: s5>0 ? '#ff0000' : '#008200'
								});
						}
						stock.lineZst(xzongup,xzsup,xcangwei,xdayup,xdate);
					}
					
					
				})
		})
	},

	lineZst:function(xzongup,xzsup,xcangwei,xdayup,xdate){

		//s5取最大
		var xdayup_index_max = 0;
        for(var x = 0; x < xdayup.length; x++){  
            if(xdayup[xdayup_index_max].y < xdayup[x].y){  
                 xdayup_index_max = x;  
            }   
        }  

		$('#line').highcharts({
	        title: {
	            text: null
	        },
	        scrollbar: {
				height: 14
			},
			navigator: {
				enabled: false
			},
			exporting: {
				enabled: false
			},
			credits: { 
				enabled: false  
			}, 

	        xAxis: {
				labels: {
					formatter: function() {
						return xdate[this.value] ? xdate[this.value].substr(xdate[this.value].length-5) : '';
					 }
			   }
	        },	
	       //y轴
			yAxis: [
				{
					opposite: false,
					title: {
						text: '月资产涨幅',
						style:{fontSize:"12px",fontFamily:"宋体, Arial, sans-serif",fontWeight:"normal",color:"black"}
					},
					labels: {
						align: 'right',
						x: -3,
						y:4,
						formatter: function() {
							return  this.value + '%';
						}
					},
					showLastLabel:true,
					height: 110,
					lineWidth: 1
				}, 
				{
					opposite: false,
					title: {
						text: '仓位',
						style:{fontSize:"12px",fontFamily:"宋体, Arial, sans-serif",fontWeight:"normal",color:"black"}
					},
					labels: {
						align: 'right',
						x: -3,
						y:4,
						formatter: function() {
								if ( this.value == "100") {
									return  '满仓';
								} else if ( this.value == "50") {
									return '半仓';
								} else if ( this.value == "0") {
									return '空仓';
								}
								//else {
	//								return this.value+'%';
	//							}
						}
					},
					max:100,
					min:0,
					showLastLabel:true,
					tickInterval:50,
					height: 50,
					lineWidth: 1,
					top: 140,
					offset: 0
				}, 
				{
					opposite: false,
					title: {
						text: '日收益率',
						style:{fontSize:"12px",fontFamily:"宋体, Arial, sans-serif",fontWeight:"normal",color:"black"}
					},
					labels: {
						align: 'right',
						x: -3,
						y:4,
						formatter: function() {
							return  this.value + '%';
						}
					},
					max:xdayup[xdayup_index_max].y,
					tickInterval:Highcharts.numberFormat(xdayup[xdayup_index_max].y/2,2),
					showLastLabel:true,
					top: 210,
					height: 75,
					offset: 0,
					lineWidth: 1
				}],		
	        tooltip: {
	            valueSuffix: '%'
	        },
	        legend: {
	            enabled:false
	        },
	        tooltip: {
				shared: true,
				formatter: function() {
					//console.log(this.point)
					if(xdayup[this.x]['color'] == '#008200'){
						this.points[3].y = -1*this.points[3].y;
					}
					var s = '<span style="font-size: 12px">'+ xdate[this.x] + "</span><br/>";
					s += '<b style="color:#BF0B23">个人月资产涨幅:</b>' +stock.percentageText(this.points[0].y,'') + "<br/>";
					s += '<b style="color:#7cb5ec">沪深300涨幅:</b>' + stock.percentageText(this.points[1].y,'') + "<br/>";
					s += "仓位: " +  this.points[2].y.toFixed(2) + "%<br/>";
					s += "日收益率: " +  stock.percentageText(this.points[3].y,'') + "<br/>";
					return s
				}
			},
	        series: [{
	            name: '资产涨幅',
	            color :'#BF0B23',
	            data: xzongup,
	            marker : {
					enabled : true,
					radius : 3
				},
				shadow : true,
				dataGrouping: {
					enabled: false
				}
	        }, {
	            name: '沪深300涨幅',
	            data: xzsup,
	            marker : {
					enabled : true,
					radius : 3
				},
				shadow : true,
				dataGrouping: {
					enabled: false
				}
	        }, {
				name: '仓位',
				data: xcangwei,
				yAxis: 1,
				marker : {
					enabled : true,
					radius : 3
				},
				shadow : true,
				dataGrouping: {
					enabled: false
				}
			},{
				type: 'column',
				name: '日收益率为正',
				data: xdayup,
				color: '#FD0100',
				yAxis: 2,
				dataGrouping: {
					enabled: false
				}
			}]
	    });
	}
}
