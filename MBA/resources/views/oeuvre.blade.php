<!DOCTYPE html>
<html>

@extends('layouts.master')

@section('title')

@section('menu')
    @parent
@stop


@section('content')

<br> <br> <br>

<?php
$oeuvre = DB::table('OeuvreParSondage')->whereid($o_id)->first()
?>


<table class="tab">
	<tr>
		<th>
			<?php echo $oeuvre->titre ?> <hr>
		</th>
		<th rowspan="3">
			<div class="zoom">
			<div class="image">
				<?php echo "<img src='{$oeuvre->url_img}' alt='profile Pic' height='200' width='200'>" ?>
			</div>
			</div>
		</th>
	</tr>
	<tr>
		<td>
			Auteur: <?php echo $oeuvre->auteur ?>  <hr> 
		</td>
	</tr>
	<tr>
		<td>
			<?php echo $oeuvre->description ?> <hr> 
		</td>
	</tr>

</table>
	
<br> <br>	

	<form method="post" action="../../../voter/traitement/<?php echo"$s_id"?>/<?php echo"$o_id"?>/" id ="form">
	{!! csrf_field() !!}
		
			<div class="captcha"> 
	 			{!! app('captcha')->display($attributes = [], $lang = "Fr") !!}
			</div>
			<div class="button"> 
				<input class="myButton" type="submit" value="Voter" />
			</div>
	</form>	

@stop	
</html>
