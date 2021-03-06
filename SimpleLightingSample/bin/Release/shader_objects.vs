#version 430 core

layout (location = 0) in vec2 position;

layout (location = 1) uniform mat4 projection;
layout (location = 2) uniform mat4 model_matrix;
layout (location = 3) uniform vec4 v_color = vec4(1.0);

layout (location = 0) out vec4 f_color;

void main()
{
    f_color = v_color;
	gl_Position = projection * model_matrix * vec4(position.x, position.y, 0.0, 1.0);
}
