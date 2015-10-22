#version 430 core

layout (binding = 0) uniform sampler2D tex;

layout (location = 0) in vec4 f_color;
layout (location = 1) in vec2 f_texcoord;

out vec4 color;

void main()
{
    color = vec4(1.0);
    /*
	vec4 tcolor = texture(tex, vec2(f_texcoord.x, f_texcoord.y));
	color = tcolor * f_color;
    if (color.w < 0.01)
    {
        discard;
    }
    */
}
