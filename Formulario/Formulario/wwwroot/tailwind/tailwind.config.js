/** @type {import('tailwindcss').Config} */
module.exports = {
	content: [
		'../../Componentes/**/*.{razor,html,js}',
		'../../Pages/**/*.{razor,html,js}',
		'../Pages/**/*.{razor,html,js}',
		'../../Pages/**/**/*.{razor,html,js}',
		'../../Layout/*.{razor,html,js}',
		'../componentes/*.{razor,html,js}',
		'../*.{razor,html,js}'
	],
	theme: {
		extend: {},
		screens: {
			'mobile': { 'max': '500px' },
			'sm': '640px',
			'md': '768px',
			'lg': '1024px',
			'xl': '1280px',
			'2xl': '1536px'
		}
	},
	plugins: []
}
