/*!
 * inputAUTY jQuery Plugin
 *
 * @file: jquery-inputauty.js
 * @author: Francisco Neves (@fntneves)
 * @site: www.francisconeves.com
 * @license: MIT License
 */

(function( $ ){

	$.fn.inputauty = function( options )
	{
		/*
		 * Our default settings
		 * Hope you don't need to change anything, with these settings
		 */
		var settings = $.extend(
		{
			// Development Mode
			// This will activate console debug messages
			development: false,

			// Trigger Class
			// This class will be used to apply styles
			class: "inputauty",

			// Use text input ?
			// If false, then only an icon represents the input
			input: true,

			// Separator between inputs' messages
			// If you use this separator for anything, choose a new one
			separator: "|",

			// Default Checked Message
			// This message will be visible when input is checked
			checked_input: "Checked",

			// Default UnChecked Message
			// This message will be visible when input is unchecked
			unchecked_input: "Unchecked",

			// Minimum input Width
			// This value will be used to apply a minimum width to the text inputs
			minimum_width: false,

			// Use the greatest width between two text inputs ?
			// If this has a true value, then input width will be the greatest between inputs
			same_width: true
		}, options);

		/*
		 * Let's create the core function
		 * It will try to cover all settings and mistakes of using
		 */
		return this.each(function()
		{
			var $object = $( this );
			var use_inputs = true;
			var inputs;
			var inputs_object;
			var input_id;

			// Test if object is a check input
			// Don't mess me up, come on
			if( $object.is( ":checkbox" ) === false && $object.is( ":radio" ) === false )
				return this;

			// Add "inputauty" class to all checkboxes
			// So you can apply some custom styles
			$object.addClass( settings.class );

			// Get the value of "data-inputauty" attribute
			// Then, we have the inputs for each case (or not, as we will see)
			inputs = $object.attr( "data-inputauty" );

			use_inputs = settings.input;

			// It's time to check if it's going to the right way
			// Null values, more inputs than expected or no inputs will be handled here
			if( use_inputs === true )
			{
				if( inputs == null || inputs.length === 0 )
				{
					// If attribute has no input and we want to use, then use the default inputs
					inputs_object = new Array();
					inputs_object[0] = settings.unchecked_input;
					inputs_object[1] = settings.checked_input;
				}
				else
				{
					// Ok, ok, it's time to split Checked and Unchecked inputs
					// We split, by the "settings.separator" option
					inputs_object = inputs.split( settings.separator );

					// Now, let's check if exist _only_ two inputs
					// If there's more than two, then we do not use inputs :(
					// Else, do some additional tests
					if( inputs_object.length > 2 )
					{
						use_inputs = false;
						debug( settings.development, "There's more than two inputs. inputAUTY will not use inputs." );
					}
					else
					{
						// If there's just one input (no split by "settings.separator"), it will be used for both cases
						// Here, we have the possibility of use the same input for both cases
						if( inputs_object.length === 1 )
							debug( settings.development, "There's just one input. inputAUTY will use this one for both cases." );
					}
				}
			}

			/*
			 * Let's begin the beauty
			 */

			// Start hiding ugly checkboxes
			// Obviously, we don't need native checkboxes :O
			$object.css({ display : "none" });

			// We don't need more data-inputauty attributes!
			// Ok, ok, it's just for beauty improvement
			$object.removeAttr( "data-inputauty" );

			// Now, grab checkbox ID Attribute for "input" tag use
			// If there's no ID Attribute, then generate a new one
			input_id = $object.attr( "id" );

			if( input_id == null )
			{
				var input_id_number = 1 + Math.floor( Math.random() * 1024000 );
				input_id = "inputauty-" + input_id_number;

				// Is there any element with this random ID ?
				// If exists, then increment until get an unused ID
				while( $( input_id ).length !== 0 )
				{
					input_id_number++;
					input_id = "inputauty-" + input_id_number;
					debug( settings.development, "Holy crap, between 1024 thousand numbers, one raised a conflict. Trying again." );
				}

				$object.attr( "id", input_id );
			}

			// Now, add necessary tags to make this work
			// Here, we're going to test some control variables and act properly
			$object.after( create( input_id, inputs_object, use_inputs ) );

			// Now, add "min-width" to input
			// Let's say the truth, a fixed width is more beautiful than a variable width
			if( settings.minimum_width !== false )
				$object.next( "input[for=" + input_id + "]" ).css({ "min-width": settings.minimum_width });

			// Now, add "min-width" to input
			// Let's say the truth, a fixed width is more beautiful than a variable width
			if( settings.same_width != false && settings.input == true )
			{
				var input_object = $object.next( "input[for=" + input_id + "]" );
				var unchecked_width = getRealWidth(input_object.find( "span.inputauty-unchecked" ));
				var checked_width = getRealWidth(input_object.find( "span.inputauty-checked" ));

				if( unchecked_width > checked_width )
					input_object.find( "span.inputauty-checked" ).width( unchecked_width );
				else
					input_object.find( "span.inputauty-unchecked" ).width( checked_width );
			}
		});
	};

	/*
	 * Tricky code to work with hidden elements, like tabs.
	 * Note: This code is based on jquery.actual plugin.
	 * https://github.com/dreamerslab/jquery.actual
	 */
	function getRealWidth( element )
	{
		var width = 0;
		var $target = element;
		var style = 'position: absolute !important; top: -1000 !important; ';

		$target = $target.clone().attr('style', style).appendTo('body');
		width = $target.width(true);
		$target.remove();

		return width;
	}

	function debug( debug, message )
	{
		if( debug && window.console && window.console.log )
			window.console.log( "jQuery-inputAUTY: " + message );
	};

	function create( input_id, messages_object, input )
	{
		var block;
		var unchecked_message;
		var checked_message;

		if( messages_object == null )
			unchecked_message = checked_message = "";
		else
		{
			unchecked_message = messages_object[0];

			// If checked message is null, then put the same text of unchecked message
			if( messages_object[1] == null )
				checked_message = unchecked_message;
			else
				checked_message = messages_object[1];
		}

		if( input == true )
		{
			block = '<input for="' + input_id + '">' +
						'<span class="inputauty-unchecked-image"></span>' +
						'<span class="inputauty-unchecked">' + unchecked_message + '</span>' +
						'<span class="inputauty-checked-image"></span>' +
						'<span class="inputauty-checked">' + checked_message + '</span>' +
					'</input>';
		}
		else
		{
			block = '<input for="' + input_id + '">' +
						'<span class="inputauty-unchecked-image"></span>' +
						'<span class="inputauty-checked-image"></span>' +
					'</input>';
		}

		return block;
	};

}( jQuery ));
